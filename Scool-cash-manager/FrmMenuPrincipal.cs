using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class FrmMenuPrincipal : Form
    {
        private static MySqlConnection connection;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            CustomizerDesign();
            OuvrirFormulaire(new FrmTableauDeBord());

            cbx_databases.DataSource = DatabaseList();
            cbx_databases.Text = frmLogin.DatabaseName;
            lbl_selectedDB.Text = cbx_databases.Text;
        }

        #region slide menu et sous menu

        private void CustomizerDesign()
        {
            panelSousMenuPaiement.Visible = false;
            panelSousMenuConfigurationFrais.Visible = false;
            panelSousMenuJournal.Visible = false;
            panelSousMenuSolvabilite.Visible = false;
            //...
        }

        private void CacherSousMenu()
        {
            if (panelSousMenuConfigurationFrais.Visible == true)
                panelSousMenuConfigurationFrais.Hide();
            if (panelSousMenuPaiement.Visible == true)
                panelSousMenuPaiement.Hide();
            if (panelSousMenuSolvabilite.Visible == true)
                panelSousMenuSolvabilite.Hide();
            if (panelSousMenuJournal.Visible == true)
                panelSousMenuJournal.Hide();
        }

        private void AfficherSousMenu(Panel panelSousMenu)
        {
            if (panelSousMenu.Visible == false)
            {
                CacherSousMenu();
                panelSousMenu.Visible = true;
            }
            else
                panelSousMenu.Hide();
        }


        private Form activeForm = null;

        private void OuvrirFormulaire(Form formulaireEnfant)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formulaireEnfant;
            formulaireEnfant.TopLevel = false;
            formulaireEnfant.FormBorderStyle = FormBorderStyle.None;
            formulaireEnfant.Dock = DockStyle.Fill;
            panelConteneur.Controls.Add(formulaireEnfant);
            panelConteneur.Tag = formulaireEnfant;
            formulaireEnfant.BringToFront();
            formulaireEnfant.Show();

        }

       

        private void BtnMenuPaiement_Click(object sender, EventArgs e)
        {
            AfficherSousMenu(panelSousMenuPaiement);
        }

        private void BtnConfiguirationFrais_Click(object sender, EventArgs e)
        {
            AfficherSousMenu(panelSousMenuConfigurationFrais);
        }

        private void BtnSolvabilite_Click(object sender, EventArgs e)
        {
            AfficherSousMenu(panelSousMenuSolvabilite);
        }

        private void BtnJournal_Click(object sender, EventArgs e)
        {
            AfficherSousMenu(panelSousMenuJournal);
        }

        #endregion slide menu et sous menu

        private void BtnPaiemlentInscription_Click(object sender, EventArgs e)
        {
            if (cbx_databases.Text.Contains("2022"))
            {
                MessageBox.Show("Vous ne pouvez pas incrire l'année passée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
            else
            {
                OuvrirFormulaire(new FrmInscription());
                CacherSousMenu();
            }
            
        }

        private void BtnFraisPaiementMensuel_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmFraisMensuel());
            CacherSousMenu();
        }

        private void BtnPaiementExamens_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmFraisExamen());
            CacherSousMenu();
        }

        private void BtnPaiementExetat_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmExetat());
            CacherSousMenu();
        }

        private void BtnPaiementFraisEtat_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmFraisEtat());
            CacherSousMenu();
        }

        private void BtnAchatManuel_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmAutresPaiements());
            CacherSousMenu();
        }

        private void BtnConfigMensuel_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmConfigFraisMensuel());
            CacherSousMenu();
        }

        private void BtnConfigExamen_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmConfigExamen());
            CacherSousMenu();
        }

        private void BtnManuels_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmConfigManuels());
            CacherSousMenu();
        }

        private void BtnConfigFraisEtat_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmConfigFraisEtat());
            CacherSousMenu();
        }

        private void BtnInsolvables_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmInsolvables());
            CacherSousMenu();
        }

        private void BtnSolvables_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmSolvables());
            CacherSousMenu();
        }

        private void BtnJournalCentralise_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmJournalCentralise());
            CacherSousMenu();
        }

        private void BtnJournalFrais_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmJournalFrais());
            CacherSousMenu();
        }

        #region configuration
        private void BtnParametre_Click(object sender, EventArgs e)
        {
            ContextMenuStrip MenuContextuel = new ContextMenuStrip();
            MenuContextuel.Items.Add("Configuration",null, Click_BtnConfiguration);
            MenuContextuel.Items.Add("Sauvegarde", null, Click_Sauvegarde);
            MenuContextuel.Show(btnParametre,50,50);


        }

        private void Click_Sauvegarde(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Operations.Backup();
            CacherSousMenu();
            this.Cursor = Cursors.Default;
        }

        private void Click_BtnConfiguration(object sender, EventArgs e)
        {
            new FrmConfigurationApplication().ShowDialog();
            CacherSousMenu();
        }
        #endregion

        private void BtnConfigClasse_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmConfigClasses());
            CacherSousMenu();
        }

        private void BtnConfigExetat_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmConfigExetat());
            CacherSousMenu();
        }

        private void BtnVuDensemble_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmVuDensemble());
            CacherSousMenu();
        }

        private void BntEcheance_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmEcheance());
            CacherSousMenu();
        }

        private void BtnAccompte_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmAccompte());
            CacherSousMenu();
        }

        private void BtnEnseignat_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmEnseignant());
            CacherSousMenu();

        }

        private void BtnAnnulations_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmAnnulations());
            CacherSousMenu();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region DashBoard
        private void LblCashManager_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmTableauDeBord());
            CacherSousMenu();
        }
        #endregion


        #region base de données information schema 
        //connexion à information_schema
        public static bool Connecter()
        {
            string serveur = System.Configuration.ConfigurationManager.AppSettings["serverName"];
            string pwd = System.Configuration.ConfigurationManager.AppSettings["password"];
            string uid = System.Configuration.ConfigurationManager.AppSettings["userName"];
            string constring = "persistsecurityinfo=True; server=" + serveur + "; database=information_schema;uid=" + uid + ";password=" + pwd + "";
            connection = new MySqlConnection(constring);
            connection.Open();
            try
            {
                return true;
            }
            catch (MySqlException ex)
            {
                int number = ex.Number;
                if (number == 1042)
                    System.Windows.Forms.MessageBox.Show("Erreur de connexion au serveur des données !\nVeuillez demarrer le serveur avant de lancer la connexion\nLe code d'erreur : " + number, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    System.Windows.Forms.MessageBox.Show(ex.Message + "\nLe code d'erreur : " + number, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<string> DatabaseList()
        {
            Connecter();
            string sql = "select SCHEMA_NAME from SCHEMATA where schema_name like 'school_cash%'";
            List<string> databases = new List<string>();
            try
            {
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        databases.Add(dataReader.GetString(0));
                    }
                }
                return databases;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return default;
            }
        }
        #endregion

        #region Lors de change de la base de données
        private void cbx_databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmLogin.DatabaseName = cbx_databases.Text;
            Connexion.Connecter();
            OuvrirFormulaire(new FrmTableauDeBord());
            lbl_selectedDB.Text = cbx_databases.Text;
        }
        #endregion
    }
}