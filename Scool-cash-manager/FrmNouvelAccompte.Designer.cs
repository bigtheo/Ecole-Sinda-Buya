namespace Scool_cash_manager
{
    partial class FrmNouvelAccompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNouvelAccompte));
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_noms = new System.Windows.Forms.TextBox();
            this.nupMontantPaye = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupdown_id = new System.Windows.Forms.NumericUpDown();
            this.txt_frais_mensuel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.nupmontantApayer = new System.Windows.Forms.NumericUpDown();
            this.txt_classe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nup_prix = new System.Windows.Forms.NumericUpDown();
            this.lbl_frais_mensuel_id = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBarreDeTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantPaye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupmontantApayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_prix)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelBarreDeTitre.Margin = new System.Windows.Forms.Padding(5);
            this.panelBarreDeTitre.Name = "panelBarreDeTitre";
            this.panelBarreDeTitre.Size = new System.Drawing.Size(1358, 39);
            this.panelBarreDeTitre.TabIndex = 1;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // btnFermer
            // 
            this.btnFermer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(1311, 0);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(5);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(47, 39);
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
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perception accompte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id de l\'élève";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Noms";
            // 
            // txt_noms
            // 
            this.txt_noms.Enabled = false;
            this.txt_noms.Location = new System.Drawing.Point(224, 60);
            this.txt_noms.Name = "txt_noms";
            this.txt_noms.Size = new System.Drawing.Size(252, 32);
            this.txt_noms.TabIndex = 5;
            // 
            // nupMontantPaye
            // 
            this.nupMontantPaye.Enabled = false;
            this.nupMontantPaye.Location = new System.Drawing.Point(224, 196);
            this.nupMontantPaye.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nupMontantPaye.Name = "nupMontantPaye";
            this.nupMontantPaye.Size = new System.Drawing.Size(251, 32);
            this.nupMontantPaye.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Montant payé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Montant à payer";
            // 
            // nupdown_id
            // 
            this.nupdown_id.Location = new System.Drawing.Point(224, 27);
            this.nupdown_id.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupdown_id.Name = "nupdown_id";
            this.nupdown_id.Size = new System.Drawing.Size(252, 32);
            this.nupdown_id.TabIndex = 8;
            this.nupdown_id.ValueChanged += new System.EventHandler(this.NupId_ValueChanged);
            // 
            // txt_frais_mensuel
            // 
            this.txt_frais_mensuel.Enabled = false;
            this.txt_frais_mensuel.Location = new System.Drawing.Point(224, 129);
            this.txt_frais_mensuel.Name = "txt_frais_mensuel";
            this.txt_frais_mensuel.Size = new System.Drawing.Size(252, 32);
            this.txt_frais_mensuel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Frais Mensuel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prix Mensuel";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(227, 29);
            this.btnEnregistrer.MaximumSize = new System.Drawing.Size(127, 31);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(108, 31);
            this.btnEnregistrer.TabIndex = 16;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // nupmontantApayer
            // 
            this.nupmontantApayer.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupmontantApayer.Location = new System.Drawing.Point(224, 229);
            this.nupmontantApayer.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.nupmontantApayer.Name = "nupmontantApayer";
            this.nupmontantApayer.Size = new System.Drawing.Size(251, 32);
            this.nupmontantApayer.TabIndex = 17;
            // 
            // txt_classe
            // 
            this.txt_classe.Enabled = false;
            this.txt_classe.Location = new System.Drawing.Point(224, 95);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(250, 32);
            this.txt_classe.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Classe";
            // 
            // nup_prix
            // 
            this.nup_prix.Enabled = false;
            this.nup_prix.Location = new System.Drawing.Point(224, 162);
            this.nup_prix.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.nup_prix.Name = "nup_prix";
            this.nup_prix.Size = new System.Drawing.Size(251, 32);
            this.nup_prix.TabIndex = 20;
            // 
            // lbl_frais_mensuel_id
            // 
            this.lbl_frais_mensuel_id.AutoSize = true;
            this.lbl_frais_mensuel_id.Location = new System.Drawing.Point(224, 259);
            this.lbl_frais_mensuel_id.Name = "lbl_frais_mensuel_id";
            this.lbl_frais_mensuel_id.Size = new System.Drawing.Size(0, 23);
            this.lbl_frais_mensuel_id.TabIndex = 21;
            this.lbl_frais_mensuel_id.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Frais mensuel Id";
            this.label9.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnEnregistrer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 90);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbl_frais_mensuel_id);
            this.panel2.Controls.Add(this.nup_prix);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_classe);
            this.panel2.Controls.Add(this.nupmontantApayer);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_frais_mensuel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nupdown_id);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nupMontantPaye);
            this.panel2.Controls.Add(this.txt_noms);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 620);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.BtnRechercher);
            this.panel3.Controls.Add(this.txt_nom);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(572, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 102);
            this.panel3.TabIndex = 25;
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
            this.BtnRechercher.Location = new System.Drawing.Point(548, 37);
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
            this.txt_nom.Location = new System.Drawing.Point(23, 37);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(516, 32);
            this.txt_nom.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(16, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(484, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Saisissez le nom, postnom ou prénom pour rechercher";
            // 
            // layout_panel
            // 
            this.layout_panel.AutoScroll = true;
            this.layout_panel.BackColor = System.Drawing.Color.White;
            this.layout_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_panel.Location = new System.Drawing.Point(572, 141);
            this.layout_panel.Margin = new System.Windows.Forms.Padding(4);
            this.layout_panel.Name = "layout_panel";
            this.layout_panel.Size = new System.Drawing.Size(786, 518);
            this.layout_panel.TabIndex = 64;
            // 
            // FrmNouvelAccompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1358, 749);
            this.Controls.Add(this.layout_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarreDeTitre);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmNouvelAccompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmNouvelAccompte";
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontantPaye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupmontantApayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_prix)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_noms;
        private System.Windows.Forms.NumericUpDown nupMontantPaye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupdown_id;
        private System.Windows.Forms.TextBox txt_frais_mensuel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.NumericUpDown nupmontantApayer;
        private System.Windows.Forms.TextBox txt_classe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nup_prix;
        private System.Windows.Forms.Label lbl_frais_mensuel_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel layout_panel;
    }
}