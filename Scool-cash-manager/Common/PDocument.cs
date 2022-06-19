using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scool_cash_manager.Common
{
    public abstract class PDocument
    {
        public string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ficher_rapport.pdf");

        //les propriétés...
        public string Entete { get; set; }
        public string NomEtablissement { get; set; }
        public string AdresseEtablissement{get;set;}
        public string TitreDocument { get; set; }

        //le constructeur

       public PDocument()
        {


        }

        public virtual bool PrintToDefaultPrinter()
        {
            return true;
        }

        public virtual bool PrintToSpecificPrinter()
        {
           return true;
        }
        
    }
}
