using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Scool_cash_manager
{
    public partial class FrmConfigManuels : Form
    {
        public FrmConfigManuels()
        {
            InitializeComponent();
        }

        #region enregistrement
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!ChampsOk())
                return;

            string sql = "Insert into autres_frais(intitule,montant) values(@intitule,@montant)";

            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                MySqlParameter p_intitule = new MySqlParameter("@intitule", MySqlDbType.VarChar)
                {
                    Value = CbxFrais.Text
                };

                MySqlParameter p_montant = new MySqlParameter("@montant", MySqlDbType.Decimal)
                {
                    Value = nupdownMontant.Value
                };

                cmd.Parameters.Add(p_intitule);
                cmd.Parameters.Add(p_montant);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Frais ajouté avec succès.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CbxFrais.Text = String.Empty;
                        nupdownMontant.Value = 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"une erreur s'est produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


           
        }

        private bool ChampsOk()
        {
            if (!String.IsNullOrEmpty(CbxFrais.Text.Trim()) && nupdownMontant.Value!=0)
            {
                return true;
            }else
            {
                MessageBox.Show("Veuillez remplir les champs vides", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region au chargement du formulaire ...

        private void FrmConfigManuels_Load(object sender, EventArgs e)
        {
            Views.AfficherTout("v_autres_frais", dgvliste);
        }

        private void TabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Views.AfficherTout("v_autres_frais", dgvliste);
        }
        #endregion
    }
}