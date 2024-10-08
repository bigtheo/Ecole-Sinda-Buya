﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class FrmModifierEleve : Form
    {
        public FrmModifierEleve()
        {
            InitializeComponent();
        }

        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr intPtr, int hwm, int lparam, int lwp);

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelBarreDeTitre_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion barre de titre

        #region Mise à jour...

        //mise à jour de infos des parents..
        private bool UpdatedPere()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "UPDATE pere set nom=@nom,telephone=@telephone where id=@pere_id";

                    MySqlParameter p_nom = new MySqlParameter("@nom", MySqlDbType.VarChar, 50);
                    MySqlParameter p_telephone = new MySqlParameter("@telephone", MySqlDbType.VarChar, 15);
                    MySqlParameter p_pere_id = new MySqlParameter("@pere_id", MySqlDbType.Int32);

                    cmd.Parameters.Add(p_nom);
                    cmd.Parameters.Add(p_telephone);
                    cmd.Parameters.Add(p_pere_id);

                    p_nom.Value = txt_nom_pere.Text;
                    p_telephone.Value = txt_telephone_pere.Text;
                    p_pere_id.Value = Operations.ObtenirIdPereParIDelve(txt_id.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool UpdatedMere()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "UPDATE mere set nom=@nom,telephone=@telephone where id=@mere_id";

                    MySqlParameter p_nom = new MySqlParameter("@nom", MySqlDbType.VarChar, 50);
                    MySqlParameter p_telephone = new MySqlParameter("@telephone", MySqlDbType.VarChar, 15);
                    MySqlParameter p_mere_id = new MySqlParameter("@mere_id", MySqlDbType.Int32);

                    cmd.Parameters.Add(p_nom);
                    cmd.Parameters.Add(p_telephone);
                    cmd.Parameters.Add(p_mere_id);

                    p_nom.Value = txt_nom_mere.Text;
                    p_telephone.Value = txt_telephone_mere.Text;
                    p_mere_id.Value = Operations.ObtenirIdMereParIDelve(txt_id.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// cette méthôde modifie le la ligne de la table élève par son id
        /// </summary>
        /// <returns>true</returns>
        private bool UpdateEleve()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "UpdateEleve";
                    cmd.CommandType = CommandType.StoredProcedure;

                    //ajout des parametres...
                    cmd.Parameters.Add("@p_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@p_nom", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@p_postnom", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@p_prenom", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@p_genre", MySqlDbType.Enum);
                    cmd.Parameters.Add("@p_date_naissance", MySqlDbType.Date);
                    cmd.Parameters.Add("@p_lieu_naissance", MySqlDbType.VarChar, 45);
                    cmd.Parameters.Add("@p_adresse", MySqlDbType.Text);
                    cmd.Parameters.Add("@p_classe_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@p_pere_id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@p_mere_id", MySqlDbType.Int32);

                    //ajout des directions des parametres...
                    cmd.Parameters["@p_id"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_nom"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_postnom"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_prenom"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_genre"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_lieu_naissance"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_date_naissance"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_adresse"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_classe_id"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_pere_id"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@p_mere_id"].Direction = ParameterDirection.Input;

                    //ajout des valeurs aux parametres...
                    cmd.Parameters["@p_id"].Value = txt_id.Text.Trim();
                    cmd.Parameters["@p_nom"].Value = txt_nom.Text.Trim();
                    cmd.Parameters["@p_postnom"].Value = txt_postnom.Text.Trim();
                    cmd.Parameters["@p_prenom"].Value = txt_prenom.Text.Trim();
                    cmd.Parameters["@p_genre"].Value = cbx_genre.Text.Trim();
                    cmd.Parameters["@p_lieu_naissance"].Value = cbx_lieu_naissance.Text.Trim();
                    cmd.Parameters["@p_date_naissance"].Value = dtp_date_naissance.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters["@p_adresse"].Value = txt_adresse.Text.Trim();
                    cmd.Parameters["@p_classe_id"].Value = classe_id;
                    //appel des méthôde qui permettent de trouver les ID des parents de l'élève
                    cmd.Parameters["@p_pere_id"].Value = Operations.ObtenirIdPereParIDelve(txt_id.Text);
                    cmd.Parameters["@p_mere_id"].Value = Operations.ObtenirIdMereParIDelve(txt_id.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.Number);
                    return false;
                }
            }
        }

        #endregion Mise à jour...

        #region appel des méthôdes

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ChampsOk())
            {
                if (
                    UpdateEleve() && UpdatedPere() && 
                    UpdatedMere())
                {
                    MessageBox.Show("Information Mise à jour avec succès !!!");
                    CreerRecu();

                }
                else
                {
                    MessageBox.Show("Enregiostrement Impossible");
                }
               
            }
        }

        private bool UpdatePaiement()
        {
            using (MySqlCommand cmd=new MySqlCommand ())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = $"update paiement_mensuel set frais_mensuel_id={Operations.ObtenirFraisInscrptionID(cbx_classe.Text)} where eleve_id={txt_id.Value} limit 1";
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;

                }catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
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

        #endregion appel des méthôdes

        #region au chargement du formulaire

        //efface les valeurs du formulaire
        private void Raz()
        {
            txt_id.Value = 0;
            txt_nom.Clear();
            txt_postnom.Clear();
            txt_prenom.Clear();
            cbx_genre.Text = "";
            dtp_date_naissance.Text = "";
            cbx_lieu_naissance.Text = "";
            cbx_classe.Text = "";
            txt_nom_pere.Clear();
            txt_telephone_pere.Clear();
            txt_nom_mere.Clear();
            txt_telephone_mere.Clear();
            txt_adresse.Clear();
            cbx_section.Text = "";
            pbxPhoto.Image = null;
        }

        private void Charger_Infos(string id_eleve)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "select* from v_infos_d_un_eleve where id=@id";
                    cmd.Parameters.Add("@id", MySqlDbType.Int32);
                    cmd.Parameters["@id"].Value = id_eleve;
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    if (!String.IsNullOrEmpty(id_eleve) || !string.IsNullOrWhiteSpace(id_eleve))
                    {
                        dataAdapter.Fill(table);

                        if (table.Rows.Count == 0)
                        {
                            Raz();
                        }
                    }
                    else
                    {
                        Raz();
                    }

                    foreach (DataRow dataRow in table.Rows)
                    {
                        txt_id.Text = dataRow["id"].ToString();
                        txt_nom.Text = dataRow["nom"].ToString();
                        txt_postnom.Text = dataRow["postnom"].ToString();
                        txt_prenom.Text = dataRow["prenom"].ToString();
                        cbx_genre.Text = dataRow["genre"].ToString();
                        dtp_date_naissance.Text = dataRow["date_naissance"].ToString();
                        cbx_lieu_naissance.Text = dataRow["lieu_naissance"].ToString();
                        txt_nom_pere.Text = dataRow["nom_pere"].ToString();
                        txt_telephone_pere.Text = dataRow["tel_pere"].ToString();
                        txt_nom_mere.Text = dataRow["nom_mere"].ToString();
                        txt_telephone_mere.Text = dataRow["tel_mere"].ToString();
                        txt_adresse.Text = dataRow["adresse"].ToString();
                        cbx_section.Text = dataRow["nom_section"].ToString();
                        cbx_classe.Text = dataRow["classe"].ToString();
                    }
                    dataAdapter.Dispose();
                    cmd.Dispose();
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ObtenirPhoto()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select image from images_eleves where eleve_id=@eleve_id";

                MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.LongBlob)
                {
                    Value = txt_id.Value
                };

                cmd.Parameters.Add(p_eleve_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) //s'il n'y a pas de logo...
                    {
                        byte[] imgb = (byte[])reader.GetValue(0);
                        MemoryStream ms = new MemoryStream(imgb);
                        pbxPhoto.Image = System.Drawing.Image.FromStream(ms);
                    }
                    else
                    {
                        pbxPhoto.Image = null;
                    }
                }

            }
        }

        private void FrmModifierEleve_Load(object sender, EventArgs e)
        {
            Charger_Infos(FrmInscription.id_eleve);
            CustomizeAutocomplete();
            ObtenirPhoto();
        }

        #endregion au chargement du formulaire

        #region AUTO_COMPLETE

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

        #endregion AUTO_COMPLETE

        private void Txt_id_ValueChanged(object sender, EventArgs e)
        {
            Charger_Infos(txt_id.Value.ToString());
            ObtenirPhoto();
        }

        #region classes et sections

        private void Cbx_section_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_classe.Text = "";
            Operations.ChargerClassesParSectionIDDansComboBox(cbx_classe, (cbx_section.SelectedIndex + 1).ToString());
        }

        private void Cbx_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe_id = Operations.TrouverClasse_idParNomClasse(cbx_classe.Text);
        }

        private string classe_id = "0";


        #endregion classes et sections

        private void BtnParcourir_Click(object sender, EventArgs e)
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            pbxPhoto.Image = null;
        }


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
                Montant = 0,
                Classe = cbx_classe.Text
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