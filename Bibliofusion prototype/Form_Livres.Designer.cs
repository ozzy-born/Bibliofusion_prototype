namespace WindowsFormsApp1
{
    partial class Form_Livres
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
            this.ValiderAjoutLivre_button = new System.Windows.Forms.Button();
            this.Livre_tabControl = new System.Windows.Forms.TabControl();
            this.AjoutLivre_tabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateParutionLivre_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgeMaxLivre_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgeMaxLivre_label = new System.Windows.Forms.Label();
            this.AgeMinLivre_label = new System.Windows.Forms.Label();
            this.AgeMinLivre_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AnneeParutionLivre_label = new System.Windows.Forms.Label();
            this.NbExemplairesLivre_label = new System.Windows.Forms.Label();
            this.NbExemplairesLivre_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CategorieLivre_comboBox = new System.Windows.Forms.ComboBox();
            this.BiblioFusion_label1 = new System.Windows.Forms.Label();
            this.TitreLivre_textBox = new System.Windows.Forms.TextBox();
            this.ISBNLivre_textBox = new System.Windows.Forms.TextBox();
            this.AuteurLivre_textBox = new System.Windows.Forms.TextBox();
            this.EmplacementLivre_textBox = new System.Windows.Forms.TextBox();
            this.EditeurLivre_textBox = new System.Windows.Forms.TextBox();
            this.EditLivre_tabPage = new System.Windows.Forms.TabPage();
            this.RechercherEditerLivre_button = new System.Windows.Forms.Button();
            this.ResultatLivre_dataGridView = new System.Windows.Forms.DataGridView();
            this.RechercherLivre_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Livre_tabControl.SuspendLayout();
            this.AjoutLivre_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMaxLivre_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMinLivre_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbExemplairesLivre_numericUpDown)).BeginInit();
            this.EditLivre_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatLivre_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ValiderAjoutLivre_button
            // 
            this.ValiderAjoutLivre_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderAjoutLivre_button.Location = new System.Drawing.Point(850, 462);
            this.ValiderAjoutLivre_button.Margin = new System.Windows.Forms.Padding(8);
            this.ValiderAjoutLivre_button.Name = "ValiderAjoutLivre_button";
            this.ValiderAjoutLivre_button.Size = new System.Drawing.Size(101, 32);
            this.ValiderAjoutLivre_button.TabIndex = 29;
            this.ValiderAjoutLivre_button.Text = "Valider";
            this.ValiderAjoutLivre_button.UseVisualStyleBackColor = true;
            this.ValiderAjoutLivre_button.Click += new System.EventHandler(this.ValiderAjoutLivre_button_Click);
            // 
            // Livre_tabControl
            // 
            this.Livre_tabControl.Controls.Add(this.AjoutLivre_tabPage);
            this.Livre_tabControl.Controls.Add(this.EditLivre_tabPage);
            this.Livre_tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.Livre_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Livre_tabControl.Name = "Livre_tabControl";
            this.Livre_tabControl.SelectedIndex = 0;
            this.Livre_tabControl.Size = new System.Drawing.Size(1005, 725);
            this.Livre_tabControl.TabIndex = 30;
            // 
            // AjoutLivre_tabPage
            // 
            this.AjoutLivre_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AjoutLivre_tabPage.Controls.Add(this.textBox1);
            this.AjoutLivre_tabPage.Controls.Add(this.label7);
            this.AjoutLivre_tabPage.Controls.Add(this.DateParutionLivre_dateTimePicker);
            this.AjoutLivre_tabPage.Controls.Add(this.label5);
            this.AjoutLivre_tabPage.Controls.Add(this.label6);
            this.AjoutLivre_tabPage.Controls.Add(this.label1);
            this.AjoutLivre_tabPage.Controls.Add(this.label2);
            this.AjoutLivre_tabPage.Controls.Add(this.label3);
            this.AjoutLivre_tabPage.Controls.Add(this.label4);
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMaxLivre_numericUpDown);
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMaxLivre_label);
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMinLivre_label);
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMinLivre_numericUpDown);
            this.AjoutLivre_tabPage.Controls.Add(this.AnneeParutionLivre_label);
            this.AjoutLivre_tabPage.Controls.Add(this.NbExemplairesLivre_label);
            this.AjoutLivre_tabPage.Controls.Add(this.NbExemplairesLivre_numericUpDown);
            this.AjoutLivre_tabPage.Controls.Add(this.CategorieLivre_comboBox);
            this.AjoutLivre_tabPage.Controls.Add(this.BiblioFusion_label1);
            this.AjoutLivre_tabPage.Controls.Add(this.TitreLivre_textBox);
            this.AjoutLivre_tabPage.Controls.Add(this.ValiderAjoutLivre_button);
            this.AjoutLivre_tabPage.Controls.Add(this.ISBNLivre_textBox);
            this.AjoutLivre_tabPage.Controls.Add(this.AuteurLivre_textBox);
            this.AjoutLivre_tabPage.Controls.Add(this.EmplacementLivre_textBox);
            this.AjoutLivre_tabPage.Controls.Add(this.EditeurLivre_textBox);
            this.AjoutLivre_tabPage.Location = new System.Drawing.Point(4, 29);
            this.AjoutLivre_tabPage.Name = "AjoutLivre_tabPage";
            this.AjoutLivre_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AjoutLivre_tabPage.Size = new System.Drawing.Size(997, 692);
            this.AjoutLivre_tabPage.TabIndex = 0;
            this.AjoutLivre_tabPage.Text = "Ajouter un livre";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox1.Location = new System.Drawing.Point(183, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(787, 30);
            this.textBox1.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label7.Location = new System.Drawing.Point(36, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 88;
            this.label7.Text = "Prénom";
            // 
            // DateParutionLivre_dateTimePicker
            // 
            this.DateParutionLivre_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.DateParutionLivre_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.DateParutionLivre_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateParutionLivre_dateTimePicker.Location = new System.Drawing.Point(285, 461);
            this.DateParutionLivre_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateParutionLivre_dateTimePicker.Name = "DateParutionLivre_dateTimePicker";
            this.DateParutionLivre_dateTimePicker.Size = new System.Drawing.Size(148, 30);
            this.DateParutionLivre_dateTimePicker.TabIndex = 87;
            this.DateParutionLivre_dateTimePicker.Tag = "";
            this.DateParutionLivre_dateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label5.Location = new System.Drawing.Point(36, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Emplacement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label6.Location = new System.Drawing.Point(36, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 85;
            this.label6.Text = "Code Unique";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label1.Location = new System.Drawing.Point(36, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Editeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label2.Location = new System.Drawing.Point(36, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Nom Auteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Titre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label4.Location = new System.Drawing.Point(36, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Catégorie";
            // 
            // AgeMaxLivre_numericUpDown
            // 
            this.AgeMaxLivre_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMaxLivre_numericUpDown.Location = new System.Drawing.Point(285, 562);
            this.AgeMaxLivre_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgeMaxLivre_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeMaxLivre_numericUpDown.Name = "AgeMaxLivre_numericUpDown";
            this.AgeMaxLivre_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.AgeMaxLivre_numericUpDown.TabIndex = 80;
            this.AgeMaxLivre_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AgeMaxLivre_label
            // 
            this.AgeMaxLivre_label.AutoSize = true;
            this.AgeMaxLivre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMaxLivre_label.Location = new System.Drawing.Point(30, 562);
            this.AgeMaxLivre_label.Name = "AgeMaxLivre_label";
            this.AgeMaxLivre_label.Size = new System.Drawing.Size(147, 25);
            this.AgeMaxLivre_label.TabIndex = 79;
            this.AgeMaxLivre_label.Text = "Age maximum";
            // 
            // AgeMinLivre_label
            // 
            this.AgeMinLivre_label.AutoSize = true;
            this.AgeMinLivre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMinLivre_label.Location = new System.Drawing.Point(30, 512);
            this.AgeMinLivre_label.Name = "AgeMinLivre_label";
            this.AgeMinLivre_label.Size = new System.Drawing.Size(141, 25);
            this.AgeMinLivre_label.TabIndex = 78;
            this.AgeMinLivre_label.Text = "Age minimum";
            // 
            // AgeMinLivre_numericUpDown
            // 
            this.AgeMinLivre_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMinLivre_numericUpDown.Location = new System.Drawing.Point(285, 512);
            this.AgeMinLivre_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgeMinLivre_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeMinLivre_numericUpDown.Name = "AgeMinLivre_numericUpDown";
            this.AgeMinLivre_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.AgeMinLivre_numericUpDown.TabIndex = 77;
            this.AgeMinLivre_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AnneeParutionLivre_label
            // 
            this.AnneeParutionLivre_label.AutoSize = true;
            this.AnneeParutionLivre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AnneeParutionLivre_label.Location = new System.Drawing.Point(30, 462);
            this.AnneeParutionLivre_label.Name = "AnneeParutionLivre_label";
            this.AnneeParutionLivre_label.Size = new System.Drawing.Size(188, 25);
            this.AnneeParutionLivre_label.TabIndex = 74;
            this.AnneeParutionLivre_label.Text = "Année de parution";
            // 
            // NbExemplairesLivre_label
            // 
            this.NbExemplairesLivre_label.AutoSize = true;
            this.NbExemplairesLivre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NbExemplairesLivre_label.Location = new System.Drawing.Point(30, 612);
            this.NbExemplairesLivre_label.Name = "NbExemplairesLivre_label";
            this.NbExemplairesLivre_label.Size = new System.Drawing.Size(225, 25);
            this.NbExemplairesLivre_label.TabIndex = 72;
            this.NbExemplairesLivre_label.Text = "Nombre d\'exemplaires";
            // 
            // NbExemplairesLivre_numericUpDown
            // 
            this.NbExemplairesLivre_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NbExemplairesLivre_numericUpDown.Location = new System.Drawing.Point(285, 612);
            this.NbExemplairesLivre_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbExemplairesLivre_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbExemplairesLivre_numericUpDown.Name = "NbExemplairesLivre_numericUpDown";
            this.NbExemplairesLivre_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.NbExemplairesLivre_numericUpDown.TabIndex = 71;
            this.NbExemplairesLivre_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CategorieLivre_comboBox
            // 
            this.CategorieLivre_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.CategorieLivre_comboBox.FormattingEnabled = true;
            this.CategorieLivre_comboBox.Location = new System.Drawing.Point(183, 312);
            this.CategorieLivre_comboBox.Name = "CategorieLivre_comboBox";
            this.CategorieLivre_comboBox.Size = new System.Drawing.Size(787, 33);
            this.CategorieLivre_comboBox.TabIndex = 57;
            // 
            // BiblioFusion_label1
            // 
            this.BiblioFusion_label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BiblioFusion_label1.AutoSize = true;
            this.BiblioFusion_label1.Font = new System.Drawing.Font("Impact", 25F);
            this.BiblioFusion_label1.Location = new System.Drawing.Point(400, 35);
            this.BiblioFusion_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BiblioFusion_label1.Name = "BiblioFusion_label1";
            this.BiblioFusion_label1.Size = new System.Drawing.Size(191, 42);
            this.BiblioFusion_label1.TabIndex = 52;
            this.BiblioFusion_label1.Text = "BiblioFusion";
            // 
            // TitreLivre_textBox
            // 
            this.TitreLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitreLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.TitreLivre_textBox.Location = new System.Drawing.Point(183, 115);
            this.TitreLivre_textBox.Name = "TitreLivre_textBox";
            this.TitreLivre_textBox.Size = new System.Drawing.Size(787, 30);
            this.TitreLivre_textBox.TabIndex = 37;
            // 
            // ISBNLivre_textBox
            // 
            this.ISBNLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISBNLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.ISBNLivre_textBox.Location = new System.Drawing.Point(183, 412);
            this.ISBNLivre_textBox.Name = "ISBNLivre_textBox";
            this.ISBNLivre_textBox.Size = new System.Drawing.Size(787, 30);
            this.ISBNLivre_textBox.TabIndex = 34;
            // 
            // AuteurLivre_textBox
            // 
            this.AuteurLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuteurLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AuteurLivre_textBox.Location = new System.Drawing.Point(183, 165);
            this.AuteurLivre_textBox.Name = "AuteurLivre_textBox";
            this.AuteurLivre_textBox.Size = new System.Drawing.Size(787, 30);
            this.AuteurLivre_textBox.TabIndex = 33;
            // 
            // EmplacementLivre_textBox
            // 
            this.EmplacementLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmplacementLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.EmplacementLivre_textBox.Location = new System.Drawing.Point(183, 362);
            this.EmplacementLivre_textBox.Name = "EmplacementLivre_textBox";
            this.EmplacementLivre_textBox.Size = new System.Drawing.Size(787, 30);
            this.EmplacementLivre_textBox.TabIndex = 32;
            // 
            // EditeurLivre_textBox
            // 
            this.EditeurLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditeurLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.EditeurLivre_textBox.Location = new System.Drawing.Point(183, 262);
            this.EditeurLivre_textBox.Name = "EditeurLivre_textBox";
            this.EditeurLivre_textBox.Size = new System.Drawing.Size(787, 30);
            this.EditeurLivre_textBox.TabIndex = 31;
            // 
            // EditLivre_tabPage
            // 
            this.EditLivre_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditLivre_tabPage.Controls.Add(this.RechercherEditerLivre_button);
            this.EditLivre_tabPage.Controls.Add(this.ResultatLivre_dataGridView);
            this.EditLivre_tabPage.Controls.Add(this.RechercherLivre_textBox);
            this.EditLivre_tabPage.Controls.Add(this.BiblioFusion_label2);
            this.EditLivre_tabPage.Controls.Add(this.button1);
            this.EditLivre_tabPage.Location = new System.Drawing.Point(4, 29);
            this.EditLivre_tabPage.Name = "EditLivre_tabPage";
            this.EditLivre_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditLivre_tabPage.Size = new System.Drawing.Size(997, 692);
            this.EditLivre_tabPage.TabIndex = 1;
            this.EditLivre_tabPage.Text = "Editer les livres";
            // 
            // RechercherEditerLivre_button
            // 
            this.RechercherEditerLivre_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.RechercherEditerLivre_button.Location = new System.Drawing.Point(830, 115);
            this.RechercherEditerLivre_button.Margin = new System.Windows.Forms.Padding(8);
            this.RechercherEditerLivre_button.Name = "RechercherEditerLivre_button";
            this.RechercherEditerLivre_button.Size = new System.Drawing.Size(140, 32);
            this.RechercherEditerLivre_button.TabIndex = 61;
            this.RechercherEditerLivre_button.Text = "Rechercher";
            this.RechercherEditerLivre_button.UseVisualStyleBackColor = true;
            this.RechercherEditerLivre_button.Click += new System.EventHandler(this.RechercherEditerLivre_button_Click);
            // 
            // ResultatLivre_dataGridView
            // 
            this.ResultatLivre_dataGridView.AllowUserToAddRows = false;
            this.ResultatLivre_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatLivre_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatLivre_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatLivre_dataGridView.Location = new System.Drawing.Point(27, 180);
            this.ResultatLivre_dataGridView.Name = "ResultatLivre_dataGridView";
            this.ResultatLivre_dataGridView.ReadOnly = true;
            this.ResultatLivre_dataGridView.Size = new System.Drawing.Size(943, 444);
            this.ResultatLivre_dataGridView.TabIndex = 60;
            // 
            // RechercherLivre_textBox
            // 
            this.RechercherLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherLivre_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherLivre_textBox.Name = "RechercherLivre_textBox";
            this.RechercherLivre_textBox.Size = new System.Drawing.Size(694, 30);
            this.RechercherLivre_textBox.TabIndex = 46;
            // 
            // BiblioFusion_label2
            // 
            this.BiblioFusion_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BiblioFusion_label2.AutoSize = true;
            this.BiblioFusion_label2.Font = new System.Drawing.Font("Impact", 25F);
            this.BiblioFusion_label2.Location = new System.Drawing.Point(400, 35);
            this.BiblioFusion_label2.Margin = new System.Windows.Forms.Padding(0);
            this.BiblioFusion_label2.Name = "BiblioFusion_label2";
            this.BiblioFusion_label2.Size = new System.Drawing.Size(191, 42);
            this.BiblioFusion_label2.TabIndex = 45;
            this.BiblioFusion_label2.Text = "BiblioFusion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.button1.Location = new System.Drawing.Point(850, 640);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 38;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Livres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.Livre_tabControl);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_Livres";
            this.Text = "BiblioFusion - livres";
            this.Livre_tabControl.ResumeLayout(false);
            this.AjoutLivre_tabPage.ResumeLayout(false);
            this.AjoutLivre_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMaxLivre_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMinLivre_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbExemplairesLivre_numericUpDown)).EndInit();
            this.EditLivre_tabPage.ResumeLayout(false);
            this.EditLivre_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatLivre_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ValiderAjoutLivre_button;
        private System.Windows.Forms.TabControl Livre_tabControl;
        private System.Windows.Forms.TabPage EditLivre_tabPage;
        private System.Windows.Forms.TabPage AjoutLivre_tabPage;
        private System.Windows.Forms.TextBox TitreLivre_textBox;
        private System.Windows.Forms.TextBox ISBNLivre_textBox;
        private System.Windows.Forms.TextBox AuteurLivre_textBox;
        private System.Windows.Forms.TextBox EmplacementLivre_textBox;
        private System.Windows.Forms.TextBox EditeurLivre_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RechercherLivre_textBox;
        private System.Windows.Forms.Label BiblioFusion_label2;
        private System.Windows.Forms.Label BiblioFusion_label1;
        private System.Windows.Forms.DataGridView ResultatLivre_dataGridView;
        private System.Windows.Forms.ComboBox CategorieLivre_comboBox;
        private System.Windows.Forms.Label NbExemplairesLivre_label;
        private System.Windows.Forms.NumericUpDown NbExemplairesLivre_numericUpDown;
        private System.Windows.Forms.Label AnneeParutionLivre_label;
        private System.Windows.Forms.NumericUpDown AgeMaxLivre_numericUpDown;
        private System.Windows.Forms.Label AgeMaxLivre_label;
        private System.Windows.Forms.Label AgeMinLivre_label;
        private System.Windows.Forms.NumericUpDown AgeMinLivre_numericUpDown;
        private System.Windows.Forms.Button RechercherEditerLivre_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateParutionLivre_dateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}