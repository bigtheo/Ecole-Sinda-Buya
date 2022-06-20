using System;
using System.IO;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class FrmApercuAvantImpression : Form
    {
        public FrmApercuAvantImpression(string filename)
        {
            InitializeComponent();
            AfficherLeFichier(filename);
        }

        private void AfficherLeFichier(string filename)
        {
            
            axFoxitCtl1.OpenFile(filename);
      
        }


    }
}