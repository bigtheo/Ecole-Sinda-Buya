namespace Scool_cash_manager
{
    partial class FrmNouveauDeroge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNouveauDeroge));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_matricule = new System.Windows.Forms.TextBox();
            this.Txt_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nup_jour = new System.Windows.Forms.NumericUpDown();
            this.BtnEnregistrer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_jour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 68);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nouvelle dérogation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Noms";
            // 
            // Txt_matricule
            // 
            this.Txt_matricule.Location = new System.Drawing.Point(179, 96);
            this.Txt_matricule.Name = "Txt_matricule";
            this.Txt_matricule.Size = new System.Drawing.Size(227, 27);
            this.Txt_matricule.TabIndex = 4;
            this.Txt_matricule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_matricule_KeyDown);
            // 
            // Txt_nom
            // 
            this.Txt_nom.Location = new System.Drawing.Point(179, 138);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(227, 27);
            this.Txt_nom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jour de paiement";
            // 
            // nup_jour
            // 
            this.nup_jour.Location = new System.Drawing.Point(179, 176);
            this.nup_jour.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nup_jour.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nup_jour.Name = "nup_jour";
            this.nup_jour.Size = new System.Drawing.Size(227, 27);
            this.nup_jour.TabIndex = 9;
            this.nup_jour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nup_jour.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Location = new System.Drawing.Point(179, 221);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(227, 29);
            this.BtnEnregistrer.TabIndex = 10;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.UseVisualStyleBackColor = true;
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // FrmNouveauDeroge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 299);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.nup_jour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Txt_matricule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNouveauDeroge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle dérogation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_jour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_matricule;
        private System.Windows.Forms.TextBox Txt_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nup_jour;
        private System.Windows.Forms.Button BtnEnregistrer;
    }
}