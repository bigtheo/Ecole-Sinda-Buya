using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Scool_cash_manager
{
    public partial class FrmTableauDeBord : Form
    {
        public FrmTableauDeBord()
        {
            InitializeComponent();

            CbxMois.SelectedIndex = 0;

            timer1.Start();
            AfficherNombreEleveInscrit();
            AfficherNombreEleveInscritMaternelle();
            AfficherNombreEleveInscritPrimaire();
            AfficherNombreEleveInscritSecondaire();
            //   Operations.ChargerClassesDansComboBox(cbx_classe);

            AfficherNombreTotalRecu();
            AfficherNombreEleveEnOrdre(CbxMois.Text);
            PopulateItem();
            ChargerChart();

        }

        #region methodes qui permettent derechercher les informations à afficher

        private void AfficherNombreEleveInscrit()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "Select count(*) from eleve";
                try
                {
                    lblTotalInscrit.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AfficherNombreEleveInscritMaternelle()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select count(*) from eleve as e inner join Classe as c on c.id=e.classe_id inner join section as s on s.id=c.section_id where s.id = 1";
                try
                {
                    lblTotalMaternelle.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AfficherNombreEleveInscritPrimaire()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select count(*) from eleve as e inner join Classe as c on c.id=e.classe_id inner join section as s on s.id=c.section_id where s.id = 2";
                try
                {
                    lblTotalPrimaire.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AfficherNombreEleveInscritSecondaire()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = "select count(*) from eleve as e inner join Classe as c on c.id=e.classe_id inner join section as s on s.id=c.section_id where s.id = 3";
                try
                {
                    lblTotalSecondaire.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AfficherNombreEleveEnOrdre(string mois)
        {
            string requete;
            //si le mois vaut null ou vide ....

            requete = "select count(*) from paiement_mensuel as p INNER JOIN frais_mensuel as f ON f.id = p.frais_mensuel_id where f.designation=@mois";

            MySqlParameter p_mois = new MySqlParameter("@mois", MySqlDbType.VarChar)
            {
                Value = mois
            };

            using (MySqlCommand cmd = new MySqlCommand())
            {
                if (Connexion.con.State != System.Data.ConnectionState.Open)
                    Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = requete;
                cmd.Parameters.Add(p_mois);

                try
                {
                    lblEnOrdre.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AfficherNombreTotalRecu()
        {
            string requete;
            //si le mois vaut null ou vide ....

            requete = "select count(*) from paiement_mensuel ";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                if (Connexion.con.State != System.Data.ConnectionState.Open)
                    Connexion.Connecter();
                cmd.Connection = Connexion.con;
                cmd.CommandText = requete;

                try
                {
                    lblTotalRecu.Text = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ChargerChart()
        {
            CbxGraphique.SelectedIndex = 1;
        }

        private void PopulateItem()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Connexion.Connecter();
                    cmd.Connection = Connexion.con;
                    cmd.CommandText = "select concat_ws(' ',e.id,e.nom,e.postnom,e.prenom) as noms,c.nom,s.nom_section from eleve as e inner join classe c on c.id=e.classe_id inner join section as s on s.id=c.section_id order by e.id desc limit 20";


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        layout_panel.Controls.Clear();
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        int i = 1;
                        foreach (DataRow row in table.Rows)
                        {
                            ListeItem listItem = new ListeItem
                            {
                                Noms = row[0].ToString(),
                                Classe = row[1].ToString(),
                                Section = row[2].ToString()
                            };
                            ListeItem element = listItem;

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
        #endregion methodes qui permettent derechercher les informations à afficher

        private void CbxGraphique_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           Series series = new Series();
            switch (CbxGraphique.SelectedIndex)
            {
                case 0:
                    series.ChartType = SeriesChartType.Bar;
                    break;

                case 1:
                    series.ChartType = SeriesChartType.Pie;
                    break;

                case 2:
                    series.ChartType = SeriesChartType.StepLine;
                    break;

                case 3:
                    series.ChartType = SeriesChartType.Spline;
                    break;

                case 4:
                    series.ChartType = SeriesChartType.Area;
                    break;
            }

            series.Points.AddXY("maternelle", Convert.ToDouble(lblTotalMaternelle.Text));
            series.Points.AddXY("Primaire", Convert.ToDouble(lblTotalPrimaire.Text));
            series.Points.AddXY("Secondaire", Convert.ToDouble(lblTotalSecondaire.Text));
            chart1.Series.Clear();
            chart1.Series.Add(series);
            series.Name = "Section";
        }

        private void CbxMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherNombreEleveEnOrdre(CbxMois.Text);
            AfficherNombreTotalRecu();
        }
    }
}
