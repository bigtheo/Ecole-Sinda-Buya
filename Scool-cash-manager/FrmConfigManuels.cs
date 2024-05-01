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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var sql = "update autres_frais set intitule=@p_intitule, montant=@p_montant where id=@p_id";
            using (MySqlCommand cmd=new MySqlCommand(sql,Connexion.con))
            {

                MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int64)
                {
                    Value = txt_code.Text,
                };
                MySqlParameter p_intitule = new MySqlParameter("@p_intitule", MySqlDbType.VarChar, 100)
                {
                    Value = txt_designation.Text
                };

                MySqlParameter p_montant = new MySqlParameter("@p_montant", MySqlDbType.Decimal, 100)
                {
                    Value = nup_montant.DecimalValue
                };
                cmd.Parameters.Add(p_id);
                cmd.Parameters.Add(p_montant);
                cmd.Parameters.Add(p_intitule);
                DialogResult r = MessageBox.Show("Voulez-vous vraiment modifier ?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
                if(r == DialogResult.Yes)
                {
                    try
                    {
                        int rowsAffected= cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enregistrement effectué", "enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Enregistrement échoué", "enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            if (long.TryParse(dgvliste.CurrentRow.Cells[0].Value.ToString(), out long numero_recu))
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = Connexion.con;
                        cmd.CommandText = "delete from autres_frais where id=@id";
                        DialogResult result = MessageBox.Show($"Voulez-vous vraiment supprimer le reçu N° {numero_recu}", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int64);
                        p_id.Value = numero_recu;
                        cmd.Parameters.Add(p_id);
                        if (result == DialogResult.Yes)
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            MessageBox.Show($"opération effectuée avec succès, {rowsAffected} ligne(s) affectées", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Views.AfficherTout("v_autres_frais", dgvliste);
                }
            }
            else
            {
                MessageBox.Show("conversion impossible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}