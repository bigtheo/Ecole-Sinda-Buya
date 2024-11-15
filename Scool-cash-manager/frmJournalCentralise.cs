﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class frmJournalCentralise : Form
    {
        public frmJournalCentralise()
        {
            InitializeComponent();
        }

        #region au chargement du formulaire...

        private void FrmJournalCentralise_Load(object sender, EventArgs e)
        {
            Lister_journalCentralise(1);
        }

        private void Lister_journalCentralise(Int16 section_id)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "Ps_JournalCentraliseMaternelle";
                cmd.CommandType = CommandType.StoredProcedure;
                //le parametre
                MySqlParameter p_date = new MySqlParameter("@p_date", MySqlDbType.Date)
                {
                    Direction = ParameterDirection.Input,
                    Value = dtp_date.Value
                };
                MySqlParameter p_section_id = new MySqlParameter("@p_section", MySqlDbType.Int16)
                {
                    Direction = ParameterDirection.Input,
                    Value = section_id
                };
                cmd.Parameters.Add(p_date);
                cmd.Parameters.Add(p_section_id);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    try
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
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message,"erreur");
                    }
                   
                }
            }
        }

        #endregion au chargement du formulaire...

        private void Dtp_date_ValueChanged(object sender, EventArgs e)
        {
            Lister_journalCentralise(1);
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            ImprimerJournalCentralise();
        }

    private void ImprimerJournalCentralise()
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
            Paragraph PasserLigne = new Paragraph(Environment.NewLine);
            #endregion

            #region en-tête du document
            string t_nom_ecole = Operations.ObtenirNomEtablissement() + "\n";
            string t_classe = "Classe : Toutes\n";
            string t_date_du_jour = "Imprimé le  : " + DateTime.Now.ToString() + "\n";
            string t_date_impresion = "Journal du : " + dtp_date.Text;

            string t_title_principal = "Journal  Centralisé  \n";
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


            tableau = new PdfPTable(3)
            {
                WidthPercentage = 40
            }; //un tableau de 5 colonnes N°, nom, postnom et prenom

            tableau.SetWidths(new float[] { 5, 30, 12 });
            Phrase p_numero = new Phrase("N° ", police_entete_tableau);
            Phrase p_intitule = new Phrase("Intitulé du frais", police_entete_tableau);
            Phrase p_montant = new Phrase("Montant", police_entete_tableau);

            tableau.AddCell(p_numero);
            tableau.AddCell(p_intitule);
            tableau.AddCell(p_montant);


            int nombre_ligne = dgvliste.Rows.Count;

            for (int i = 0; i < nombre_ligne; i++)
            {


                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[0].Value.ToString(), police_Cellule));
                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[1].Value.ToString(), police_Cellule));
                tableau.AddCell(new Phrase(dgvliste.Rows[i].Cells[2].Value.ToString(), police_Cellule));

            }

            doc.Add(tableau);






            doc.Close();
            this.Cursor = Cursors.Default;
            new FrmApercuAvantImpression(DocRecu.RapportfileName).Show();
        }



        #endregion

    }
}