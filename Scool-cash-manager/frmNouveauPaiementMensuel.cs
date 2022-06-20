using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class frmNouveauPaiementMensuel : Form
    {
        public frmNouveauPaiementMensuel()
        {
            InitializeComponent();
            ListerPaiementParID();
        }

        #region barre de titre

        [DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr intPtr, int lparam, int hwm, int hparam);

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion barre de titre

        #region recherche des infos des élèves pour payer les frais....

        /// <summary>
        /// Cette procedure cherche le mois que l'élève vient payer par son id
        /// </summary>
        private void OntenirMoisApayer()
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

        /// <summary>
        /// Cette procedure permet d'afficher le noms et la classe de l'élève
        /// </summary>
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

        private void ListerPaiementParID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "AfficherPaiementDunEleveParID";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = nupdown_id.Value
                };
                cmd.Parameters.Add(p_id);

                //ajout des colonne à ma liste

                using (MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    dgvliste.DataSource = table;

                    sqlDataAdapter.Dispose();
                    cmd.Dispose();
                }
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
                    nupdown_montant.Value = Convert.ToDecimal(p_montant_frais_mensuel.Value);
                    lbl_frais_mensuel_id.Text = p_montant_frais_mensuel_id.Value.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Nupdown_id_ValueChanged(object sender, EventArgs e)
        {
            TrouverNomClasseEleveParID();
            ListerPaiementParID();
            OntenirMoisApayer();
            TrouverMontantParClasseFraisMensuelID();
        }

        private bool AUnaccompteAfinir()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "select count(id) from accompte where eleve_id=@p_eleve_id and frais_mensuel_id=@frais_id";

                    //creation des parametres...
                    MySqlParameter p_frais_id = new MySqlParameter("@frais_id", MySqlDbType.Int32)
                    {
                        Value = lbl_frais_mensuel_id.Text
                    };
                    MySqlParameter p_eleve_id = new MySqlParameter("@p_eleve_id", MySqlDbType.Int32)
                    {
                        Value = nupdown_id.Value
                    };

                    //assignation des parametres
                    cmd.Parameters.Add(p_frais_id);
                    cmd.Parameters.Add(p_eleve_id);

                    //exécution de la commande
                    if (int.TryParse(cmd.ExecuteScalar().ToString(), out int valeur))
                    {
                        return valeur > 0;
                    }
                    return false;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        #endregion recherche des infos des élèves pour payer les frais....

        #region enregistrement du frais mensuel

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!EnfantAcharge())
            {
                if (!AUnaccompteAfinir())
                {
                    SavePaiementMensuel();
                }
                else
                {
                    MessageBox.Show("Cet(te) élève a déjà payé un accompte pour ce  mois,\nCliquez sur ok aller à page des accomptes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    new FrmNouvelAccompte().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Cet élève est un enfant à charge !!!", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EnfantAcharge()
        {
            decimal valeur = 0;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select count(eleve_id) as nombre from associer where eleve_id= @id";
                MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int64)
                {
                    Value = nupdown_id.Value
                };
                cmd.Parameters.Add(p_id);
                valeur = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return valeur > 0;
        }

        /// <summary>
        /// Cette procedure peremt d'enregistrer le paiement mensuel
        /// </summary>
        private void SavePaiementMensuel()
        {
            if (ChampsOk())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "Insert Into paiement_mensuel(id,date_paie,eleve_id,frais_mensuel_id,user_id) VALUES(@id,@date_paie,@eleve_id,@frais_mensuel_id,@user_id)";
                    cmd.CommandType = CommandType.Text;

                    //les parametres
                    MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int32);
                    MySqlParameter p_date_paie = new MySqlParameter("@date_paie", MySqlDbType.DateTime);
                    MySqlParameter p_frais_mensuel_id = new MySqlParameter("@frais_mensuel_id", MySqlDbType.Int32);
                    MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int32);
                    MySqlParameter p_user_id = new MySqlParameter("@user_id", MySqlDbType.Int32);

                    //les valeurs des parametres
                    p_id.Value = null;
                    p_date_paie.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    p_frais_mensuel_id.Value = lbl_frais_mensuel_id.Text;
                    p_eleve_id.Value = nupdown_id.Value;
                    p_user_id.Value = 1; //obtenir l'id d'utilisateur

                    cmd.Parameters.Add(p_id);
                    cmd.Parameters.Add(p_date_paie);
                    cmd.Parameters.Add(p_frais_mensuel_id);
                    cmd.Parameters.Add(p_eleve_id);
                    cmd.Parameters.Add(p_user_id);

                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Paiement enregistré avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CreerRecu();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1452)
                            MessageBox.Show("Le mois de  " + txt_frais_mensuel.Text + " n'est pas configuré pour cette classe !!" + ex.Number);
                        else
                            if (ex.Number == 1062)
                            MessageBox.Show("Cet élève a déjà payé le mois de " + txt_frais_mensuel.Text);
                        else
                            MessageBox.Show(ex.Message + "\n Code d'erreur :" + ex.Number);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enregistrement impossible\nVeuillez vérifier les informations", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ChampsOk()
        {
            return !txt_classe.Text.Equals(string.Empty) && !txt_frais_mensuel.Text.Equals(String.Empty) && !txt_noms.Text.Equals(String.Empty) && !nupdown_montant.Value.Equals(0);
        }

        #endregion enregistrement du frais mensuel

        #region Reçu du paiement mensuel

       

        /// <summary>
        /// cette méthode permet de créer les document qui contient les infos du réçu
        /// </summary>
        private void CreerRecu()
        {
            DocRecu pdf = new DocRecu(DocRecu.TypeRecu.Mensuel)
            {
                Designation = txt_frais_mensuel.Text,
                Noms = $"{txt_nom.Text}  ",
                Montant = nupdown_montant.Value,
                Classe = txt_classe.Text
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

        private void Cbx_frais_mensuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!nupdown_id.Value.Equals(null) && !nupdown_id.Value.ToString().Equals("inconnu"))
            {
                TrouverMontantParClasseFraisMensuelID();
            }
        }

        private void Txt_frais_mensuel_TextChanged(object sender, EventArgs e)
        {
            TrouverMontantParClasseFraisMensuelID();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }


        #region Rechercher des informations sur les élèves

        private void PopulateItem()
        {
            try
            {
                using (MySqlCommand cmd=new MySqlCommand ())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "select concat_ws(' ',e.id,e.nom,e.postnom,e.prenom) as noms,c.nom,s.nom_section from eleve as e inner join classe c on c.id=e.classe_id inner join section as s on s.id=c.section_id where e.nom like @nom or e.postnom like @nom or e.prenom like @nom limit 50";
                    
                    cmd.Parameters.AddWithValue("@nom","%"+txt_nom.Text+"%");

                    using (MySqlDataAdapter adapter=new MySqlDataAdapter (cmd))
                    {
                        layout_panel.Controls.Clear();
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        int i = 1;
                        foreach(DataRow row in table.Rows)
                        {
                            ListeItem element = new ListeItem();
                            element.Noms = row[0].ToString();
                            element.Classe = row[1].ToString();
                            element.Section = row[2].ToString();

                            if (i % 2 == 0)
                                element.IconBackground = Color.FromArgb(45, 137, 239);
                            else
                                element.IconBackground = Color.FromArgb(192, 0, 192);

                            layout_panel.Controls.Add(element);

                            i++;
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            PopulateItem();
        }

        private void NextEnter(Keys key)
        {
            if (key == Keys.Enter)
            {
                PopulateItem();
            }
        }

        private void txt_nom_KeyDown(object sender, KeyEventArgs e)
        {
            NextEnter(e.KeyCode);
        }
    }
}