namespace Scool_cash_manager
{
    partial class FrmFraisMensuel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDuplicata = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 50);
            this.panel1.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(127, -3);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(885, 44);
            this.lblMessage.TabIndex = 29;
            this.lblMessage.Text = "Aucune Opération n\'a été éffectuée aujourd\'hui";
            this.lblMessage.Visible = false;
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
            this.label1.Size = new System.Drawing.Size(366, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paiement du frais mensuel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnDuplicata);
            this.panel2.Controls.Add(this.btnImprimer);
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.btnNouveau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 642);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 63);
            this.panel2.TabIndex = 23;
            // 
            // BtnDuplicata
            // 
            this.BtnDuplicata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnDuplicata.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDuplicata.FlatAppearance.BorderSize = 0;
            this.BtnDuplicata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.BtnDuplicata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDuplicata.ForeColor = System.Drawing.Color.White;
            this.BtnDuplicata.Location = new System.Drawing.Point(416, 15);
            this.BtnDuplicata.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDuplicata.MaximumSize = new System.Drawing.Size(169, 38);
            this.BtnDuplicata.Name = "BtnDuplicata";
            this.BtnDuplicata.Size = new System.Drawing.Size(128, 32);
            this.BtnDuplicata.TabIndex = 4;
            this.BtnDuplicata.Text = "Duplicata";
            this.BtnDuplicata.UseVisualStyleBackColor = false;
            this.BtnDuplicata.Click += new System.EventHandler(this.BtnDuplicata_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.Black;
            this.btnImprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimer.FlatAppearance.BorderSize = 0;
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Location = new System.Drawing.Point(280, 15);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimer.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(128, 32);
            this.btnImprimer.TabIndex = 3;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(144, 15);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetails.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(128, 32);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(8, 15);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(4);
            this.btnNouveau.MaximumSize = new System.Drawing.Size(169, 38);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(128, 32);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
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
            this.dgvliste.Location = new System.Drawing.Point(0, 50);
            this.dgvliste.Margin = new System.Windows.Forms.Padding(4);
            this.dgvliste.MultiSelect = false;
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.ReadOnly = true;
            this.dgvliste.RowHeadersWidth = 51;
            this.dgvliste.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvliste.RowTemplate.Height = 45;
            this.dgvliste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvliste.Size = new System.Drawing.Size(1092, 592);
            this.dgvliste.TabIndex = 28;
            // 
            // FrmFraisMensuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 705);
            this.Controls.Add(this.dgvliste);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFraisMensuel";
            this.Text = "frmFraisMensuel";
            this.Load += new System.EventHandler(this.FrmFraisMensuel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.DataGridView dgvliste;
        private System.Windows.Forms.Button BtnDuplicata;
    }
}