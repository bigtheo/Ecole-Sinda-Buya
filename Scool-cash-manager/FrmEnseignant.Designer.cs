namespace Scool_cash_manager
{
    partial class FrmEnseignant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnseignant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.BtnNouvelleAssociation = new System.Windows.Forms.Button();
            this.btnModifierAssociation = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_nombre_enfant = new System.Windows.Forms.Label();
            this.lbl_nombre_enseigant = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_filter = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 46);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Les élèves prises en charge";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnImprimer);
            this.panel2.Controls.Add(this.BtnNouvelleAssociation);
            this.panel2.Controls.Add(this.btnModifierAssociation);
            this.panel2.Controls.Add(this.btnNouveau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 631);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 74);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(560, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.MaximumSize = new System.Drawing.Size(169, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dérogration";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.Black;
            this.btnImprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimer.FlatAppearance.BorderSize = 0;
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Location = new System.Drawing.Point(424, 21);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimer.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(128, 32);
            this.btnImprimer.TabIndex = 7;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // BtnNouvelleAssociation
            // 
            this.BtnNouvelleAssociation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.BtnNouvelleAssociation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNouvelleAssociation.FlatAppearance.BorderSize = 0;
            this.BtnNouvelleAssociation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.BtnNouvelleAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNouvelleAssociation.ForeColor = System.Drawing.Color.White;
            this.BtnNouvelleAssociation.Location = new System.Drawing.Point(152, 21);
            this.BtnNouvelleAssociation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNouvelleAssociation.MaximumSize = new System.Drawing.Size(169, 38);
            this.BtnNouvelleAssociation.Name = "BtnNouvelleAssociation";
            this.BtnNouvelleAssociation.Size = new System.Drawing.Size(128, 32);
            this.BtnNouvelleAssociation.TabIndex = 6;
            this.BtnNouvelleAssociation.Text = "Nouvelle ass.";
            this.BtnNouvelleAssociation.UseVisualStyleBackColor = false;
            this.BtnNouvelleAssociation.Click += new System.EventHandler(this.BtnNouvelleAssociation_Click);
            // 
            // btnModifierAssociation
            // 
            this.btnModifierAssociation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnModifierAssociation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModifierAssociation.FlatAppearance.BorderSize = 0;
            this.btnModifierAssociation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnModifierAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierAssociation.ForeColor = System.Drawing.Color.White;
            this.btnModifierAssociation.Location = new System.Drawing.Point(288, 21);
            this.btnModifierAssociation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifierAssociation.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnModifierAssociation.Name = "btnModifierAssociation";
            this.btnModifierAssociation.Size = new System.Drawing.Size(128, 32);
            this.btnModifierAssociation.TabIndex = 5;
            this.btnModifierAssociation.Text = "Supprimer";
            this.btnModifierAssociation.UseVisualStyleBackColor = false;
            this.btnModifierAssociation.Click += new System.EventHandler(this.btnModifierAssociation_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(16, 21);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNouveau.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(128, 32);
            this.btnNouveau.TabIndex = 4;
            this.btnNouveau.Text = "Nouveau ens.";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbl_nombre_enfant);
            this.panel3.Controls.Add(this.lbl_nombre_enseigant);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 98);
            this.panel3.TabIndex = 25;
            // 
            // lbl_nombre_enfant
            // 
            this.lbl_nombre_enfant.AutoSize = true;
            this.lbl_nombre_enfant.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_enfant.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_enfant.Location = new System.Drawing.Point(251, 23);
            this.lbl_nombre_enfant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_enfant.Name = "lbl_nombre_enfant";
            this.lbl_nombre_enfant.Size = new System.Drawing.Size(28, 28);
            this.lbl_nombre_enfant.TabIndex = 30;
            this.lbl_nombre_enfant.Text = "11";
            // 
            // lbl_nombre_enseigant
            // 
            this.lbl_nombre_enseigant.AutoSize = true;
            this.lbl_nombre_enseigant.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_enseigant.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_enseigant.Location = new System.Drawing.Point(251, 59);
            this.lbl_nombre_enseigant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_enseigant.Name = "lbl_nombre_enseigant";
            this.lbl_nombre_enseigant.Size = new System.Drawing.Size(28, 28);
            this.lbl_nombre_enseigant.TabIndex = 29;
            this.lbl_nombre_enseigant.Text = "11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Enfant(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Responsable(s)";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.Cbx_filter);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 46);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1092, 128);
            this.panel6.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(828, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Filtre";
            // 
            // Cbx_filter
            // 
            this.Cbx_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_filter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_filter.FormattingEnabled = true;
            this.Cbx_filter.Items.AddRange(new object[] {
            "Prise en charge",
            "Dérrogation"});
            this.Cbx_filter.Location = new System.Drawing.Point(884, 52);
            this.Cbx_filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbx_filter.Name = "Cbx_filter";
            this.Cbx_filter.Size = new System.Drawing.Size(160, 29);
            this.Cbx_filter.TabIndex = 31;
            this.Cbx_filter.SelectedIndexChanged += new System.EventHandler(this.Cbx_filter_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(265, 271);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(524, 44);
            this.lblMessage.TabIndex = 32;
            this.lblMessage.Text = "Aucune Infromation trouvée";
            this.lblMessage.Visible = false;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvliste.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvliste.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvliste.EnableHeadersVisualStyles = false;
            this.dgvliste.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvliste.Location = new System.Drawing.Point(0, 174);
            this.dgvliste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvliste.MultiSelect = false;
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.ReadOnly = true;
            this.dgvliste.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvliste.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvliste.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvliste.RowTemplate.Height = 45;
            this.dgvliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvliste.Size = new System.Drawing.Size(1092, 457);
            this.dgvliste.TabIndex = 31;
            // 
            // FrmEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 705);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvliste);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEnseignant";
            this.Text = "Enseignants";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nombre_enseigant;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_nombre_enfant;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button BtnNouvelleAssociation;
        private System.Windows.Forms.Button btnModifierAssociation;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_filter;
        private System.Windows.Forms.DataGridView dgvliste;
    }
}