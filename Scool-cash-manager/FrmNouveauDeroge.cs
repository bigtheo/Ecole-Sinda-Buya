using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class FrmNouveauDeroge : Form
    {
        public FrmNouveauDeroge()
        {
            InitializeComponent();
        }

        private void InsertDerogation()
        {
            var sql = "Insert into derrogation(jour,eleve_id) values(@p_jour,@p_eleve_id)";

            Connexion.Connecter();
            using (MySqlCommand cmd=  new MySqlCommand(sql,Connexion.con))
            {
                MySqlParameter p_eleve_id = new MySqlParameter("@p_eleve_id", MySqlDbType.Int64)
                {
                    Value = Txt_matricule.Text
                };

                MySqlParameter p_jour = new MySqlParameter("@p_jour", MySqlDbType.Int16)
                {
                    Value = nup_jour.Value
                };

                cmd.Parameters.Add(p_eleve_id);
                cmd.Parameters.Add(p_jour);

                try
                {
                    
                    var rowsCount = cmd.ExecuteNonQuery();

                    if(rowsCount > 0)
                    {
                        MessageBox.Show("Insertion effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 1062:
                            MessageBox.Show($"Cet élève est déjà dérrogé.\ncode : {ex.Number}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                            break;
                        default:
                            MessageBox.Show($"Une erreur s'est produit\ncode : {ex.Number}\nMessage :{ex.Message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                            break;
                    }
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }

            }
        }

        private void Txt_matricule_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Txt_nom.Text = Operations.ObtenirNomEleveById(Txt_matricule.Text);
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            InsertDerogation();
        }
    }
}
