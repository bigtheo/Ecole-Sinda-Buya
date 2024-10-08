﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class FrmAccompte : Form
    {
        public FrmAccompte()
        {
            InitializeComponent();
            ListerAccompteVerifie();
            
        }

        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xf112, 0xf012, 0);
        }

        #endregion barre de titre

        #region opérations basique ur l'accompte

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            new FrmNouvelAccompte().ShowDialog();
        }

        private void ListerAccompteParDate()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = $"select a.Id as 'N°',a.date_paie as 'Date et Heure',e.id,concat_ws(' ',e.nom,e.postnom) as Noms,c.nom as classe,f.designation,a.montant "
                    + "from accompte as a inner join frais_mensuel as f on a.frais_mensuel_id = f.id " +
                     " Inner join eleve as e on a.eleve_id = e.id " +
                     " inner join classe c on c.id = e.classe_id " +
                     "where date(a.date_paie)=@date_paie";
                MySqlParameter p_date_paie = new MySqlParameter("@date_paie", MySqlDbType.Date)
                {
                    Value = dtp_date.Value
                };
                cmd.Parameters.Add(p_date_paie);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvliste.DataSource = table;
                }
            }
        }

        private void Dtp_date_ValueChanged(object sender, EventArgs e)
        {
            ListerAccompteVerifie();
        }

        private void ListerAccompteVerifie()
        {
            ListerAccompteParDate();
            if (dgvliste.Rows.Count > 0)
            {
                dgvliste.Visible = true;
                lblMessage.Hide();
            }
            else
            {
                dgvliste.Visible = false;
                lblMessage.Show();
            }
        }

        private void Imprimer()
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

            #endregion Création du document

            doc.Open(); //on ouvre le document pour y écrire...

            #region Police utilisé

            Font police_titre = FontFactory.GetFont("Arial", 14, 1);
            Font police_titre_principal = FontFactory.GetFont("Times new roman", 12);
            Font police_entete_tableau = FontFactory.GetFont("Century Gothic", 12, 1);
            Font police_Cellule = FontFactory.GetFont("arial", 8);
            Paragraph PasserLigne = new Paragraph(Environment.NewLine);

            #endregion Police utilisé

            #region en-tête du document

            string t_nom_ecole = Operations.ObtenirNomEtablissement() + "\n";
            string t_classe = "Classe : Toutes\n";
            string t_date_du_jour = "Imprimé le  : " + DateTime.Now.ToString() + "\n";
            string t_title_principal = "Journal des accomptes";
            doc.Add(PasserLigne);

            Phrase phrase_nom_ecole = new Phrase(t_nom_ecole, police_titre);
            Phrase phrase_classe = new Phrase(t_classe, police_titre);
            Phrase phrase_date_jour = new Phrase(t_date_du_jour, police_Cellule);
            Chunk chunkUnderline = new Chunk(t_title_principal, police_titre_principal);
            chunkUnderline.SetUnderline(0.4f, -2f);
            Paragraph p_title_principal = new Paragraph(chunkUnderline)
            {
                Alignment = 1 //on centre le titre principal
            };

            //on ajoute les paragraphes au document
            doc.Add(phrase_nom_ecole);
            doc.Add(phrase_classe);
            doc.Add(phrase_date_jour);
            doc.Add(p_title_principal);
            doc.Add(PasserLigne);

            #endregion en-tête du document

            #region le tableau

            PdfPTable tableau = new PdfPTable(7)
            {
                WidthPercentage = 100
            }; //un tableau de 5 colonnes N°, nom, postnom et prenom
            tableau.SetWidths(new float[] { 4, 10, 6, 20,6, 10, 7 });

            Phrase p_numero = new Phrase("N°", police_entete_tableau);
            Phrase p_date_heure = new Phrase("Date et Heure", police_entete_tableau);
            Phrase p_Id = new Phrase("Id", police_entete_tableau);
            Phrase p_classe = new Phrase("Classe", police_entete_tableau);
            Phrase p_noms = new Phrase("Noms", police_entete_tableau);
            Phrase p_designation = new Phrase("Mois", police_entete_tableau);
            Phrase p_montant = new Phrase("Montant", police_entete_tableau);

            tableau.AddCell(p_numero);
            tableau.AddCell(p_date_heure);
            tableau.AddCell(p_Id);
            tableau.AddCell(p_noms);
            tableau.AddCell(p_classe);
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
                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[6].Value.ToString(), police_Cellule));
            }

            tableau.AddCell(new Phrase("01", police_Cellule));
            tableau.AddCell(new Phrase("-", police_Cellule));
            tableau.AddCell(new Phrase("-", police_Cellule));
            tableau.AddCell(new Phrase("-", police_Cellule));
            tableau.AddCell(new Phrase("-", police_Cellule));
            tableau.AddCell(new Phrase("Total", police_Cellule));
            tableau.AddCell(new Phrase(GetTotalAccompte().ToString(), police_Cellule));

            doc.Add(tableau);

            #endregion le tableau

            doc.Close();
            this.Cursor = Cursors.Default;
            new FrmApercuAvantImpression(DocRecu.RapportfileName).Show();
        }

        private Decimal GetTotalAccompte()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "Select sum(Montant) from accompte where date(date_paie)=@date";
                MySqlParameter p_date_paie = new MySqlParameter("@date", MySqlDbType.Date)
                {
                    Value = dtp_date.Value
                };
                cmd.Parameters.Add(p_date_paie);
                if (decimal.TryParse(cmd.ExecuteScalar().ToString(), out decimal result))
                {
                    return result;
                }
                return 0;
            }
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            Imprimer();
        }

        #endregion opérations basique ur l'accompte

        #region annulation des opération

        private bool DGVPossedeUnEnregistrement()
        {
            return dgvliste.Rows.Count > 0;
        }

        private void AnnulerPaiementAccompte()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = Connexion.con;
                cmd.CommandText = "Delete from accompte where id=@id";
                MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int64)
                {
                    Value = dgvliste.CurrentRow.Cells[0].Value
                };
                cmd.Parameters.Add(p_id);
                DialogResult result = MessageBox.Show($"Voulez-vous vraiment annuler l'accompte numéro {p_id.Value} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int RowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Opération effectuée avec succès, \n {RowsAffected} ligne(s) affectée(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            AnnulerPaiementAccompte();
            ListerAccompteVerifie();
        }

        private void Dgvliste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVPossedeUnEnregistrement())
            {
                btnAnnuler.Enabled = true;
            }
            else
            {
                btnAnnuler.Enabled = false;
            }
        }

        #endregion annulation des opération


      
    }
}