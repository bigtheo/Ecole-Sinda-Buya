using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class frmNouveauPaiementExetat : Form
    {
        public frmNouveauPaiementExetat()
        {
            InitializeComponent();
            ListerPaiementParID();
        }

        #region barre de titre

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBarreDeTitre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr handle, int v1, int v2, int v3);

        #endregion barre de titre

        #region recherche des des infos de élève

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

        /// <summary>
        /// cette procedure permet de trouver l'id et la designation du frais mensuel
        /// </summary>
        private void TrouverFraisExamenParID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "ObtenirInfosPaiementExetat";
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_eleve_id = new MySqlParameter("@p_eleve_id", MySqlDbType.Int64);
                    MySqlParameter p_frais_id = new MySqlParameter("@p_frais_exetat_id", MySqlDbType.Int32);
                    MySqlParameter p_deisignation_exetat = new MySqlParameter("@p_designation_frais_exetat", MySqlDbType.VarChar, 25);

                    p_eleve_id.Direction = ParameterDirection.Input;
                    p_frais_id.Direction = ParameterDirection.Output;
                    p_deisignation_exetat.Direction = ParameterDirection.Output;

                    p_eleve_id.Value = nupdown_id.Value;

                    //ajout des parametres à la commande
                    cmd.Parameters.Add(p_eleve_id);
                    cmd.Parameters.Add(p_frais_id);
                    cmd.Parameters.Add(p_deisignation_exetat);

                    //exécution de la requette
                    cmd.ExecuteNonQuery();
                    //gets values from parameters
                    txt_frais_mensuel.Text = p_deisignation_exetat.Value.ToString();
                    lbl_designation.Text = p_deisignation_exetat.Value.ToString();
                    lbl_frais_mensuel_id.Text = p_frais_id.Value.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Cette méthôde obtient le montant d'examen à payer !!
        /// </summary>
        private void ObtenirMontantExamen()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "ObtenirMontantFraisExetatParEleveID";
                    cmd.CommandType = CommandType.StoredProcedure;

                    //les paramètres...

                    MySqlParameter p_id = new MySqlParameter("@p_eleve_id", MySqlDbType.Int32);
                    MySqlParameter p_frais_id = new MySqlParameter("@p_frais_id", MySqlDbType.Int32);
                    MySqlParameter p_montant = new MySqlParameter("@p_montant", MySqlDbType.Decimal);
                    p_id.Direction = ParameterDirection.Input;
                    p_montant.Direction = ParameterDirection.Output;

                    //ajout des valeurs
                    p_id.Value = nupdown_id.Value;
                    p_frais_id.Value = lbl_frais_mensuel_id.Text;

                    cmd.Parameters.Add(p_id);
                    cmd.Parameters.Add(p_frais_id);                   
                    cmd.Parameters.Add(p_montant);
                    //exécution de la commande ....
                    cmd.ExecuteNonQuery();
                    //obtenir les montant
                    nupdown_montant.Value = Convert.ToDecimal(p_montant.Value);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Cette metôde liste les paiement du frais d'examen d'un élève
        /// </summary>
        private void ListerPaiementParID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "AfficherPaiementExetatParID";
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int64)
                {
                    Direction = ParameterDirection.Input,
                    Value = nupdown_id.Value
                };
                cmd.Parameters.Add(p_id);

                //ajout des lignes à ma liste

                using (MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    dgvliste.DataSource = table;

                    //lorque l'élève a déjà payé l'inscription seulement
                    if (dgvliste.Rows.Count == 0)
                    {
                        dgvliste.Visible = false;
                        lbl_designation.Visible = false;
                        lbl_frais_mensuel_id.Visible = false;
                        this.Size = new System.Drawing.Size(416, 250);
                    }
                    else
                    {
                        dgvliste.Visible = true;
                        lbl_designation.Visible = true;
                        lbl_frais_mensuel_id.Visible = true;
                        this.Size = new System.Drawing.Size(416, 380);
                    }
                    sqlDataAdapter.Dispose();
                    cmd.Dispose();
                }
            }
        }

        private void Nupdown_id_ValueChanged(object sender, EventArgs e)
        {
            TrouverNomClasseEleveParID();
            TrouverFraisExamenParID();
            ObtenirMontantExamen();
            ListerPaiementParID();

            //si l'élève n'est pas dans la BD
            if (txt_classe.Text == "Inconnue"|| lbl_frais_mensuel_id.Text == "3")
            {
                txt_frais_mensuel.Text = "Inconnue";
                lbl_designation.Text = "Inconnue";
            }

        }

        #endregion recherche des des infos de élève

        #region enregistrement

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ChampsOk())
            {
                using (MySqlCommand cmd=new MySqlCommand ())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "INSERT INTO Paiement_exetat(id,date_paie,eleve_id,frais_exetat_id,user_id) values(@id,@date_paie,@eleve_id,@frais_exetat_id,@user_id)";

                    //les pararametres...
                    MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int32);
                    MySqlParameter p_date_paie = new MySqlParameter("@date_paie", MySqlDbType.DateTime);
                    MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int32);
                    MySqlParameter p_frais_exetat_id = new MySqlParameter("@frais_exetat_id", MySqlDbType.Int16);
                    MySqlParameter p_user_id = new MySqlParameter("@user_id", MySqlDbType.Int32);
                    //les valeurs des parametres
                    p_id.Value = null;
                    p_date_paie.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    p_eleve_id.Value = nupdown_id.Value;
                    p_frais_exetat_id.Value = lbl_frais_mensuel_id.Text;
                    p_user_id.Value = 1; //appe de la méthode

                    //assignation des parametres à la commande
                    cmd.Parameters.Add(p_id);
                    cmd.Parameters.Add(p_date_paie);
                    cmd.Parameters.Add(p_eleve_id);
                    cmd.Parameters.Add(p_frais_exetat_id);
                    cmd.Parameters.Add(p_user_id);

                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Enregistrement éffectué avec succès !!");
                            CreerRecu();
                        }
                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
               

                }


            }else
            {
                MessageBox.Show("Enregistrement Impossible","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool ChampsOk()
        {
            return !txt_classe.Text.Equals(String.Empty) && !txt_frais_mensuel.Text.Equals(String.Empty) && !txt_noms.Text.Equals(String.Empty) && !nupdown_id.Value.Equals(0) && !nupdown_montant.Value.Equals(0) && lbl_designation.Text != "" && lbl_frais_mensuel_id.Text != "";
        }

        #endregion enregistrement

        #region Reçu du paiement EXETAT

        

        /// <summary>
        /// cette méthode permet de créer les document qui contient les infos du réçu
        /// </summary>
        private void CreerRecu()
        {
            DocRecu pdf = new DocRecu(DocRecu.TypeRecu.exEtat)
            {
                Designation = txt_frais_mensuel.Text,
                Noms = $"{txt_noms.Text}  ",
                IdEleve = long.Parse(nupdown_id.Value.ToString()),
                Montant = nupdown_montant.Value,
                Classe = txt_classe.Text
            };

            pdf.CreerRecu();
        }

        #endregion Reçu du paiement mensuel
    }
}