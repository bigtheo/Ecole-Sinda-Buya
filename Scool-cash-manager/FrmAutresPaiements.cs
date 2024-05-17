using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class FrmAutresPaiements : Form
    {
        public FrmAutresPaiements()
        {
            InitializeComponent();
            PopulateFrais();
        }

        private void SupprimerRecu()
        {
            if (long.TryParse(dgvliste.CurrentRow.Cells[0].Value.ToString(), out long numero_recu))
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = Connexion.con;
                        cmd.CommandText = "delete from autres_paiements where id=@id";
                        DialogResult result = MessageBox.Show($"Voulez-vous vraiment supprimer le reçu N° {numero_recu}", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int64);
                        p_id.Value = numero_recu;
                        cmd.Parameters.Add(p_id);
                        if (result == DialogResult.Yes)
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            MessageBox.Show($"opération effectuée avec succès, {rowsAffected} ligne(s) affectées", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("conversion impossible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmManuel_Load(object sender, EventArgs e)
        {
            AfficherEleveSolvableFrais();
        }

        
        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            new frmNouveauPaiementAutresFrais().ShowDialog();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            #region Création du document
            this.Cursor = Cursors.WaitCursor;
            Document doc = new Document();


            try
            {
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ficher_rapport.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs);

                PDFBackgroundHelper myEvent = new PDFBackgroundHelper();
                pdfWriter.PageEvent = myEvent;


            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);

            }
            #endregion

            doc.Open(); //on ouvre le document pour y écrire...


            #region Police utilisé
            Font police_titre = FontFactory.GetFont("calibri", 14, 1);
            Font police_titre_principal = FontFactory.GetFont("calibri", 14);
            Font police_entete_tableau = FontFactory.GetFont("Century Gothic", 11, 1);
            Font police_Cellule = FontFactory.GetFont("arial", 8);
            Font police_Cellule_intitule_manuel = FontFactory.GetFont("arial", 8);
            Paragraph PasserLigne = new Paragraph(Environment.NewLine);
            #endregion

            #region en-tête du document
            string t_nom_ecole = Operations.ObtenirNomEtablissement() + "\n";
            string t_classe = "Classe : Toutes\n";
            string t_date_du_jour = "Imprimé le  : " + DateTime.Now.ToString() + "\n";
            string t_date_impresion = "Journal du : " + dtp_date.Text;

            string t_title_principal = "Journal des autres paiements ";
            doc.Add(PasserLigne);

            Phrase phrase_nom_ecole = new Phrase(t_nom_ecole, police_titre);
            Phrase phrase_classe = new Phrase(t_classe, police_titre);
            Phrase phrase_date_du_jour = new Phrase(t_date_du_jour, police_Cellule);
            Phrase phrase_date_impression = new Phrase(t_date_impresion, police_Cellule);

            Chunk chunkUnderline = new Chunk(t_title_principal, police_titre_principal);
            chunkUnderline.SetUnderline(0.4f, -2f);
            Paragraph p_title_principal = new Paragraph(chunkUnderline)
            {
                Alignment = 1 //on centre le titre principal

            };


            //on ajoute les paragraphes au document
            doc.Add(phrase_nom_ecole);
            doc.Add(phrase_classe);
            doc.Add(phrase_date_du_jour);
            doc.Add(phrase_date_impression);
            doc.Add(p_title_principal);
            doc.Add(PasserLigne);

            #endregion

            #region le tableau

            PdfPTable tableau;

          
                tableau = new PdfPTable(6); //un tableau de 5 colonnes N°, nom, postnom et prenom
                tableau.SetWidths(new float[] { 5, 20,10,7,15,10});
                Phrase p_heure = new Phrase("Heure", police_entete_tableau);
                Phrase p_Id = new Phrase("Id", police_entete_tableau);
                Phrase p_Noms = new Phrase("Noms", police_entete_tableau);
                Phrase p_Classe = new Phrase("Classe", police_entete_tableau);
                Phrase p_designation = new Phrase("Désignation", police_entete_tableau);
                Phrase p_montant = new Phrase("Montant", police_entete_tableau);

                
                tableau.AddCell(p_Id);
                tableau.AddCell(p_Noms);
                tableau.AddCell(p_Classe);
                tableau.AddCell(p_heure);
                tableau.AddCell(p_designation);
                tableau.AddCell(p_montant);

                int nombre_ligne = dgvliste.Rows.Count;

                for (int i = 0; i < nombre_ligne; i++)
                {


                    tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[0].Value.ToString(), police_Cellule));
                    tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[1].Value.ToString(), police_Cellule));
                    tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[2].Value.ToString(), police_Cellule));
                    tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[3].Value.ToString(), police_Cellule));
                    tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[4].Value.ToString(), police_Cellule));
                    tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[5].Value.ToString(), police_Cellule));

                }

            #endregion

            doc.Add(tableau);
            doc.Close();
            this.Cursor = Cursors.Default;
            new FrmApercuAvantImpression(DocRecu.RapportfileName).Show();

        }

        private void AfficherEleveSolvableFrais()
        {
            Connexion.Connecter();
            var sql = "select p.id,concat_ws(' ',e.nom,e.postnom,e.prenom)Noms,c.nom classe,p.date_paie 'Date et heure' , f.Intitule,f.montant \r\nfrom autres_paiements p \r\nInner join autres_frais f on f.id = p.frais_id Inner join eleve e on e.id = p.eleve_id \r\ninner join classe c on c.id =e.classe_id where date(p.date_paie) = date(@p_date)\r\n\r\nUNION\r\nselect '01','Total (payé en entière) ','--', '--' , '--',ifnull(sum(f.montant),0) \r\nfrom autres_paiements p Inner join autres_frais f on f.id = p.frais_id \r\nInner join eleve e on e.id = p.eleve_id \r\ninner join classe c on c.id =e.classe_id where date(p.date_paie) = date(@p_date)\r\n\r\nUNION \r\nselect  a.id,concat_ws(' ', e.nom,e.postnom,e.prenom) Noms, c.nom classe ,a.date_paie 'Date Heure',concat_ws(' ', f.intitule, 'avance'),a.montant  from accomptes_autres_paiements a\r\n inner join eleve e on e.id = a.eleve_id inner join classe c on c.id = e.classe_id\r\n inner join autres_frais f on f.id = a.frais_id where date(a.date_paie) = date(@p_date)\r\n\r\nUNION\r\n\r\n select '01','Total (accompte) ','--', '--' , '--',ifnull(sum(montant),0) Montant\r\nfrom accomptes_autres_paiements where date(date_paie) = date(@p_date);";
            
            using (MySqlCommand cmd=new MySqlCommand (sql,Connexion.con))
            {
                MySqlParameter p_date = new MySqlParameter("@p_date", MySqlDbType.Date)
                {
                    Value =dtp_date.Value
                };
                cmd.Parameters.Add(p_date);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    try
                    {
                        da.Fill(table);
                        dgvliste.DataSource = table;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    
                } 
            }
        }

        private void GetEleveAyantPayeUnFrais()
        {
            Connexion.Connecter();
            var sql = "select p.id,concat_ws(' ',p.id,e.nom,e.postnom,e.prenom)Noms,c.nom classe,p.date_paie 'Date et heure' ,\r\n f.Intitule,f.montant from autres_paiements p \r\nInner join autres_frais f on f.id = p.frais_id Inner join eleve e on e.id = p.eleve_id \r\ninner join classe c on c.id =e.classe_id where f.intitule=@p_frais \r\nUNION\r\nselect '01','Total','--', '--' , 'Total',ifnull(sum(f.montant),0) from autres_paiements p \r\nInner join autres_frais f on f.id = p.frais_id \r\nInner join eleve e on e.id = p.eleve_id \r\ninner join classe c on c.id =e.classe_id where f.intitule=@p_frais\r\n\r\nUNION \r\nSELECT \t'***','***','accompte','***','**','***'\r\nUNION\r\n\r\nselect e.id,concat_ws(' ',e.nom,e.postnom,e.prenom) Noms,c.nom Classe,aap.date_paie,af.intitule,aap.montant from accomptes_autres_paiements ap \r\ninner join eleve e on e.id = ap.eleve_id \r\ninner join classe c on c.id = e.classe_id\r\ninner join accomptes_autres_paiements aap on aap.eleve_id = e.id\r\ninner join autres_frais af on af.id = aap.frais_id where af.intitule =@p_frais";

            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                MySqlParameter p_frais = new MySqlParameter("@p_frais", MySqlDbType.VarChar)
                {
                    Value = cbx_frais.Text
                };
                cmd.Parameters.Add(p_frais);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();

                    try
                    {
                        da.Fill(table);
                        dgvliste.DataSource = table;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            AfficherEleveSolvableFrais();
        }
        void PopulateFrais()
        {
            var sql = "select intitule from autres_frais";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbx_frais.Items.Add(dr[0]);
                }

                dr.Close();
            }
        }

        private void cbx_frais_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEleveAyantPayeUnFrais();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
          
                SupprimerRecu();
                GetEleveAyantPayeUnFrais();
        }
    }
}