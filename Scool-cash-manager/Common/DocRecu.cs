using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scool_cash_manager.Common
{
    public class DocRecu
    {
        public static string Folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SchoolCashManager";
        public static string Filename = Path.Combine(Folder, "fichier_rapport.pdf");
        public static string RapportfileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ficher_rapport.pdf");

        #region Propriété de la classe
        private string _numero;

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }


        public enum TypeRecu { Inscription, Mensuel, Etat, exEtat, Accompte, Examen, Manuel, Autre }
        public long IdEleve { get; set; }
        public string Noms { get; set; }
        public string Classe { get; set; }
        public DateTime DatePaie { get; set; } = DateTime.Now;
        public string Designation { get; set; }
        public decimal Montant { get; set; }

        #endregion

        #region propriétés privées
        public string Entete { get; set; }
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
                    Entete = "Frais de Démarrage";
                    Numero = Operations.ObtenirNumeroRecuMensuel();
                    IdEleve = long.Parse(Operations.ObtenirIDdernierEleve());
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
                case TypeRecu.exEtat:
                    Entete = "Paiement EXETAT";
                    Numero = Operations.ObtenirNumeroRecuExetat();
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

            Rectangle taille = new Rectangle(297, 720);
            Document doc = new Document(taille);
            doc.SetMargins(doc.LeftMargin, doc.RightMargin, -17, doc.Bottom);
            try
            {

                Directory.CreateDirectory(Folder);

                FileStream fs = new FileStream(Filename, FileMode.Create, FileAccess.Write);
                PdfWriter.GetInstance(doc, fs);

                doc.Open(); //ouverture du document pour y écrire
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion Création du document

            #region les polices utilisées

            Font fontA = new Font(Font.FontFamily.COURIER, 18, 1, BaseColor.BLACK);
            Font fontB = new Font(Font.FontFamily.TIMES_ROMAN, 10, 2, BaseColor.BLACK);
            Font fontC = new Font(Font.FontFamily.HELVETICA, 14, 2, BaseColor.BLUE);


            #endregion les polices utilisées

            #region tableau principle

            #region entete
            Paragraph p_etablissement = new Paragraph(Etablissement, fontA);
            p_etablissement.Alignment = 1;

            Paragraph p_Etablissment = new Paragraph(Etablissement, fontA)
            {
                Alignment = 1
            };

            Paragraph p_addresse = new Paragraph(Addresse, fontB)
            {
                Alignment = 1
            };

            doc.Add(p_Etablissment);
            doc.Add(p_addresse);
            doc.Add(new Paragraph("\n"));
            doc.Add(new LineSeparator());

            #endregion

            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 90;
            table.SetWidths(new float[] { 35, 65 });



            Paragraph p_Titre = new Paragraph(Entete)
            {
                Alignment = 1
            };

            Font font = new Font(Font.FontFamily.HELVETICA, 14, 1);

            table.AddCell("N° élève");
            table.AddCell(new Paragraph(IdEleve.ToString(), font));

            table.AddCell("Classe");
            table.AddCell(new Paragraph(Classe, font));


            table.AddCell("N° Reçu.");
            table.AddCell(Numero);


            table.AddCell("Raison");
            table.AddCell(Designation);

            table.AddCell("Montant");
            table.AddCell(Montant.ToString("c"));

            table.AddCell("Date");
            table.AddCell(DatePaie.ToString());


            Paragraph passerLigne = new Paragraph(Environment.NewLine);

            #endregion tableau principle

            #region ajout des composants au documents
            /*ajaout de l'en-tête du bordereau */

            doc.Add(p_Titre);

            Paragraph p_noms = new Paragraph(Noms, font);
            p_noms.Alignment = 1;

            doc.Add(p_noms);

            doc.Add(passerLigne);
            doc.Add(table);

            doc.Add(passerLigne);
            doc.Add(new DottedLineSeparator());
            Paragraph p_signature = new Paragraph($"Designed by Big Hope Software\n{Operations.ObtenirTelephone()} ", fontB);
            p_signature.Alignment = 1;
            doc.Add(p_signature);

            doc.Add(passerLigne);
            doc.Add(new DottedLineSeparator());

            //on ferme le document après écriture
            doc.Close();


            #endregion

            
            PrintPDFToASpecificPrinter();

        }

        public void PrintPDFToDefaultPrinter()
        {
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo = new ProcessStartInfo()
                    {
                        CreateNoWindow = true,
                        Verb = "print",
                        FileName = Filename
                    };

                    p.Start();

                    p.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

        }
        public static void PrintPDFToASpecificPrinter()
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.AllowSomePages = true;
                printDialog.AllowSelection = true;
                printDialog.PrinterSettings.ToPage = 1;
                printDialog.PrinterSettings.FromPage = 1;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    var StartInfo = new ProcessStartInfo
                    {
                        CreateNoWindow = true,
                        UseShellExecute = true,
                        Verb = "printTo",
                        Arguments = "\"" + printDialog.PrinterSettings.PrinterName + "\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = Filename,
                       
                    };

                    Process.Start(StartInfo);
                }

            }


        }

    }
}
