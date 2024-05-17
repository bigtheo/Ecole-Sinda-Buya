using MySql.Data.MySqlClient;
using Scool_cash_manager.Common;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class frmNouveauPaiementAutresFrais : Form
    {
        public int FraisId { get; set; }
        public string NumeroRecu { get; set; }

        public frmNouveauPaiementAutresFrais()
        {
            InitializeComponent();
            
            
        }

        private bool Adejapaye()
        {
            Connexion.Connecter();
            var sql = "select   count(*) Nombre from autres_paiements p inner join autres_frais f on f.id = p.frais_id inner join eleve e on e.id = p.eleve_id where e.id = @p_id and f.intitule = @p_frais ";
            using (MySqlCommand cmd=new MySqlCommand (sql,Connexion.con))
            {
                MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int32)
                {
                    Value = nupdown_id.Value
                };

                MySqlParameter p_frais = new MySqlParameter("@p_frais", MySqlDbType.VarChar)
                {
                    Value = cbxFrais.Text
                };

                cmd.Parameters.Add(p_id);
                cmd.Parameters.Add(p_frais);

                try
                {
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        #region barre de titre

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr intPtr, int lparam, int hwparam, int rparam);

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

        #region au chargement du formulaire...

        private void FrmNouveauPaiementManuels_Load(object sender, EventArgs e)
        {
            Connexion.Connecter();
            string sql = "select distinct intitule from autres_frais";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbxFrais.Items.Add(dr.GetString(0));
                }
            }
        }

        #endregion au chargement du formulaire...

        #region Recherche des infos

        //au changement de l'ide du manuel..
        private void Nupd_id_manuel_ValueChanged(object sender, EventArgs e)
        {
            GetEleveHistoriqueFraisConnexes();
            GetInfoManuels();
            
        }

        private void GetInfoManuels()
        {
        }

        private void SetMaxValueNumericUpDown(NumericUpDown numericUpDown)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    if (numericUpDown.Name != "nupd_id_manuel")
                    {
                        cmd.CommandText = "SELECT count(id) from eleve";
                        nupdown_id.Maximum = Decimal.Parse(cmd.ExecuteScalar().ToString());
                    }
                    else
                    {
                        cmd.CommandText = "SELECT count(id) from manuels";
                        numericUpDown.Maximum = Decimal.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
        }

        private void TrouverNomClasseEleveParID()
        {
            this.Cursor = Cursors.WaitCursor;
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

                this.Cursor = Cursors.Default;
            }
        }

        //au changement de l'id de l'élève
        private void Nupdown_id_ValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            TrouverNomClasseEleveParID();
          
            GetTotalDejaPaye();

            GetEleveHistoriqueFraisConnexes();
            this.Cursor = Cursors.Default;
        }

        #endregion Recherche des infos

        #region Enregistrement de l'achat du(es) manuel(s)

        private void EnregisterAcompteAutresFrais()
        {
            this.Cursor = Cursors.WaitCursor;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "INSERT INTO accomptes_autres_paiements(eleve_id,user_id,montant,frais_id) VALUES(@eleve_id,@userId,@montant,@fraisId)";

                MySqlParameter p_user_id = new MySqlParameter("@userId", MySqlDbType.Int32)
                {
                    Value = 1,
                };
                MySqlParameter p_frais = new MySqlParameter("@fraisId", MySqlDbType.Int32)
                {
                    Value = GetFraisId(cbxFrais.Text.Trim())
                };
                MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int32)
                {
                    Value = nupdown_id.Value
                };
                MySqlParameter p_montant_a_payer = new MySqlParameter("@montant", MySqlDbType.Int32)
                {
                    Value = Convert.ToDecimal(txt_montant_accompte.Text)
                };
                cmd.Parameters.Add(p_user_id);
                cmd.Parameters.Add(p_montant_a_payer);
                cmd.Parameters.Add(p_frais);
                cmd.Parameters.Add(p_eleve_id);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                        cmd.CommandText = "select last_insert_id()";
                        NumeroRecu = cmd.ExecuteScalar().ToString();
                        MessageBox.Show("Enregistrement éffectué avec succès !");
                        CreerRecu();

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


       

        Cursor = Cursors.Default;
        }


        private Int64 GetFraisId(string intituleFrais)
        {
            Connexion.Connecter();
            string sql = "select id from autres_frais where intitule=@frais";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                MySqlParameter p_frais = new MySqlParameter("@frais", MySqlDbType.VarChar)
                {
                    Value = cbxFrais.Text
                };
                cmd.Parameters.Add(p_frais);

                Int64 fraisId = 0;
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fraisId = dr.GetInt64(0);
                }

                dr.Close();

                return fraisId;

               
            };
        }

        private void EnregistrerTotalAutresFrais()
        {
            this.Cursor = Cursors.WaitCursor;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "INSERT INTO autres_paiements(eleve_id,user_id,frais_id) VALUES(@eleve_id,@userId,@fraisId)";

                MySqlParameter p_user_id = new MySqlParameter("@userId", MySqlDbType.Int32)
                {
                    Value = 1,
                };
                MySqlParameter p_frais = new MySqlParameter("@fraisId", MySqlDbType.Int64)
                {
                    Value = GetFraisId(cbxFrais.Text.Trim())
                };
                MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int32)
                {
                    Value = nupdown_id.Value
                };

                cmd.Parameters.Add(p_user_id);
                cmd.Parameters.Add(p_frais);
                cmd.Parameters.Add(p_eleve_id);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                        cmd.CommandText = "select last_insert_id()";
                        NumeroRecu = cmd.ExecuteScalar().ToString();
                        MessageBox.Show("Enregistrement éffectué avec succès !");
                        CreerRecu();

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            this.Cursor = Cursors.Default;
        }


        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (Adejapaye())
            {
                MessageBox.Show("Cet élève a déjà payé ce frais", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); ; ;
                return;
            }
            if (!Ck_Accompte.Checked)
            {
                EnregistrerTotalAutresFrais();

            }
            else
            {
                EnregisterAcompteAutresFrais();
            }
        
        }

        private void CreerRecu()
        {
            DocRecu pdf = new DocRecu(DocRecu.TypeRecu.Inscription)
            {
                Designation = cbxFrais.Text,
                Noms = txt_noms.Text,
                
                Classe = txt_classe.Text,
                Numero = NumeroRecu,
                Entete = "Paiement scolaire"
            };

            if(decimal.TryParse(txt_montant_accompte.Text,out decimal montantAccompte) && montantAccompte>0)
            {
                pdf.Montant = Convert.ToDecimal(txt_montant_accompte.Text);
            }
            else
            {
                pdf.Montant = Convert.ToDecimal(txt_montant.Text);
            }

            pdf.CreerRecu();
            
        }

        #endregion Enregistrement de l'achat du(es) manuel(s)


        private void GetEleveHistoriqueFraisConnexes()
        {

            var sql = "select p.id,p.date_paie,af.intitule,af.Montant from autres_paiements p inner join autres_Frais af on af.id = p.frais_id where eleve_id=@p_id\r\nUNION \r\nSelect '****','******************',' ***Accomptes***','******'\r\n\r\nUnion \r\nselect p.id,p.date_paie,af.intitule,sum(p.montant) from accomptes_autres_paiements p inner join autres_Frais af on af.id = p.frais_id where eleve_id=@p_id \r\nand af.id not in (select frais_id from autres_paiements where eleve_id=@p_id )group by(af.id)";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            { 
                MySqlParameter p_id = new MySqlParameter("@p_id", MySqlDbType.Int32)
                {
                    Value = nupdown_id.Value
                };
                cmd.Parameters.Add(p_id);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    try
                    {
                        da.Fill(table);
                        sfDataGrid1.DataSource = table;
                       

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            };

            

        }
        private void GetMontantApayer()
        {
            Connexion.Connecter();
            string sql = "select montant from autres_frais where intitule=@frais";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                MySqlParameter p_frais = new MySqlParameter("@frais", MySqlDbType.VarChar)
                {
                    Value = cbxFrais.Text
                };
                cmd.Parameters.Add(p_frais);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_montant.Text = dr.GetString(0);
                }
            };
        }

        private void GetTotalDejaPaye()
        {
            Connexion.Connecter();
            string sql = "SELECT IFNULL(sum(a.montant),0) Total from accomptes_autres_paiements a INNER JOIN autres_frais af on af.id = a.frais_id where a.eleve_id =@eleve_id and af.intitule=@frais";
            using (MySqlCommand cmd = new MySqlCommand(sql, Connexion.con))
            {
                MySqlParameter p_frais = new MySqlParameter("@frais", MySqlDbType.VarChar)
                {
                    Value = cbxFrais.Text
                };
                MySqlParameter p_eleve_id = new MySqlParameter("@eleve_id", MySqlDbType.Int64)
                {
                    Value = nupdown_id.Value
                };
                cmd.Parameters.Add(p_frais);
                cmd.Parameters.Add(p_eleve_id);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Txt_total_deja_paye.Text = Convert.ToString(dr.GetDecimal(0));
                }
                dr.Close();
            };
        }
        
        private void CbxFrais_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetMontantApayer();
            GetTotalDejaPaye();
        }

        private void Ck_Accompte_CheckedChanged(object sender, EventArgs e)
        {
            if(Ck_Accompte.Checked)
            {
                txt_montant_accompte.Enabled = true;
                txt_montant_accompte.Text = "0";
            }
            else
            {
                txt_montant_accompte.Enabled = false;
                txt_montant_accompte.Text = "0";
            }
        }

        private void Txt_montant_accompte_TextChanged(object sender, EventArgs e)
        {
            decimal montantAccompte = 0;
            decimal montantApayer=0;

            if(decimal.TryParse(txt_montant_accompte.Text, out montantAccompte)
               &&decimal.TryParse(txt_montant.Text,out montantApayer))
            {
                if(montantAccompte > montantApayer)
                {
                    MessageBox.Show("le montant de l'accompte ne peut-être superieur au montant à payer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_montant_accompte.Text = "0";
                }
            }
            else
            {
                txt_montant_accompte.Clear();
            }
            
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            PopulateItem();
        }

        private void PopulateItem()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "select concat_ws(' ',e.id,e.nom,e.postnom,e.prenom) as noms,c.nom,s.nom_section from eleve as e inner join classe c on c.id=e.classe_id inner join section as s on s.id=c.section_id where e.nom like @nom or e.postnom like @nom or e.prenom like @nom limit 50";

                    cmd.Parameters.AddWithValue("@nom", "%" + txt_nom.Text + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        layout_panel.Controls.Clear();
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        int i = 1;
                        foreach (DataRow row in table.Rows)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sfDataGrid1_QueryRowHeight(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowHeightEventArgs e)
        {
           
        }

        private void sfDataGrid1_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
           
        }
    }
}