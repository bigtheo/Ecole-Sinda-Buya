﻿namespace Scool_cash_manager
{
    partial class frmNouveauEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouveauEleve));
            this.panelBarreDeTitre = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.nupMontant = new System.Windows.Forms.NumericUpDown();
            this.btnNettoyerPhoto = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.dtp_date_naissance = new System.Windows.Forms.DateTimePicker();
            this.txt_telephone_mere = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cbx_classe = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_section = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_telephone_pere = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_genre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nom_mere = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nom_pere = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_lieu_naissance = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_postnom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.Ck_Accompte = new System.Windows.Forms.CheckBox();
            this.panelBarreDeTitre.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontant)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
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
            this.panelBarreDeTitre.Size = new System.Drawing.Size(844, 46);
            this.panelBarreDeTitre.TabIndex = 0;
            this.panelBarreDeTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarreDeTitre_MouseDown);
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(791, 6);
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
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations de l\'élève";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Ck_Accompte);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.nupMontant);
            this.panel2.Controls.Add(this.btnNettoyerPhoto);
            this.panel2.Controls.Add(this.BtnClear);
            this.panel2.Controls.Add(this.dtp_date_naissance);
            this.panel2.Controls.Add(this.txt_telephone_mere);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbx_classe);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbx_section);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_telephone_pere);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbx_genre);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_adresse);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_nom_mere);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_nom_pere);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbx_lieu_naissance);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_prenom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_postnom);
            this.panel2.Controls.Add(this.txt_nom);
            this.panel2.Controls.Add(this.pbxPhoto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 562);
            this.panel2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(357, 441);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Montant";
            // 
            // nupMontant
            // 
            this.nupMontant.Enabled = false;
            this.nupMontant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMontant.Location = new System.Drawing.Point(459, 433);
            this.nupMontant.Margin = new System.Windows.Forms.Padding(4);
            this.nupMontant.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.nupMontant.Name = "nupMontant";
            this.nupMontant.Size = new System.Drawing.Size(193, 32);
            this.nupMontant.TabIndex = 33;
            // 
            // btnNettoyerPhoto
            // 
            this.btnNettoyerPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNettoyerPhoto.Location = new System.Drawing.Point(48, 399);
            this.btnNettoyerPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnNettoyerPhoto.Name = "btnNettoyerPhoto";
            this.btnNettoyerPhoto.Size = new System.Drawing.Size(268, 34);
            this.btnNettoyerPhoto.TabIndex = 32;
            this.btnNettoyerPhoto.Text = "Nettoyer la photo";
            this.btnNettoyerPhoto.UseVisualStyleBackColor = true;
            this.btnNettoyerPhoto.Click += new System.EventHandler(this.BtnNettoyerPhoto_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(48, 363);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(268, 34);
            this.BtnClear.TabIndex = 31;
            this.BtnClear.Text = "Parcourir la racine...";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnParcourir_Click);
            // 
            // dtp_date_naissance
            // 
            this.dtp_date_naissance.CustomFormat = "";
            this.dtp_date_naissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_naissance.Location = new System.Drawing.Point(661, 188);
            this.dtp_date_naissance.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_date_naissance.Name = "dtp_date_naissance";
            this.dtp_date_naissance.Size = new System.Drawing.Size(119, 27);
            this.dtp_date_naissance.TabIndex = 9;
            // 
            // txt_telephone_mere
            // 
            this.txt_telephone_mere.Location = new System.Drawing.Point(457, 362);
            this.txt_telephone_mere.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone_mere.Name = "txt_telephone_mere";
            this.txt_telephone_mere.Size = new System.Drawing.Size(324, 27);
            this.txt_telephone_mere.TabIndex = 14;
            this.txt_telephone_mere.Text = "+243";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 363);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tél. mère";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnEnregistrer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 486);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 76);
            this.panel3.TabIndex = 26;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(327, 14);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(189, 50);
            this.btnEnregistrer.TabIndex = 20;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // cbx_classe
            // 
            this.cbx_classe.FormattingEnabled = true;
            this.cbx_classe.Location = new System.Drawing.Point(661, 395);
            this.cbx_classe.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_classe.Name = "cbx_classe";
            this.cbx_classe.Size = new System.Drawing.Size(120, 29);
            this.cbx_classe.TabIndex = 16;
            this.cbx_classe.SelectedIndexChanged += new System.EventHandler(this.Cbx_classe_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(588, 405);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Classe";
            // 
            // cbx_section
            // 
            this.cbx_section.FormattingEnabled = true;
            this.cbx_section.Items.AddRange(new object[] {
            "Maternelle",
            "Primaire",
            "Secondaire",
            "Professionelle"});
            this.cbx_section.Location = new System.Drawing.Point(459, 395);
            this.cbx_section.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_section.Name = "cbx_section";
            this.cbx_section.Size = new System.Drawing.Size(120, 29);
            this.cbx_section.TabIndex = 15;
            this.cbx_section.SelectedIndexChanged += new System.EventHandler(this.Cbx_section_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 398);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Section";
            // 
            // txt_telephone_pere
            // 
            this.txt_telephone_pere.Location = new System.Drawing.Point(459, 326);
            this.txt_telephone_pere.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone_pere.Name = "txt_telephone_pere";
            this.txt_telephone_pere.Size = new System.Drawing.Size(324, 27);
            this.txt_telephone_pere.TabIndex = 13;
            this.txt_telephone_pere.Text = "+243";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(353, 327);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tél. père";
            // 
            // cbx_genre
            // 
            this.cbx_genre.FormattingEnabled = true;
            this.cbx_genre.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbx_genre.Location = new System.Drawing.Point(459, 148);
            this.cbx_genre.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_genre.Name = "cbx_genre";
            this.cbx_genre.Size = new System.Drawing.Size(324, 29);
            this.cbx_genre.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Genre";
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(459, 290);
            this.txt_adresse.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(324, 27);
            this.txt_adresse.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Adresse";
            // 
            // txt_nom_mere
            // 
            this.txt_nom_mere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nom_mere.Location = new System.Drawing.Point(459, 256);
            this.txt_nom_mere.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom_mere.Name = "txt_nom_mere";
            this.txt_nom_mere.Size = new System.Drawing.Size(324, 27);
            this.txt_nom_mere.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mère";
            // 
            // txt_nom_pere
            // 
            this.txt_nom_pere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nom_pere.Location = new System.Drawing.Point(459, 222);
            this.txt_nom_pere.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom_pere.Name = "txt_nom_pere";
            this.txt_nom_pere.Size = new System.Drawing.Size(324, 27);
            this.txt_nom_pere.TabIndex = 10;
            this.txt_nom_pere.TextChanged += new System.EventHandler(this.Txt_nom_pere_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "père";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = ",le";
            // 
            // cbx_lieu_naissance
            // 
            this.cbx_lieu_naissance.FormattingEnabled = true;
            this.cbx_lieu_naissance.Items.AddRange(new object[] {
            "Lubumbashi",
            "Kinshasa",
            "Kolwezi",
            "Likasi",
            "Kipushi",
            "Kasumbalesa"});
            this.cbx_lieu_naissance.Location = new System.Drawing.Point(459, 185);
            this.cbx_lieu_naissance.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_lieu_naissance.Name = "cbx_lieu_naissance";
            this.cbx_lieu_naissance.Size = new System.Drawing.Size(145, 29);
            this.cbx_lieu_naissance.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Né(e) à";
            // 
            // txt_prenom
            // 
            this.txt_prenom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_prenom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_prenom.Location = new System.Drawing.Point(459, 113);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(324, 27);
            this.txt_prenom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Post-nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // txt_postnom
            // 
            this.txt_postnom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_postnom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_postnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_postnom.Location = new System.Drawing.Point(459, 79);
            this.txt_postnom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_postnom.Name = "txt_postnom";
            this.txt_postnom.Size = new System.Drawing.Size(324, 27);
            this.txt_postnom.TabIndex = 2;
            // 
            // txt_nom
            // 
            this.txt_nom.AccessibleDescription = "Le nom du client";
            this.txt_nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nom.Location = new System.Drawing.Point(459, 44);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(324, 27);
            this.txt_nom.TabIndex = 1;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhoto.Location = new System.Drawing.Point(48, 57);
            this.pbxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(267, 295);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 0;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.Click += new System.EventHandler(this.PbxPhoto_Click);
            // 
            // Ck_Accompte
            // 
            this.Ck_Accompte.AutoSize = true;
            this.Ck_Accompte.Location = new System.Drawing.Point(661, 437);
            this.Ck_Accompte.Name = "Ck_Accompte";
            this.Ck_Accompte.Size = new System.Drawing.Size(123, 25);
            this.Ck_Accompte.TabIndex = 35;
            this.Ck_Accompte.Text = "Accompte";
            this.Ck_Accompte.UseVisualStyleBackColor = true;
            this.Ck_Accompte.CheckedChanged += new System.EventHandler(this.Ck_Accompte_CheckedChanged);
            // 
            // frmNouveauEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBarreDeTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNouveauEleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau élève";
            this.Load += new System.EventHandler(this.FrmNouveauEleve_Load);
            this.panelBarreDeTitre.ResumeLayout(false);
            this.panelBarreDeTitre.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMontant)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarreDeTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.TextBox txt_postnom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_lieu_naissance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nom_mere;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nom_pere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_genre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cbx_classe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_section;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_telephone_pere;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_telephone_mere;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_date_naissance;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button btnNettoyerPhoto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nupMontant;
        private System.Windows.Forms.CheckBox Ck_Accompte;
    }
}