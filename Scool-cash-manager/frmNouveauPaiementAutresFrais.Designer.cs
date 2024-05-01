namespace Scool_cash_manager
{
    partial class frmNouveauPaiementAutresFrais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouveauPaiementAutresFrais));
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_total_deja_paye = new System.Windows.Forms.TextBox();
            this.Ck_Accompte = new System.Windows.Forms.CheckBox();
            this.txt_montant_accompte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFrais = new System.Windows.Forms.ComboBox();
            this.txt_montant = new System.Windows.Forms.TextBox();
            this.nupdown_id = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_classe = new System.Windows.Forms.TextBox();
            this.txt_noms = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBarreDeTitre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_id)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarreDeTitre
            // 
            this.panelBarreDeTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.panelBarreDeTitre.Controls.Add(this.btnFermer);
            this.panelBarreDeTitre.Controls.Add(this.label1);
            this.panelBarreDeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarreDeTitre.Location = new System.Drawing.Point(0, 0);
            this.panelBarreDeTitre.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarreDeTitre.Name = "panelBarreDeTitre";
            this.panelBarreDeTitre.Size = new System.Drawing.Size(1479, 55);
            this.panelBarreDeTitre.TabIndex = 8;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(1426, 15);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(37, 33);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "x";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paiement autres frais";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.layout_panel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1479, 696);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.panel4.Controls.Add(this.BtnRechercher);
            this.panel4.Controls.Add(this.txt_nom);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(762, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 171);
            this.panel4.TabIndex = 62;
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.BtnRechercher.FlatAppearance.BorderSize = 0;
            this.BtnRechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRechercher.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.Color.White;
            this.BtnRechercher.Location = new System.Drawing.Point(547, 117);
            this.BtnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(56, 33);
            this.BtnRechercher.TabIndex = 2;
            this.BtnRechercher.Text = "Ok";
            this.BtnRechercher.UseVisualStyleBackColor = false;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(22, 117);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(516, 32);
            this.txt_nom.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(15, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(484, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Saisissez le nom, postnom ou prénom pour rechercher";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_total_deja_paye);
            this.panel1.Controls.Add(this.Ck_Accompte);
            this.panel1.Controls.Add(this.txt_montant_accompte);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxFrais);
            this.panel1.Controls.Add(this.txt_montant);
            this.panel1.Controls.Add(this.nupdown_id);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_classe);
            this.panel1.Controls.Add(this.txt_noms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 604);
            this.panel1.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 60;
            this.label5.Text = "Total déjà payé";
            // 
            // Txt_total_deja_paye
            // 
            this.Txt_total_deja_paye.Enabled = false;
            this.Txt_total_deja_paye.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total_deja_paye.Location = new System.Drawing.Point(529, 354);
            this.Txt_total_deja_paye.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_total_deja_paye.Name = "Txt_total_deja_paye";
            this.Txt_total_deja_paye.Size = new System.Drawing.Size(153, 36);
            this.Txt_total_deja_paye.TabIndex = 59;
            this.Txt_total_deja_paye.Text = "0";
            this.Txt_total_deja_paye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ck_Accompte
            // 
            this.Ck_Accompte.AutoSize = true;
            this.Ck_Accompte.Location = new System.Drawing.Point(377, 419);
            this.Ck_Accompte.Name = "Ck_Accompte";
            this.Ck_Accompte.Size = new System.Drawing.Size(123, 25);
            this.Ck_Accompte.TabIndex = 58;
            this.Ck_Accompte.Text = "Accompte";
            this.Ck_Accompte.UseVisualStyleBackColor = true;
            this.Ck_Accompte.CheckedChanged += new System.EventHandler(this.Ck_Accompte_CheckedChanged);
            // 
            // txt_montant_accompte
            // 
            this.txt_montant_accompte.Enabled = false;
            this.txt_montant_accompte.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montant_accompte.Location = new System.Drawing.Point(529, 408);
            this.txt_montant_accompte.Margin = new System.Windows.Forms.Padding(4);
            this.txt_montant_accompte.Name = "txt_montant_accompte";
            this.txt_montant_accompte.Size = new System.Drawing.Size(153, 36);
            this.txt_montant_accompte.TabIndex = 57;
            this.txt_montant_accompte.Text = "0";
            this.txt_montant_accompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_montant_accompte.TextChanged += new System.EventHandler(this.Txt_montant_accompte_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Selectionnez le frais";
            // 
            // cbxFrais
            // 
            this.cbxFrais.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFrais.FormattingEnabled = true;
            this.cbxFrais.Location = new System.Drawing.Point(201, 309);
            this.cbxFrais.Name = "cbxFrais";
            this.cbxFrais.Size = new System.Drawing.Size(299, 35);
            this.cbxFrais.TabIndex = 55;
            this.cbxFrais.SelectedIndexChanged += new System.EventHandler(this.CbxFrais_SelectedIndexChanged);
            // 
            // txt_montant
            // 
            this.txt_montant.Enabled = false;
            this.txt_montant.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montant.Location = new System.Drawing.Point(529, 309);
            this.txt_montant.Margin = new System.Windows.Forms.Padding(4);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.Size = new System.Drawing.Size(153, 36);
            this.txt_montant.TabIndex = 54;
            this.txt_montant.Text = "0";
            this.txt_montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nupdown_id
            // 
            this.nupdown_id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdown_id.Location = new System.Drawing.Point(201, 179);
            this.nupdown_id.Margin = new System.Windows.Forms.Padding(4);
            this.nupdown_id.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nupdown_id.Name = "nupdown_id";
            this.nupdown_id.Size = new System.Drawing.Size(483, 36);
            this.nupdown_id.TabIndex = 46;
            this.nupdown_id.ValueChanged += new System.EventHandler(this.Nupdown_id_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 185);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 21);
            this.label15.TabIndex = 45;
            this.label15.Text = "Id élève";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Noms";
            // 
            // txt_classe
            // 
            this.txt_classe.Enabled = false;
            this.txt_classe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_classe.Location = new System.Drawing.Point(201, 270);
            this.txt_classe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(481, 32);
            this.txt_classe.TabIndex = 40;
            this.txt_classe.Text = "0";
            // 
            // txt_noms
            // 
            this.txt_noms.Enabled = false;
            this.txt_noms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noms.Location = new System.Drawing.Point(201, 224);
            this.txt_noms.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms.Name = "txt_noms";
            this.txt_noms.Size = new System.Drawing.Size(481, 32);
            this.txt_noms.TabIndex = 39;
            this.txt_noms.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnEnregistrer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 604);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1479, 92);
            this.panel3.TabIndex = 26;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(300, 20);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(195, 53);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregsitrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // layout_panel
            // 
            this.layout_panel.AutoScroll = true;
            this.layout_panel.BackColor = System.Drawing.Color.White;
            this.layout_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_panel.Location = new System.Drawing.Point(762, 171);
            this.layout_panel.Margin = new System.Windows.Forms.Padding(4);
            this.layout_panel.Name = "layout_panel";
            this.layout_panel.Size = new System.Drawing.Size(717, 433);
            this.layout_panel.TabIndex = 63;
            // 
            // frmNouveauPaiementAutresFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 696);
            this.Controls.Add(this.panelBarreDeTitre);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNouveauPaiementAutresFrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNouveauPaiementManuels";
            this.Load += new System.EventHandler(this.FrmNouveauPaiementManuels_Load);
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_id)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.NumericUpDown nupdown_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_classe;
        private System.Windows.Forms.TextBox txt_noms;
        private System.Windows.Forms.TextBox txt_montant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFrais;
        private System.Windows.Forms.CheckBox Ck_Accompte;
        private System.Windows.Forms.TextBox txt_montant_accompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_total_deja_paye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel layout_panel;
    }
}