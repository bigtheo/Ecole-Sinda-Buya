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
    public partial class frmNouveauPaiementExamen : Form
    {
        public frmNouveauPaiementExamen()
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

        private void PanelBarreDeTitre_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    cmd.CommandText = "ObtenirDesignationFraisExamen";
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_eleve_id = new MySqlParameter("@p_eleve_id", MySqlDbType.Int64);
                    MySqlParameter p_frais_id = new MySqlParameter("@p_frais_id", MySqlDbType.Int32);
                    MySqlParameter p_frais_mensuel = new MySqlParameter("@p_frais_mensuel", MySqlDbType.VarChar, 25);

                    p_eleve_id.Direction = ParameterDirection.Input;
                    p_frais_id.Direction = ParameterDirection.Output;
                    p_frais_mensuel.Direction = ParameterDirection.Output;

                    p_eleve_id.Value = nupdown_id.Value;

                    //ajout des parametres à la commande
                    cmd.Parameters.Add(p_eleve_id);
                    cmd.Parameters.Add(p_frais_id);
                    cmd.Parameters.Add(p_frais_mensuel);

                    //exécution de la requette
                    cmd.ExecuteNonQuery();
                    //gets values from parameters
                    txt_frais_mensuel.Text = p_frais_mensuel.Value.ToString();
                    lbl_designation.Text = p_frais_mensuel.Value.ToString();
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
                    cmd.CommandText = "ObtenirMontantFraisExamen";
                    cmd.CommandType = CommandType.StoredProcedure;

                    //les paramètres...

                    MySqlParameter p_classe = new MySqlParameter("@p_classe", MySqlDbType.VarChar, 15);
                    MySqlParameter p_frais_examen = new MySqlParameter("@p_frais_examen", MySqlDbType.VarChar, 25);
                    MySqlParameter p_montant = new MySqlParameter("@p_montant", MySqlDbType.Double);
                    p_classe.Direction = ParameterDirection.Input;
                    p_frais_examen.Direction = ParameterDirection.Input;
                    p_montant.Direction = ParameterDirection.Output;

                    //ajout des valeurs
                    p_classe.Value = txt_classe.Text;
                    p_frais_examen.Value = txt_frais_mensuel.Text;

                    cmd.Parameters.Add(p_classe);
                    cmd.Parameters.Add(p_frais_examen);
                    cmd.Parameters.Add(p_montant);
                    //exécution de la commande ....
                    cmd.ExecuteNonQuery();
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
                cmd.CommandText = "AfficherPaiementExamenParID";
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
                        dgvliste.Visible=false;
                        this.Size = new System.Drawing.Size(416, 250);
                    }
                    else
                    {
                        dgvliste.Visible=true;
                        this.Size = new System.Drawing.Size(416, 418);
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
        }

        #endregion recherche des des infos de élève

        #region enregistrement du frais mensuel

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ChampsOK())
            {
                SavePaiementMensuel();
            }
            else
            {
                MessageBox.Show("Enregistrement Impossible", "Information", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }

        /// <summary>
        /// Cette méthôde permet de d'enregistrer le frais d'examen
        /// </summary>
        private void SavePaiementMensuel()
        {
            using (MySqlCommand cmd=new MySqlCommand ())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "INSERT INTO PAIEMENT_EXAMEN(id,date_paie,eleve_id,frais_examen_id,user_id) VALUES(@id,@date_paie,@eleve_id,@frais_examen_id,@user_id)";
                cmd.CommandType = CommandType.Text;

                MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int32);
                MySqlParameter p_date_paie = new MySqlParameter("@date_paie", MySqlDbType.DateTime);
                MySqlParameter p_frais_examen_id = new MySqlParameter("@frais_examen_id", MySqlDbType.Int32);
                MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int32);
                MySqlParameter p_user_id = new MySqlParameter("@user_id", MySqlDbType.Int32);

                //les valeurs des parametres
                p_id.Value = 0;
                p_date_paie.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                p_frais_examen_id.Value = lbl_frais_mensuel_id.Text;
                p_eleve_id.Value = nupdown_id.Value;
                p_user_id.Value = 1; //appel de la méthôde plutard

                //ajout des parametres à la commande 
                cmd.Parameters.Add(p_id);
                cmd.Parameters.Add(p_date_paie);
                cmd.Parameters.Add(p_frais_examen_id);
                cmd.Parameters.Add(p_eleve_id);
                cmd.Parameters.Add(p_user_id);


                try
                {
                    //exécution de la requette ...
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Enregistrement éffectué avec succès !!!");
                        CreerRecu();
                    }


                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        /// <summary>
        /// Cette méthôde verifie si les champs de saisie sont remplit avec des infos correspondantes
        /// </summary>
        /// <returns></returns>
        private bool ChampsOK()
        {
            return !txt_classe.Text.Equals(String.Empty) && !txt_frais_mensuel.Text.Equals(String.Empty) && !txt_noms.Text.Equals(String.Empty) && !nupdown_id.Value.Equals(0) && !nupdown_montant.Value.Equals(0);
        }

        #endregion enregistrement du frais mensuel

        #region Reçu du paiement mensuel

       

        /// <summary>
        /// cette méthode permet de créer les document qui contient les infos du réçu
        /// </summary>
        private void CreerRecu()
        {
            DocRecu pdf = new DocRecu(DocRecu.TypeRecu.Examen)
            {
                Designation = txt_frais_mensuel.Text,
                Noms = $"{txt_noms.Text}  ",
                IdEleve=long.Parse(nupdown_id.Value.ToString()),
                Montant = nupdown_montant.Value,
                Classe = txt_classe.Text
            };

            pdf.CreerRecu();
        }

        #endregion Reçu du paiement mensuel
    }
}