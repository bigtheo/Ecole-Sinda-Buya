using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scool_cash_manager.Common
{
   public static class Helper
    {
        public static string getAnneeScolaire()
        {
            using (MySqlCommand cmd=new MySqlCommand("select annee from configuration limit 1"))
            {
                cmd.Connection = Connexion.con;

                try
                {
                    return Convert.ToString(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return default;
                }

            }
        }
    }
}
