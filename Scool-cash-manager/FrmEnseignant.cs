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
    public partial class FrmEnseignant : Form
    {
        public FrmEnseignant()
        {
            InitializeComponent();
            
            AfficherNombreEnseignantAyantDesEnfant();
            AfficherNombreEnfantAffilie();
            Cbx_filter.SelectedIndex = 0;
        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            new FrmNouveauEnseigant().ShowDialog();
        }

        private void BtnNouvelleAssociation_Click(object sender, EventArgs e)
        {
            new FrmLienDeParente().ShowDialog();
        }

        #region Selection
        private void AfficherAffiliation()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select a.id,en.id as Matricule ,en.noms as Enseignant,concat_ws(' ',e.nom,e.postnom) as Enfants" +
                    " from associer as a " +
                    "inner join enseignant as en on en.id = a.enseignant_id " +
                    "inner join eleve as e on e.id = a.eleve_id ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvliste.DataSource = table;

                    if (dgvliste.Rows.Count == 0)
                    {
                        dgvliste.Hide();
                        lblMessage.Show();
                    }
                    else
                    {
                        dgvliste.Show();
                        lblMessage.Hide();
                    }
                }
            }
        }

        private void AfficherDerrogation() 
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select d.Id 'N°', d.eleve_id 'Matricules',Concat_ws(' ',e.nom,e.postnom,e.prenom) Noms,c.nom classe,d.Jour 'Jours' , d.created_time 'Date d''enregistrement' from derrogation d inner join eleve e on e.id = d.eleve_id inner join classe c on c.id= e.classe_id";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvliste.DataSource = table;

                    if (dgvliste.Rows.Count == 0)
                    {
                        dgvliste.Hide();
                        lblMessage.Show();
                    }
                    else
                    {
                        dgvliste.Show();
                        lblMessage.Hide();
                    }
                }
            }
        }

        private void AfficherNombreEnseignantAyantDesEnfant()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select count(*) from enseignant";
                try
                {
                    lbl_nombre_enseigant.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AfficherNombreEnfantAffilie()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select count(*) from associer";
                try
                {
                    lbl_nombre_enfant.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            if (Cbx_filter.SelectedIndex == 0)
            {
                ImprimerEnfantAffilier();
            }
            else
            {
                ImprimerDerrogation();
            }
        }

        void ImprimerEnfantAffilier()
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
            Font police_titre = FontFactory.GetFont("Arial", 14, 1);
            Font police_titre_principal = FontFactory.GetFont("Times new roman", 12);
            Font police_entete_tableau = FontFactory.GetFont("Century Gothic", 12, 1);
            Font police_Cellule = FontFactory.GetFont("arial", 8);
            Paragraph PasserLigne = new Paragraph(Environment.NewLine);
            #endregion

            #region en-tête du document
            string t_nom_ecole = Operations.ObtenirNomEtablissement() + "\n";
            string t_classe = "Classe : Toutes\n";
            string t_date_du_jour = "Imprimé le  : " + DateTime.Now.ToString() + "\n";

            string t_title_principal = "Liste des élèves pris en charge";
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

            #endregion

            #region le tableau
            PdfPTable tableau = new PdfPTable(4)
            {
                WidthPercentage = 100
            }; //un tableau de 5 colonnes N°, nom, postnom et prenom
            tableau.SetWidths(new float[] { 6, 7, 22, 22 });

            Phrase p_numero = new Phrase("N°", police_entete_tableau);
            Phrase p_Id = new Phrase("Id", police_entete_tableau);
            Phrase p_nomParent = new Phrase("Noms parants", police_entete_tableau);
            Phrase p_nomEnfant = new Phrase("Noms enfants", police_entete_tableau);



            tableau.AddCell(p_numero);
            tableau.AddCell(p_Id);
            tableau.AddCell(p_nomParent);
            tableau.AddCell(p_nomEnfant);


            int nombre_ligne = dgvliste.Rows.Count;


            for (int i = 0; i < nombre_ligne; i++)
            {

                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[0].Value.ToString(), police_Cellule));
                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[1].Value.ToString(), police_Cellule));
                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[2].Value.ToString(), police_Cellule));
                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[3].Value.ToString(), police_Cellule));

            }

            doc.Add(tableau);
            #endregion


            doc.Close();
            this.Cursor = Cursors.Default;
            new FrmApercuAvantImpression(DocRecu.RapportfileName).Show();
        }


        private void ImprimerDerrogation()
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
            Font police_titre = FontFactory.GetFont("Arial", 14, 1);
            Font police_titre_principal = FontFactory.GetFont("Times new roman", 12);
            Font police_entete_tableau = FontFactory.GetFont("Century Gothic", 12, 1);
            Font police_Cellule = FontFactory.GetFont("arial", 8);
            Paragraph PasserLigne = new Paragraph(Environment.NewLine);
            #endregion

            #region en-tête du document
            string t_nom_ecole = Operations.ObtenirNomEtablissement() + "\n";
            string t_classe = "Classe : Toutes\n";
            string t_date_du_jour = "Imprimé le  : " + DateTime.Now.ToString() + "\n";

            string t_title_principal = "Liste des élèves pris en charge";
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

            #endregion

            #region le tableau
            PdfPTable tableau = new PdfPTable(6)
            {
                WidthPercentage = 100
            }; //un tableau de 5 colonnes N°, nom, postnom et prenom
            tableau.SetWidths(new float[] { 6, 7, 22, 12,6,20 });

            Phrase p_numero = new Phrase("N°", police_entete_tableau);
            Phrase p_Id = new Phrase("Id", police_entete_tableau);
            Phrase p_nomParent = new Phrase("Noms de l'élève", police_entete_tableau);
            Phrase p_nomEnfant = new Phrase("Classe", police_entete_tableau);
            Phrase p_jour = new Phrase("Jours", police_entete_tableau);
            Phrase p_dateEnregistrement = new Phrase("Date d'enregistrement", police_entete_tableau);
             


            tableau.AddCell(p_numero);
            tableau.AddCell(p_Id);
            tableau.AddCell(p_nomParent);
            tableau.AddCell(p_nomEnfant);
            tableau.AddCell(p_jour);
            tableau.AddCell(p_dateEnregistrement);


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

            doc.Add(tableau);
            #endregion


            doc.Close();
            this.Cursor = Cursors.Default;
            new FrmApercuAvantImpression(DocRecu.RapportfileName).Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new FrmNouveauDeroge().ShowDialog();
        }

        private void Cbx_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cbx_filter.SelectedIndex)
            {
                case 0:
                    AfficherAffiliation();
                    btnModifierAssociation.Enabled = true;
                    
                    break;
                case 1:
                    AfficherDerrogation();
                    btnModifierAssociation.Enabled = false;
                    
                    break;
            }
            
        }
    
        private void SupprimerAssociation()
        {
            var sql = "delete from associer where id=@p_id";
            Connexion.Connecter();

            using (MySqlCommand cmd =new MySqlCommand (sql,Connexion.con))
            {
                MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int64)
                {
                    Value = dgvliste.CurrentRow.Cells[0].Value
                } ;

                cmd.Parameters.Add(p_id);

                try
                {
                    int rowCount = cmd.ExecuteNonQuery();

                    if (rowCount > 0)
                        MessageBox.Show("Suppression effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); ; ; ;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }

            }
        }

        private void btnModifierAssociation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SupprimerAssociation();
                AfficherAffiliation();
            }

        }
    }
}