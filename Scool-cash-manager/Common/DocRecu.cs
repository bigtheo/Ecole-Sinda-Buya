using iTextSharp.text;
using iTextSharp.text.pdf;
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
            set { value = Operations.ObtenirNomEtablissement(); }
        }
        #endregion

        #region Constructeur de la classe

        public DocRecu(TypeRecu typeRecu){
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
                    Entete = "Inscription";
                    Numero = Operations.ObtenirNumeroRecuMensuel();
                    break;
                case TypeRecu.Examen:
                    break;
                case TypeRecu.Accompte:
                    break;
                case TypeRecu.Autre:
                    break;
            }
        }
        #endregion


    }
}
