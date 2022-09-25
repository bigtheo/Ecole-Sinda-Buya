﻿using System;
using System.Windows.Forms;

namespace Scool_cash_manager
{
    public partial class frmManuel : Form
    {
        public frmManuel()
        {
            InitializeComponent();
        }

        private void FrmManuel_Load(object sender, EventArgs e)
        {
            Views.AfficherTout("v_autres_paiements_journalier", dgvliste);
            if (dgvliste.Rows.Count == 0)
            {
                dgvliste.Hide();
                lblMessage.Show();
            }
        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            new frmNouveauPaiementAutresFrais().ShowDialog();
        }
    }
}