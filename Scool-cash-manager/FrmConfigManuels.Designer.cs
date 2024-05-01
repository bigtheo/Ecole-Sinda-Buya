namespace Scool_cash_manager
{
    partial class FrmConfigManuels
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxFrais = new System.Windows.Forms.ComboBox();
            this.nupdownMontant = new System.Windows.Forms.NumericUpDown();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.nup_montant = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownMontant)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_montant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 46);
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
            this.label1.Size = new System.Drawing.Size(486, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuration des prix des manuels";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 508);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dgvliste);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Les Frais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAnnuler);
            this.panel3.Controls.Add(this.btnImprimer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 400);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 63);
            this.panel3.TabIndex = 24;
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.Black;
            this.btnImprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimer.FlatAppearance.BorderSize = 0;
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Location = new System.Drawing.Point(7, 18);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimer.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(128, 38);
            this.btnImprimer.TabIndex = 3;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // dgvliste
            // 
            this.dgvliste.AllowUserToAddRows = false;
            this.dgvliste.AllowUserToDeleteRows = false;
            this.dgvliste.AllowUserToOrderColumns = true;
            this.dgvliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvliste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvliste.BackgroundColor = System.Drawing.Color.White;
            this.dgvliste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvliste.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvliste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvliste.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvliste.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvliste.EnableHeadersVisualStyles = false;
            this.dgvliste.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvliste.Location = new System.Drawing.Point(4, 4);
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
            this.dgvliste.Size = new System.Drawing.Size(1048, 389);
            this.dgvliste.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1059, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ajouter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CbxFrais);
            this.panel2.Controls.Add(this.nupdownMontant);
            this.panel2.Controls.Add(this.btnEnregistrer);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 459);
            this.panel2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 45);
            this.label5.TabIndex = 32;
            this.label5.Text = "Enregistrement des frais";
            // 
            // CbxFrais
            // 
            this.CbxFrais.FormattingEnabled = true;
            this.CbxFrais.Location = new System.Drawing.Point(304, 142);
            this.CbxFrais.Name = "CbxFrais";
            this.CbxFrais.Size = new System.Drawing.Size(263, 36);
            this.CbxFrais.TabIndex = 31;
            // 
            // nupdownMontant
            // 
            this.nupdownMontant.DecimalPlaces = 2;
            this.nupdownMontant.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupdownMontant.Location = new System.Drawing.Point(304, 213);
            this.nupdownMontant.Margin = new System.Windows.Forms.Padding(4);
            this.nupdownMontant.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nupdownMontant.Name = "nupdownMontant";
            this.nupdownMontant.Size = new System.Drawing.Size(263, 34);
            this.nupdownMontant.TabIndex = 30;
            this.nupdownMontant.ThousandsSeparator = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(319, 300);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(169, 38);
            this.btnEnregistrer.TabIndex = 25;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Frais";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nup_montant);
            this.tabPage3.Controls.Add(this.BtnUpdate);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txt_code);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_designation);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1059, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modification";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(495, 238);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(117, 39);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.Text = "Enregistrer";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Code";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(332, 116);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(280, 34);
            this.txt_code.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Montant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Desgnation";
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(332, 153);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(280, 34);
            this.txt_designation.TabIndex = 7;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.BtnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnnuler.FlatAppearance.BorderSize = 0;
            this.BtnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnuler.ForeColor = System.Drawing.Color.White;
            this.BtnAnnuler.Location = new System.Drawing.Point(143, 18);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnuler.MaximumSize = new System.Drawing.Size(169, 38);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(128, 38);
            this.BtnAnnuler.TabIndex = 5;
            this.BtnAnnuler.Text = "Supprimer";
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // nup_montant
            // 
            this.nup_montant.BeforeTouchSize = new System.Drawing.Size(280, 34);
            this.nup_montant.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nup_montant.Location = new System.Drawing.Point(332, 198);
            this.nup_montant.Name = "nup_montant";
            this.nup_montant.Size = new System.Drawing.Size(280, 34);
            this.nup_montant.TabIndex = 15;
            this.nup_montant.Text = "0,00 FC";
            this.nup_montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmConfigManuels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfigManuels";
            this.Text = "frmManuels";
            this.Load += new System.EventHandler(this.FrmConfigManuels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownMontant)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_montant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvliste;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupdownMontant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxFrais;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.Button BtnAnnuler;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox nup_montant;
    }
}