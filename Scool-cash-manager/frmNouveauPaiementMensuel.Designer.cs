namespace Scool_cash_manager
{
    partial class frmNouveauPaiementMensuel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouveauPaiementMensuel));
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFormulaire = new System.Windows.Forms.Panel();
            this.txt_frais_mensuel = new System.Windows.Forms.TextBox();
            this.nupdown_montant = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nupdown_id = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_classe = new System.Windows.Forms.TextBox();
            this.txt_noms = new System.Windows.Forms.TextBox();
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.lbl_frais_mensuel_id = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.layout_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBarreDeTitre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFormulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_montant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.panel3.SuspendLayout();
            this.layout_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarreDeTitre
            // 
            this.panelBarreDeTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.panelBarreDeTitre.Controls.Add(this.BtnRechercher);
            this.panelBarreDeTitre.Controls.Add(this.txt_nom);
            this.panelBarreDeTitre.Controls.Add(this.label1);
            this.panelBarreDeTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarreDeTitre.Location = new System.Drawing.Point(576, 0);
            this.panelBarreDeTitre.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarreDeTitre.Name = "panelBarreDeTitre";
            this.panelBarreDeTitre.Size = new System.Drawing.Size(677, 102);
            this.panelBarreDeTitre.TabIndex = 4;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
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
            this.BtnRechercher.Location = new System.Drawing.Point(608, 36);
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
            this.txt_nom.Size = new System.Drawing.Size(577, 32);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nom_KeyDown);
            this.txt_nom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_nom_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez le nom, postnom ou prénom pour rechercher";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelFormulaire);
            this.panel2.Controls.Add(this.dgvliste);
            this.panel2.Controls.Add(this.lbl_designation);
            this.panel2.Controls.Add(this.lbl_frais_mensuel_id);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 618);
            this.panel2.TabIndex = 5;
            // 
            // panelFormulaire
            // 
            this.panelFormulaire.Controls.Add(this.txt_frais_mensuel);
            this.panelFormulaire.Controls.Add(this.nupdown_montant);
            this.panelFormulaire.Controls.Add(this.label5);
            this.panelFormulaire.Controls.Add(this.nupdown_id);
            this.panelFormulaire.Controls.Add(this.label15);
            this.panelFormulaire.Controls.Add(this.label4);
            this.panelFormulaire.Controls.Add(this.label3);
            this.panelFormulaire.Controls.Add(this.label2);
            this.panelFormulaire.Controls.Add(this.txt_classe);
            this.panelFormulaire.Controls.Add(this.txt_noms);
            this.panelFormulaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormulaire.Location = new System.Drawing.Point(0, 0);
            this.panelFormulaire.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormulaire.Name = "panelFormulaire";
            this.panelFormulaire.Size = new System.Drawing.Size(576, 201);
            this.panelFormulaire.TabIndex = 40;
            // 
            // txt_frais_mensuel
            // 
            this.txt_frais_mensuel.Enabled = false;
            this.txt_frais_mensuel.Location = new System.Drawing.Point(161, 128);
            this.txt_frais_mensuel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_frais_mensuel.Name = "txt_frais_mensuel";
            this.txt_frais_mensuel.Size = new System.Drawing.Size(405, 27);
            this.txt_frais_mensuel.TabIndex = 37;
            this.txt_frais_mensuel.TextChanged += new System.EventHandler(this.Txt_frais_mensuel_TextChanged);
            // 
            // nupdown_montant
            // 
            this.nupdown_montant.DecimalPlaces = 2;
            this.nupdown_montant.Enabled = false;
            this.nupdown_montant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdown_montant.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupdown_montant.Location = new System.Drawing.Point(161, 162);
            this.nupdown_montant.Margin = new System.Windows.Forms.Padding(4);
            this.nupdown_montant.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nupdown_montant.Name = "nupdown_montant";
            this.nupdown_montant.Size = new System.Drawing.Size(407, 30);
            this.nupdown_montant.TabIndex = 36;
            this.nupdown_montant.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Montant";
            // 
            // nupdown_id
            // 
            this.nupdown_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdown_id.Location = new System.Drawing.Point(161, 18);
            this.nupdown_id.Margin = new System.Windows.Forms.Padding(4);
            this.nupdown_id.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupdown_id.Name = "nupdown_id";
            this.nupdown_id.Size = new System.Drawing.Size(407, 30);
            this.nupdown_id.TabIndex = 34;
            this.nupdown_id.ValueChanged += new System.EventHandler(this.Nupdown_id_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 21);
            this.label15.TabIndex = 32;
            this.label15.Text = "Id élève";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Frais mensuel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Noms";
            // 
            // txt_classe
            // 
            this.txt_classe.Enabled = false;
            this.txt_classe.Location = new System.Drawing.Point(161, 92);
            this.txt_classe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(405, 27);
            this.txt_classe.TabIndex = 2;
            // 
            // txt_noms
            // 
            this.txt_noms.Enabled = false;
            this.txt_noms.Location = new System.Drawing.Point(161, 58);
            this.txt_noms.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms.Name = "txt_noms";
            this.txt_noms.Size = new System.Drawing.Size(405, 27);
            this.txt_noms.TabIndex = 1;
            // 
            // dgvliste
            // 
            this.dgvliste.AllowUserToAddRows = false;
            this.dgvliste.AllowUserToDeleteRows = false;
            this.dgvliste.AllowUserToOrderColumns = true;
            this.dgvliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvliste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvliste.BackgroundColor = System.Drawing.Color.White;
            this.dgvliste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvliste.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvliste.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvliste.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvliste.EnableHeadersVisualStyles = false;
            this.dgvliste.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvliste.Location = new System.Drawing.Point(23, 208);
            this.dgvliste.Margin = new System.Windows.Forms.Padding(4);
            this.dgvliste.MultiSelect = false;
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.ReadOnly = true;
            this.dgvliste.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvliste.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvliste.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvliste.RowTemplate.Height = 45;
            this.dgvliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvliste.Size = new System.Drawing.Size(545, 293);
            this.dgvliste.TabIndex = 39;
            // 
            // lbl_designation
            // 
            this.lbl_designation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.Location = new System.Drawing.Point(71, 505);
            this.lbl_designation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(231, 23);
            this.lbl_designation.TabIndex = 38;
            this.lbl_designation.Text = "est l\'Id du frais à payer";
            this.lbl_designation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_frais_mensuel_id
            // 
            this.lbl_frais_mensuel_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_frais_mensuel_id.AutoSize = true;
            this.lbl_frais_mensuel_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frais_mensuel_id.Location = new System.Drawing.Point(25, 505);
            this.lbl_frais_mensuel_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_frais_mensuel_id.Name = "lbl_frais_mensuel_id";
            this.lbl_frais_mensuel_id.Size = new System.Drawing.Size(29, 23);
            this.lbl_frais_mensuel_id.TabIndex = 37;
            this.lbl_frais_mensuel_id.Text = "Id";
            this.lbl_frais_mensuel_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.btnEnregistrer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 534);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 84);
            this.panel3.TabIndex = 26;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(236, 18);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(183, 48);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregsitrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // layout_panel
            // 
            this.layout_panel.AutoScroll = true;
            this.layout_panel.BackColor = System.Drawing.Color.White;
            this.layout_panel.Controls.Add(this.flowLayoutPanel1);
            this.layout_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_panel.Location = new System.Drawing.Point(576, 102);
            this.layout_panel.Margin = new System.Windows.Forms.Padding(4);
            this.layout_panel.Name = "layout_panel";
            this.layout_panel.Size = new System.Drawing.Size(677, 516);
            this.layout_panel.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(717, 0);
            this.flowLayoutPanel1.TabIndex = 64;
            // 
            // frmNouveauPaiementMensuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 618);
            this.Controls.Add(this.layout_panel);
            this.Controls.Add(this.panelBarreDeTitre);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNouveauPaiementMensuel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau paiement mensuel";
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFormulaire.ResumeLayout(false);
            this.panelFormulaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_montant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.panel3.ResumeLayout(false);
            this.layout_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_classe;
        private System.Windows.Forms.TextBox txt_noms;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nupdown_id;
        private System.Windows.Forms.NumericUpDown nupdown_montant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_frais_mensuel_id;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.DataGridView dgvliste;
        private System.Windows.Forms.Panel panelFormulaire;
        private System.Windows.Forms.TextBox txt_frais_mensuel;
        private System.Windows.Forms.FlowLayoutPanel layout_panel;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}