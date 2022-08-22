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
using Font = iTextSharp.text.Font;

namespace Scool_cash_manager
{
    public partial class frmNouveauEleve : Form
    {
        public frmNouveauEleve()
        {
            InitializeComponent();
        }

        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr intPtr, int hwm, int lparam, int lwp);

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

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

        #region la photo de l'élève capture et parcours...

        /// <summary>
        /// cette methode permet de parcourir le repertoire
        /// </summary>
        private void Parcour_photos()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "choisir l'image (*.jpg *.png ) |*.jpg; *.png"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxPhoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pbxPhoto.Text = openFileDialog1.FileName;
            }
        }

        //lorsqu'on clique sur la photo...
        private void PbxPhoto_Click(object sender, EventArgs e)
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add(new MenuItem("Parcourir...", BtnParcourir));
            menu.MenuItems.Add(new MenuItem("Capturer", BtnCapturer));
            menu.Show(pbxPhoto, new Point(80, 70));
        }

        //capturer à partir d'une camera WebCam
        private void BtnCapturer(object sender, EventArgs e)
        {
        }

        //parcours dans l'explorateur des fichiers
        private void BtnParcourir(object sender, EventArgs e)
        {
            Parcour_photos();
        }

        #endregion la photo de l'élève capture et parcours...

        #region enregistrement des perents del'élève...

        //le pere...
        private bool InsertedPere()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                //le père...
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "INSERT INTO PERE(id,nom,telephone) values(@id_pere,@nom_pere,@telephone_pere)";
                MySqlParameter parameter = new MySqlParameter();
                cmd.Parameters.Add("@id_pere", MySqlDbType.Int32);
                cmd.Parameters.Add("@nom_pere", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@telephone_pere", MySqlDbType.VarChar, 15);

                //les valeurs des parametres
                cmd.Parameters["@id_pere"].Value = null;
                cmd.Parameters["@nom_pere"].Value = txt_nom_pere.Text;
                cmd.Parameters["@telephone_pere"].Value = txt_telephone_pere.Text;

                try
                {
                    cmd.ExecuteNonQuery();                  
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return true;
        }

        //la mère ...
        private bool InsertedMere()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                //le père...
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "INSERT INTO MERE(id,nom,telephone) values(@id,@nom,@telephone)";
                MySqlParameter parameter = new MySqlParameter();
                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                cmd.Parameters.Add("@nom", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@telephone", MySqlDbType.VarChar, 15);

                //les valeurs des parametres
                cmd.Parameters["@id"].Value = 0;
                cmd.Parameters["@nom"].Value = txt_nom_mere.Text;
                cmd.Parameters["@telephone"].Value = txt_telephone_mere.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return true;
        }

        #endregion enregistrement des perents del'élève...

        #region enregistrement de l'élève

        private void InsertEleve()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                try
                {
                    cmd.CommandText = "INSERT INTO eleve(id,nom,postnom,prenom,genre,date_naissance,lieu_naissance,adresse,classe_id,pere_id,mere_id) values(@id,@nom,@postnom,@prenom,@genre,@date_naissance,@lieu_naissance,@adresse,@classe_id,@pere_id,@mere_id)";

                    //ajout des parametres
                    cmd.Parameters.Add("@id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@nom", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@postnom", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@prenom", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@genre", MySqlDbType.Enum);
                    cmd.Parameters.Add("@lieu_naissance", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@date_naissance", MySqlDbType.Date);
                    cmd.Parameters.Add("@adresse", MySqlDbType.Text);
                    cmd.Parameters.Add("@classe_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@pere_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@mere_id", MySqlDbType.Int32);

                    //ajout des valeurs aux parametres

                    cmd.Parameters["@id"].Value = null;
                    cmd.Parameters["@nom"].Value = txt_nom.Text;
                    cmd.Parameters["@postnom"].Value = txt_postnom.Text;
                    cmd.Parameters["@prenom"].Value = txt_prenom.Text;
                    cmd.Parameters["@genre"].Value = cbx_genre.Text;
                    cmd.Parameters["@adresse"].Value = txt_adresse.Text;
                    cmd.Parameters["@lieu_naissance"].Value = cbx_lieu_naissance.Text;
                    cmd.Parameters["@date_naissance"].Value = dtp_date_naissance.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters["@classe_id"].Value = classe_id;
                    //appel des méthôde qui récupèrent les id des parents d'élèves
                    cmd.Parameters["@pere_id"].Value = Operations.ObtenirDernierIdPere();
                    cmd.Parameters["@mere_id"].Value = Operations.ObtenirDernierIdMere();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion enregistrement de l'élève

        #region enregistrement de la Photo del'élève

        private void InsertedPhoto()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                byte[] image;
                if (pbxPhoto.Image != null)
                {


                    MemoryStream memory = new MemoryStream();
                    pbxPhoto.Image.Save(memory, pbxPhoto.Image.RawFormat);
                    image = memory.ToArray();
                }
                else
                {
                    DialogResult result = MessageBox.Show("La photo de l'élève n'est pas ajoutée,\nVoulez-vous enregistrer sans elle ? ", "Avertissement", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        image = null;
                    }
                    else
                    {
                        return; //on quitte la méthôde...
                    }
                }
                try
                {
                    int dernier_eleve_id = int.Parse(Operations.ObtenirIDdernierEleve());//récuperation du dernier id dans la table élève                   
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "INSERT INTO IMAGES_ELEVES(id,nom,image,eleve_id) values(@id,@nom,@image,@eleve_id)";
                    cmd.Parameters.Add("@id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@nom", MySqlDbType.Text);
                    cmd.Parameters.Add("@image", MySqlDbType.LongBlob);
                    cmd.Parameters.Add("@eleve_id", MySqlDbType.Int32);

                    cmd.Parameters["@id"].Value = 0;
                    cmd.Parameters["@nom"].Value = txt_nom.Text +txt_postnom.Text +txt_prenom.Text ;
                    cmd.Parameters["@image"].Value = image;
                    cmd.Parameters["@eleve_id"].Value = dernier_eleve_id;
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        #endregion enregistrement de la Photo del'élève

        #region Enregistremnt du frais d'inscription...

        /// <summary>
        /// cette procédure permet d'inserer dans la table paiement_mensuel
        /// </summary>
        private void InsertedInscription()
        {
            /*on vérifie le jour de paiement si l'élève ne paie pas le mois encours par rapport à la configuration
             Ensuite on enregistre tous le mois precédent  dans la table PAIEMENTS_MENSUEL Par une boucle allant de
            1 à n = le mois encours et le champs payé à la valeur 0 ou false
             */

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    #region la region des requete et commandes pour enregistrer l'inscription

                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "InsertDansPaiementMensuels";
                    cmd.CommandType = CommandType.StoredProcedure;
                    //ajout des parametres
                    cmd.Parameters.Add("@p_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@p_eleve_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@p_frais_mensuel_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@p_user_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@p_paye", MySqlDbType.Int16);

                    //determiner la direction des paramatres
                    cmd.Parameters["@p_id"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_eleve_id"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_frais_mensuel_id"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_user_id"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_paye"].Direction = ParameterDirection.Input;

                    //assignation des valeurs aux paramtres...
                    cmd.Parameters["@p_id"].Value = null;
                    cmd.Parameters["@p_eleve_id"].Value = Operations.ObtenirIDdernierEleve();
                    cmd.Parameters["@p_frais_mensuel_id"].Value = Operations.ObtenirFraisInscrptionID(cbx_classe.Text);
                    cmd.Parameters["@p_user_id"].Value = 1;
                    cmd.Parameters["@p_paye"].Value = 1;

                    #endregion la region des requete et commandes pour enregistrer l'inscription

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Inscription reussie !!!  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                

                  
                }
                catch (MySqlException ex) ///EN CAS D'ERREUR
                {
                    switch (ex.Number)
                    {
                        case 1062:
                            MessageBox.Show("Duplicat: élève déjà Inscrit(e)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case 1545:
                            MessageBox.Show("Référence: Vérifiez l'identifiant du frais", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            MessageBox.Show("Erreur: veuillez contacter l'administrateur ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }

        #endregion Enregistremnt du frais d'inscription...

        #region appel des méthodes d'enregiostrement...

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ChampsOk())
            {
                if(decimal.Parse(Operations.ObtenirMontantInscription(cbx_classe.Text)) > 0 && Operations.ObtenirFraisInscrptionID(cbx_classe.Text)>0)
                {
                    InsertedPere();
                    InsertedMere();
                    InsertEleve();
                    InsertedPhoto();
                    InsertedInscription();

                    CreerRecu();
                
                   }
                    else
                    {
                MessageBox.Show("Le frais d'inscription n'est pas encore configuré pour cette classe");
                }

            }
        }

        private bool ChampsOk()
        {
            if (txt_nom.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Veuillez saisir le nom", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nom.Focus();
                return false;
            }
            else
             if (txt_postnom.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Veuillez saisir le postnom", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_postnom.Focus();
                return false;
            }
            else
                if (cbx_classe.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Veuillez saisir la classe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_classe.Focus();
                return false;
            }
            else
                if (cbx_genre.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Veuillez déterminer le sexe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_genre.Focus();
                return false;
            }
            else
                if (cbx_section.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Veuillez déterminer la section", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_section.Focus();
                return false;
            }
            {
                return true;
            }
        }

        #endregion appel des méthodes d'enregiostrement...

        #region au chargement du formulaire

        private void FrmNouveauEleve_Load(object sender, EventArgs e)
        {
            //charghement des classe disponible
            Operations.ChargerClassesDansComboBox(cbx_classe);

            //autocomplete
            CustomizeAutocomplete();
        }

        #endregion au chargement du formulaire

        #region custmizer Auto_complete

        private void CustomizeAutocomplete()
        {
            this.Cursor = Cursors.WaitCursor;
            //nom
            txt_nom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_nom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            GetNomAutocomplete(DataCollection, "v_nom");
            txt_nom.AutoCompleteCustomSource = DataCollection;

            //postnom
            txt_postnom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_postnom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();
            GetNomAutocomplete(DataCollection, "v_postnom");
            txt_postnom.AutoCompleteCustomSource = DataCollection;

            //prenom
            txt_prenom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_prenom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();
            GetNomAutocomplete(DataCollection, "v_prenom");
            txt_prenom.AutoCompleteCustomSource = DataCollection;

            //nom père
            txt_nom_pere.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_nom_pere.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();
            GetNomAutocomplete(DataCollection, "v_nom_mere");
            txt_nom_pere.AutoCompleteCustomSource = DataCollection;

            //nom mère
            txt_nom_mere.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_nom_mere.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();
            GetNomAutocomplete(DataCollection, "v_nom_mere");
            txt_nom_mere.AutoCompleteCustomSource = DataCollection;

            //tel. père
            txt_telephone_pere.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_telephone_pere.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();
            GetNomAutocomplete(DataCollection, "v_telephone");
            txt_telephone_pere.AutoCompleteCustomSource = DataCollection;

            //tel. mère
            txt_telephone_mere.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_telephone_mere.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();
            GetNomAutocomplete(DataCollection, "v_telephone");
            txt_telephone_mere.AutoCompleteCustomSource = DataCollection;

            this.Cursor = Cursors.Default;
        }

        #endregion custmizer Auto_complete

        #region autoComplete

        /// <summary>
        /// cette procedure obtient le nom des élève
        /// </summary>
        private void GetNomAutocomplete(AutoCompleteStringCollection collection, string view)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                if (view == "v_nom")
                {
                    cmd.CommandText = "select nom from " + view;
                }
                else if (view == "v_postnom")
                {
                    cmd.CommandText = "select postnom from " + view;
                }
                else if (view == "v_prenom")
                {
                    cmd.CommandText = "select prenom from " + view;
                }
                else
                {
                    cmd.CommandText = "select* from " + view;
                }

                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                using (MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd))
                {
                    try
                    {
                        DataTable table = new DataTable();
                        sqlDataAdapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            collection.Add(row[0].ToString());
                        }

                        sqlDataAdapter.Dispose();
                        cmd.Dispose();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        #endregion autoComplete

        #region recherche Infos

        private void Txt_nom_TextChanged(object sender, EventArgs e)
        {
        }
    /*    private void TrouverMontantParClasseFraisMensuelID()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.connecter();
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

                    p_classe.Value = cbx_classe.Text;
                    p_frais_mensuel_id.Value = cbx_frais_mensuel.Text;

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
        }*/

        private void Cbx_section_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_classe.Text = "";
            Operations.ChargerClassesParSectionIDDansComboBox(cbx_classe, (cbx_section.SelectedIndex + 1).ToString());
            nupMontant.Value = 0;
        }

        /// <summary>
        /// cette procedure permet de trouver l'id de la classe après selection de celle ci...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cbx_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe_id = Operations.TrouverClasse_idParNomClasse(cbx_classe.Text);
            nupMontant.Value =decimal.Parse( Operations.ObtenirMontantInscription(cbx_classe.Text));
        }

        #endregion recherche Infos

        #region parocourir et nottoyer la photo dans le pictureBox

        private void BtnNettoyerPhoto_Click(object sender, EventArgs e)
        {
            pbxPhoto.Image = null;
        }

        //parcours dans la raciçne pour retrouver les photos
        private void BtnParcourir_Click(object sender, EventArgs e)
        {
            Parcour_photos();
        }

        #endregion parocourir et nottoyer la photo dans le pictureBox

        #region Reçu du paiement mensuel

        

        /// <summary>
        /// cette méthode permet de créer les document qui contient les infos du réçu
        /// </summary>
        private void CreerRecu()
        {
            DocRecu pdf = new DocRecu(DocRecu.TypeRecu.Inscription)
            {
                Designation = "Inscription",
                Noms = $"{txt_nom.Text} {txt_postnom.Text} ",
                Montant = nupMontant.Value,
                Classe = cbx_classe.Text,
                Numero = Operations.ObtenirNumeroRecuMensuel()
            };

            pdf.CreerRecu();

        }

       

        #endregion Reçu du paiement mensuel


        //les attributs de la classe (formulaires)....
        private string classe_id = "0";

        private void Txt_nom_pere_TextChanged(object sender, EventArgs e)
        {

        }
    }
}