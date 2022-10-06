using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    internal class Operations
    {
        public static string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ficher_rapport.pdf");

        #region les méthôdes sur la table classe

        /// <summary>
        /// Cette méthode permet de charger les classes dans la liste combinée
        /// </summary>
        /// <param name="cbx">Liste Combinée</param>
        public static void ChargerClassesDansComboBox(ComboBox cbx)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = "select nom as classe from v_listeClasse";
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cbx.Items.Clear();
                    while (reader.Read())
                    {
                        cbx.Items.Add(reader.GetValue(0).ToString());
                    }
                    reader.Dispose();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// cette méthôde permet de charger les classes dans la liste combinée par par section id
        /// </summary>
        /// <param name="cbx"></param>
        public static void ChargerClassesParSectionIDDansComboBox(ComboBox cbx, string section_id)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandText = "select nom as Classe from classe where section_id=@section_id";
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.Parameters.Add("@section_id", MySqlDbType.Int32);
                    cmd.Parameters["@section_id"].Value = section_id;

                    MySqlDataReader reader = cmd.ExecuteReader();
                    cbx.Items.Clear();
                    while (reader.Read())
                    {
                        cbx.Items.Add(reader.GetValue(0).ToString());
                    }
                    reader.Dispose();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Cette méthôde permet de trouver l'id de la classe par le nom de la celle-ci
        /// </summary>
        /// <param name="classe">Le nom de la classe</param>
        /// <returns>l'id de la classe</returns>
        public static string TrouverClasse_idParNomClasse(string classe)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "SELECT id FROM classe where nom=@nom";
                    MySqlParameter p_nom_classe = new MySqlParameter("@nom", MySqlDbType.VarChar, 15);
                    cmd.Parameters.Add(p_nom_classe);
                    p_nom_classe.Value = classe;

                    string nom_classe = cmd.ExecuteScalar().ToString();

                    if (nom_classe != null)
                    {
                        return nom_classe;
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }
            }
        }

        /// <summary>
        /// Cette méthode permet de trouver l'id de la classe par son nom
        /// </summary>
        /// <param name="nom_classe"></param>
        /// <returns>Le nom de la classe</returns>
        public static string ObtenirClasseID(string nom_classe)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "Select id from classe where nom = @nom";

                cmd.Parameters.Add("@nom", MySqlDbType.VarChar, 15);
                cmd.Parameters["@nom"].Value = nom_classe;
                try
                {
                    if (nom_classe != String.Empty)
                        return cmd.ExecuteScalar().ToString();
                    else
                        return "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }
            }
        }

        #endregion les méthôdes sur la table classe

        #region méthôde sur la table élève...

        /// <summary>
        /// cette méthôde permet de retourné l'id du dernier élève inscrit
        /// </summary>
        /// <returns></returns>
        public static string ObtenirIDdernierEleve()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "select max(id) from eleve";

                    string eleve_id = cmd.ExecuteScalar().ToString();
                    if (eleve_id != null)
                    {
                        return eleve_id;
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }
            }
        }

        #endregion méthôde sur la table élève...

        #region méthôdes sur la table pere et mere

        /// <summary>
        /// cette méthode permet de trouver l'id du dernier père
        /// </summary>
        /// <returns></returns>
        public static string ObtenirDernierIdPere()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "SELECT MAX(id) from pere";
                    string pere_id = cmd.ExecuteScalar().ToString();

                    if (pere_id != null)
                    {
                        return pere_id;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        internal static string ObtenirTelephone()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "SELECT Telephone from configuration limit 1";
                    string telephone = cmd.ExecuteScalar().ToString();

                    if (telephone != null)
                    {
                        return telephone;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        /// <summary>
        /// cette méthode trouve l'id de la dernière dans la table;
        /// </summary>
        /// <returns>L'id de la mère </returns>
        public static string ObtenirDernierIdMere()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "SELECT MAX(id) from mere";
                    string pere_id = cmd.ExecuteScalar().ToString();

                    if (pere_id != null)
                    {
                        return pere_id;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        /// <summary>
        /// Cette méthode permet de touver l'id du père par l'id de l'élève
        /// </summary>
        /// <param name="eleve_id"></param>
        /// <returns></returns>
        public static string ObtenirIdPereParIDelve(string eleve_id)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "SELECT pere_id from eleve WHERE id=@eleve_id";
                    cmd.Parameters.Add("@eleve_id", MySqlDbType.VarChar, 15);
                    cmd.Parameters["@eleve_id"].Value = eleve_id;

                    string pere_id = cmd.ExecuteScalar().ToString();

                    if (pere_id != null)
                    {
                        return pere_id;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        /// <summary>
        /// Cette méthode permet de touver l'id de la mère par l'id de l'élève
        /// </summary>
        /// <param name="eleve_id"></param>
        /// <returns></returns>
        public static string ObtenirIdMereParIDelve(string eleve_id)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "SELECT mere_id from eleve WHERE id=@eleve_id";
                    cmd.Parameters.Add("@eleve_id", MySqlDbType.VarChar, 15);
                    cmd.Parameters["@eleve_id"].Value = eleve_id;

                    string pere_id = cmd.ExecuteScalar().ToString();

                    if (pere_id != null)
                    {
                        return pere_id;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        #endregion méthôdes sur la table pere et mere

        #region la sauvergarde de la base des données

        public static void Backup()
        {
            string nomDelaDbase = $"{new FrmMenuPrincipal().cbx_databases.Text}";
            string nom_du_fichier = DateTime.Now.Date.ToString($"backup  dd MMM yyyy HH mm") + ".sql";
            string file = DocRecu.Folder + $"\\{nomDelaDbase} " + nom_du_fichier;

            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = Connexion.con;
                    mb.ExportToFile(file);
                    MessageBox.Show("Sauvegarde éffectuée avec succès !!!", "Infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        internal static void PrintToASpecificPirnter()
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.AllowSomePages = true;
                printDialog.AllowSelection = true;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    var StartInfo = new ProcessStartInfo
                    {
                        CreateNoWindow = true,
                        UseShellExecute = true,
                        Verb = "printTo",
                        Arguments = "\"" + printDialog.PrinterSettings.PrinterName + "\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = fileName
                    };

                    Process.Start(StartInfo);
                }
            }
        }

        #endregion la sauvergarde de la base des données

        #region Méthôdes sur la table de configuration

        public static string ObtenirNomEtablissement()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select nom_entite from configuration where id=1 ";
                try
                {
                    return cmd.ExecuteScalar().ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }
            }
        }

        #endregion Méthôdes sur la table de configuration

        #region methodes sur l'inscription

        public static Int32 ObtenirFraisInscrptionID(string classe)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "SELECT coalesce(id) from frais_mensuel where classe_id in(select id from classe where nom='" + classe + "') and designation='inscription'";
                try
                {
                    if (cmd.ExecuteScalar() != null)
                    {
                        return Int32.Parse(cmd.ExecuteScalar().ToString());
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }

        internal static string ObtenirMontantInscription(string classe)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "SELECT coalesce(montant) from frais_mensuel where classe_id in(select id from classe where nom='" + classe + "') and designation='inscription'";
                try
                {
                    if (cmd.ExecuteScalar() != null)
                    {
                        return cmd.ExecuteScalar().ToString();
                    }
                    else
                    {
                        return "0";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return "0";
                }
            }
        }

        #endregion methodes sur l'inscription

        #region methodes sur l'accompte

        internal static string ObtenirNumeroRecuAccompte()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "SELECT MAX(id) from Accompte";
                try
                {
                    return cmd.ExecuteScalar().ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return "0";
                }
            }
        }

        #endregion methodes sur l'accompte

        #region méthodes de la classe recu

        public static string ObtenirAdresse()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select adresse from configuration limit 1";
                return cmd.ExecuteScalar().ToString();
            }
        }

        public static string LastInsertId()
        {
            var sql = "select last_insert_id()";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                try
                {
                    return cmd.ExecuteScalar().ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return default;
                }
            }
        }

        /// <summary>
        /// cette méthode permet de retounet le numéro ud dernier réçu....
        /// </summary>
        /// <returns></returns>
        public static string ObtenirNumeroRecuMensuel()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "PS_DernierNumeroRecuMensuel";
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_numero_recu = new MySqlParameter("@p_numero_recu", MySqlDbType.Int64)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(p_numero_recu);

                    //on exécute la requete
                    cmd.ExecuteNonQuery();
                    return p_numero_recu.Value.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "0";
            }
        }

        /// <summary>
        /// cette méthode permet de retounet le numéro ud dernier réçu....
        /// </summary>
        /// <returns></returns>
        public static string ObtenirNumeroRecuExetat()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "PS_DernierNumeroRecuExetat";
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_numero_recu = new MySqlParameter("@p_numero_recu", MySqlDbType.Int64)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(p_numero_recu);

                    //on exécute la requete
                    cmd.ExecuteNonQuery();
                    return p_numero_recu.Value.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "0";
            }
        }

        /// <summary>
        /// cette méthode permet de retounet le numéro ud dernier réçu....
        /// </summary>
        /// <returns></returns>
        public static string ObtenirNumeroRecuExamen()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "PS_DernierNumeroRecuExamen";
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_numero_recu = new MySqlParameter("@p_numero_recu", MySqlDbType.Int64)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(p_numero_recu);

                    //on exécute la requete
                    cmd.ExecuteNonQuery();
                    return p_numero_recu.Value.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "0";
            }
        }

        internal static string ObtenirNomEleveById(string text)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
               
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "select concat_ws(' ',e.nom,e.postnom,e.prenom,c.nom)  Noms from eleve e inner join classe c on c.id = e.classe_id where e.id =@id ";

                    MySqlParameter p_id = new MySqlParameter("@id", MySqlDbType.Int64)
                    {
                        Value =text
                    };
                    cmd.Parameters.Add(p_id);
                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        string noms = string.Empty;
                    while (reader.Read())
                    {
                       noms = reader.GetString(0);


                   }
                    return noms;
                }
                catch (FormatException)
                {
                    MessageBox.Show("le format de la chaine entré n'est pas vailde pour le matricule", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    return String.Empty;
                   }                   
            }
                
            }
        }
    }

    #endregion méthodes de la classe recu
