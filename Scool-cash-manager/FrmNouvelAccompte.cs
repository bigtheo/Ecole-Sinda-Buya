using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class FrmNouvelAccompte : Form
    {
        public FrmNouvelAccompte()
        {
            InitializeComponent();
        }

        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr intPtr, int v1, int v2, int v3);

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion barre de titre

        #region les méthodes qui recherches les infos sur l'élève

        private void TrouverNomClasseEleveParID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "Afficher_noms_eleve_par_id";
                    cmd.CommandType = CommandType.StoredProcedure;

                    //creation des parametres...
                    MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int32);
                    MySqlParameter p_noms_eleve = new MySqlParameter("@p_noms_eleve", MySqlDbType.VarChar, 150);
                    MySqlParameter p_classe = new MySqlParameter("@p_classe", MySqlDbType.VarChar, 15);

                    //le sens des parametres...
                    p_id.Direction = ParameterDirection.Input;
                    p_noms_eleve.Direction = ParameterDirection.Output;
                    p_classe.Direction = ParameterDirection.Output;

                    //assignation des parametres
                    cmd.Parameters.Add(p_id);
                    cmd.Parameters.Add(p_noms_eleve);
                    cmd.Parameters.Add(p_classe);

                    //ajout de l'id de l'élève au parametre
                    p_id.Value = nupdown_id.Value;

                    //exécution de la commande
                    cmd.ExecuteNonQuery();

                    //récuperation des valeurs aux paremtres OutPut
                    txt_noms.Text = p_noms_eleve.Value.ToString();
                    txt_classe.Text = p_classe.Value.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ObtenirMoisApayer()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "Ps_obtenirMoisApayer";
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter p_eleve_id = new MySqlParameter("@p_eleve_id", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input
                };
                MySqlParameter p_moisApayer = new MySqlParameter("@p_moisApayer", MySqlDbType.VarChar, 20)
                {
                    Direction = ParameterDirection.Output
                };

                p_eleve_id.Value = nupdown_id.Value;
                cmd.Parameters.Add(p_eleve_id);
                cmd.Parameters.Add(p_moisApayer);

                cmd.ExecuteNonQuery();

                txt_frais_mensuel.Text = p_moisApayer.Value.ToString();
            }
        }

        private void TrouverMontantParClasseFraisMensuelID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "ps_ObtenirMontantMensuel";
                    cmd.CommandType = CommandType.StoredProcedure;

                    //decalaration des paramtres...
                    MySqlParameter p_classe = new MySqlParameter("@p_classe", MySqlDbType.VarChar, 20);
                    MySqlParameter p_frais_mensuel_id = new MySqlParameter("@p_designation_frais", MySqlDbType.VarChar, 20);
                    MySqlParameter p_montant_frais_mensuel = new MySqlParameter("@p_montant", MySqlDbType.Decimal);
                    MySqlParameter p_montant_frais_mensuel_id = new MySqlParameter("@p_frais_mensuel_id", MySqlDbType.Int32);

                    //direction des parametres...
                    p_classe.Direction = ParameterDirection.Input;
                    p_montant_frais_mensuel.Direction = ParameterDirection.Input;
                    p_montant_frais_mensuel.Direction = ParameterDirection.Output;
                    p_montant_frais_mensuel_id.Direction = ParameterDirection.Output;

                    //assignattion de params a la cmd

                    cmd.Parameters.Add(p_frais_mensuel_id);
                    cmd.Parameters.Add(p_classe);
                    cmd.Parameters.Add(p_montant_frais_mensuel);
                    cmd.Parameters.Add(p_montant_frais_mensuel_id);

                    //les valeurs des parametres...

                    p_classe.Value = txt_classe.Text;
                    p_frais_mensuel_id.Value = txt_frais_mensuel.Text;

                    //exécution de la requette
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //récuperation du montant...
                    nup_prix.Value = Convert.ToDecimal(p_montant_frais_mensuel.Value);
                    lbl_frais_mensuel_id.Text = p_montant_frais_mensuel_id.Value.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion les méthodes qui recherches les infos sur l'élève

        #region les methodes accessoires avant l'enrgistrement

        private void CalculerTotalPaye()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select sum(montant) from accompte where frais_mensuel_id=@frais_id and eleve_id=@eleve_id";

                MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int32)
                {
                    Value = nupdown_id.Value
                };
                MySqlParameter mySqlParameter = new MySqlParameter("@frais_id", MySqlDbType.Int32)
                {
                    Value = lbl_frais_mensuel_id.Text
                };
                MySqlParameter p_frais_id = mySqlParameter;

                cmd.Parameters.Add(p_frais_id);
                cmd.Parameters.Add(p_eleve_id);
                if (decimal.TryParse(cmd.ExecuteScalar().ToString(), out decimal Total))
                {
                    nupMontantPaye.Value = Total;
                }
                else
                {
                    nupMontantPaye.Value = 0;
                }
            }
        }

        private void NupId_ValueChanged(object sender, EventArgs e)
        {
            AppelMethodes();
        }

        private void AppelMethodes()
        {
            TrouverNomClasseEleveParID();
            ObtenirMoisApayer();
            TrouverMontantParClasseFraisMensuelID();
            CalculerTotalPaye();

            nupmontantApayer.Value = 0;
            nupmontantApayer.Maximum = nup_prix.Value - nupMontantPaye.Value;
        }

        #endregion les methodes accessoires avant l'enrgistrement

        #region enrgistrement

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            EnregistrementVerifie();
        }

        private void EnregistrementVerifie()
        {
            CalculerTotalPaye();
            if (nupmontantApayer.Value > 0 && nupdown_id.Value > 0 && nupMontantPaye.Value + nupmontantApayer.Value <= nup_prix.Value)
            {
                EnregistrerAccompte();
                CreerRecu();
            }
            else
            {
                MessageBox.Show("Veuillez vérifier les informations avant d'enrgistrer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void EnregistrerAccompte()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "Insert into Accompte(Id,date_paie,montant,frais_mensuel_id,eleve_id) values(@Id,@date_paie,@montant,@frais_mensuel_id,@eleve_id)";

                MySqlParameter p_Id = new MySqlParameter("@Id", MySqlDbType.Int32);
                MySqlParameter p_date = new MySqlParameter("@date_paie", MySqlDbType.DateTime);
                MySqlParameter p_montant = new MySqlParameter("@montant", MySqlDbType.Decimal);
                MySqlParameter p_frais_mensuel_id = new MySqlParameter("@frais_mensuel_id", MySqlDbType.Int32);
                MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int32);

                //les valeurs des parametres

                p_Id.Value = null;
                p_date.Value = DateTime.Now;
                p_montant.Value = nupmontantApayer.Value;
                p_frais_mensuel_id.Value = lbl_frais_mensuel_id.Text;
                p_eleve_id.Value = nupdown_id.Value;

                //assignation des valeurs

                cmd.Parameters.Add(p_Id);
                cmd.Parameters.Add(p_date);
                cmd.Parameters.Add(p_montant);
                cmd.Parameters.Add(p_frais_mensuel_id);
                cmd.Parameters.Add(p_eleve_id);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accompte enregistré avec succès !!!", "Infromation");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + "" + ex.Number);
                }
            }
        }

        #endregion enrgistrement

        #region Reçu du paiement mensuel

        /// <summary>
        /// cette méthode permet de créer les document qui contient les infos du réçu
        /// </summary>
        private void CreerRecu()
        {
            DocRecu pdf = new DocRecu(DocRecu.TypeRecu.Accompte)
            {
                Designation = txt_frais_mensuel.Text,
                IdEleve =Convert.ToInt64(nupdown_id.Value),
                Noms = $"{txt_noms.Text} ",
                Montant = nupmontantApayer.Value,
                Classe = txt_classe.Text,
                Numero = Operations.ObtenirNumeroRecuMensuel()
            };

            pdf.CreerRecu();
        }

        private string ObtenirAdresse()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select adresse from configuration limit 1";
                return cmd.ExecuteScalar().ToString();
            }
        }

        #endregion Reçu du paiement mensuel
    }
}