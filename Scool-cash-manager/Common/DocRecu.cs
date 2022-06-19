using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scool_cash_manager.Common
{
    public class DocRecu
    {
        #region Propriété de la classe
        private string _numero;

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public enum TypeRecu { Inscription, Mensuel, Etat, Accompte, Examen, Manuel, Autre }
        public long IdEleve { get; set; }
        public string Noms { get; set; }
        public DateTime DatePaie { get; set; } = DateTime.Now;
        public string Designation { get; set; }
        public decimal Montant { get; set; }

        #endregion

        #region propriétés privées
        private string Entete { get; set; }
        private string Etablissement
        {
            get;
            set;
        }

        public string Addresse { get; set; }
        #endregion

        #region Constructeur de la classe
        public DocRecu()
        {
            Etablissement = Operations.ObtenirNomEtablissement();
            Addresse = Operations.ObtenirAdresse();
            DatePaie = DateTime.Now;
        }
        public DocRecu(TypeRecu typeRecu) : this()
        {
            switch (typeRecu)
            {
                case TypeRecu.Inscription:
                    Entete = "Inscription";
                    Numero = Operations.ObtenirNumeroRecuMensuel();
                    break;
                case TypeRecu.Mensuel:
                    Entete = "Paiement mensuel";
                    Numero = Operations.ObtenirNumeroRecuMensuel();
                    break;
                case TypeRecu.Etat:
                    Entete = "Paiement frais de l'état";
                    Numero = Operations.ObtenirNumeroRecuMensuel();
                    break;
                case TypeRecu.Examen:
                    Entete = "Paiement frais examen";
                    Numero = Operations.ObtenirNumeroRecuMensuel();
                    break;
                case TypeRecu.Accompte:
                    Entete = "Paiement Accompte";
                    Numero = Operations.ObtenirNumeroRecuAccompte();
                    break;
                case TypeRecu.Autre:
                    Entete = "Paiement autres frais";
                    Numero = _numero;
                    break;
            }



        }
        #endregion

        #region methode de la classe

        public void CreerRecu()
        {
            #region Création du document

            Rectangle taille = new Rectangle(297, 720); // le format(longueur et largueur) du récu
            Document doc = new Document(taille);
            // doc.SetMargins(30, 30, 7, 30);
            try
            {
                string folderstring = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CashManager";
                Directory.CreateDirectory(folderstring);

                string fileName = Path.Combine(folderstring, "fichier_rapport.pdf");
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);
                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font police_entete = FontFactory.GetFont("TIMES NEW ROMAN", 13);
            police_entete.SetStyle(1);

            #endregion les polices utilisées

            #region tableau principle

            #region entete
            doc.Add(new Phrase(Etablissement, police_entete));
            doc.Add(new Paragraph(Addresse, police_entete));
            #endregion

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell_libelle = new PdfPCell(new Phrase("Libellé", police_entete));
            PdfPCell cell_valeur = new PdfPCell(new Phrase("Valeur", police_entete));
            Paragraph p_IntituleCompte = new Paragraph(Entete)
            {
                Alignment = 1
            };
            Paragraph p_Titre = new Paragraph(Entete)
            {
                Alignment = 1
            };

            Font font = new Font(Font.FontFamily.HELVETICA, 14, 1);
            table.AddCell(cell_libelle);
            table.AddCell(cell_valeur);

            table.AddCell("ID élève");
            table.AddCell(new Paragraph(IdEleve.ToString(), font));

            table.AddCell("N° Reçu.");
            table.AddCell(Numero);


            table.AddCell("Raison");
            table.AddCell(Designation);

            table.AddCell("Montant");
            table.AddCell(Montant.ToString("c"));


            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle

            /*ajaout de l'en-tête du bordereau */

            doc.Add(p_Titre);
            doc.Add(p_IntituleCompte);
            doc.Add(passerLigne);
            doc.Add(table);

            doc.Add(new DottedLineSeparator());
            doc.Add(new Phrase("Designed by LES ", font));
            doc.Add(new DottedLineSeparator());

            //on ferme le document après écriture
            doc.Close();
            new FrmApercuAvantImpression().ShowDialog();

        }

        #endregion

    }
}
