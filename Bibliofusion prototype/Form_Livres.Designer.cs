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
            this.ResultatLivre_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltresDeRechercheLivre_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherLivre_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AnneeParutionLivre_label = new System.Windows.Forms.Label();
            this.DateParutionLivre_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgeMaxLivre_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgeMaxLivre_label = new System.Windows.Forms.Label();
            this.AgeMinLivre_label = new System.Windows.Forms.Label();
            this.AgeMinLivre_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Livre_tabControl.SuspendLayout();
            this.AjoutLivre_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbExemplairesLivre_numericUpDown)).BeginInit();
            this.EditLivre_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatLivre_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateParutionLivre_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMaxLivre_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMinLivre_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ValiderAjoutLivre_button
            // 
            this.ValiderAjoutLivre_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderAjoutLivre_button.Location = new System.Drawing.Point(850, 415);
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
            this.Livre_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Livre_tabControl.Name = "Livre_tabControl";
            this.Livre_tabControl.SelectedIndex = 0;
            this.Livre_tabControl.Size = new System.Drawing.Size(1005, 725);
            this.Livre_tabControl.TabIndex = 30;
            // 
            // AjoutLivre_tabPage
            // 
            this.AjoutLivre_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMaxLivre_numericUpDown);
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMaxLivre_label);
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMinLivre_label);
            this.AjoutLivre_tabPage.Controls.Add(this.AgeMinLivre_numericUpDown);
            this.AjoutLivre_tabPage.Controls.Add(this.DateParutionLivre_numericUpDown);
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
            this.AjoutLivre_tabPage.Location = new System.Drawing.Point(4, 22);
            this.AjoutLivre_tabPage.Name = "AjoutLivre_tabPage";
            this.AjoutLivre_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AjoutLivre_tabPage.Size = new System.Drawing.Size(997, 699);
            this.AjoutLivre_tabPage.TabIndex = 0;
            this.AjoutLivre_tabPage.Text = "Ajouter un livre";
            // 
            // NbExemplairesLivre_label
            // 
            this.NbExemplairesLivre_label.AutoSize = true;
            this.NbExemplairesLivre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NbExemplairesLivre_label.Location = new System.Drawing.Point(30, 565);
            this.NbExemplairesLivre_label.Name = "NbExemplairesLivre_label";
            this.NbExemplairesLivre_label.Size = new System.Drawing.Size(225, 25);
            this.NbExemplairesLivre_label.TabIndex = 72;
            this.NbExemplairesLivre_label.Text = "Nombre d\'exemplaires";
            // 
            // NbExemplairesLivre_numericUpDown
            // 
            this.NbExemplairesLivre_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NbExemplairesLivre_numericUpDown.Location = new System.Drawing.Point(285, 565);
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
            this.CategorieLivre_comboBox.Location = new System.Drawing.Point(30, 265);
            this.CategorieLivre_comboBox.Name = "CategorieLivre_comboBox";
            this.CategorieLivre_comboBox.Size = new System.Drawing.Size(940, 33);
            this.CategorieLivre_comboBox.TabIndex = 57;
            this.CategorieLivre_comboBox.Text = "Catégorie";
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
            this.TitreLivre_textBox.Location = new System.Drawing.Point(30, 115);
            this.TitreLivre_textBox.Name = "TitreLivre_textBox";
            this.TitreLivre_textBox.Size = new System.Drawing.Size(940, 30);
            this.TitreLivre_textBox.TabIndex = 37;
            this.TitreLivre_textBox.Text = "Titre";
            // 
            // ISBNLivre_textBox
            // 
            this.ISBNLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISBNLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.ISBNLivre_textBox.Location = new System.Drawing.Point(30, 365);
            this.ISBNLivre_textBox.Name = "ISBNLivre_textBox";
            this.ISBNLivre_textBox.Size = new System.Drawing.Size(940, 30);
            this.ISBNLivre_textBox.TabIndex = 34;
            this.ISBNLivre_textBox.Text = "ISBN ou code unique";
            // 
            // AuteurLivre_textBox
            // 
            this.AuteurLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuteurLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AuteurLivre_textBox.Location = new System.Drawing.Point(30, 165);
            this.AuteurLivre_textBox.Name = "AuteurLivre_textBox";
            this.AuteurLivre_textBox.Size = new System.Drawing.Size(940, 30);
            this.AuteurLivre_textBox.TabIndex = 33;
            this.AuteurLivre_textBox.Text = "Auteur";
            // 
            // EmplacementLivre_textBox
            // 
            this.EmplacementLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmplacementLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.EmplacementLivre_textBox.Location = new System.Drawing.Point(30, 315);
            this.EmplacementLivre_textBox.Name = "EmplacementLivre_textBox";
            this.EmplacementLivre_textBox.Size = new System.Drawing.Size(940, 30);
            this.EmplacementLivre_textBox.TabIndex = 32;
            this.EmplacementLivre_textBox.Text = "Emplacement";
            // 
            // EditeurLivre_textBox
            // 
            this.EditeurLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditeurLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.EditeurLivre_textBox.Location = new System.Drawing.Point(30, 215);
            this.EditeurLivre_textBox.Name = "EditeurLivre_textBox";
            this.EditeurLivre_textBox.Size = new System.Drawing.Size(940, 30);
            this.EditeurLivre_textBox.TabIndex = 31;
            this.EditeurLivre_textBox.Text = "Editeur";
            // 
            // EditLivre_tabPage
            // 
            this.EditLivre_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditLivre_tabPage.Controls.Add(this.ResultatLivre_dataGridView);
            this.EditLivre_tabPage.Controls.Add(this.FiltresDeRechercheLivre_checkedListBox);
            this.EditLivre_tabPage.Controls.Add(this.RechercherLivre_textBox);
            this.EditLivre_tabPage.Controls.Add(this.BiblioFusion_label2);
            this.EditLivre_tabPage.Controls.Add(this.button1);
            this.EditLivre_tabPage.Location = new System.Drawing.Point(4, 22);
            this.EditLivre_tabPage.Name = "EditLivre_tabPage";
            this.EditLivre_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditLivre_tabPage.Size = new System.Drawing.Size(997, 699);
            this.EditLivre_tabPage.TabIndex = 1;
            this.EditLivre_tabPage.Text = "Editer les livres";
            // 
            // ResultatLivre_dataGridView
            // 
            this.ResultatLivre_dataGridView.AllowUserToAddRows = false;
            this.ResultatLivre_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatLivre_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatLivre_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatLivre_dataGridView.Location = new System.Drawing.Point(350, 180);
            this.ResultatLivre_dataGridView.Name = "ResultatLivre_dataGridView";
            this.ResultatLivre_dataGridView.ReadOnly = true;
            this.ResultatLivre_dataGridView.Size = new System.Drawing.Size(620, 444);
            this.ResultatLivre_dataGridView.TabIndex = 60;
            // 
            // FiltresDeRechercheLivre_checkedListBox
            // 
            this.FiltresDeRechercheLivre_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltresDeRechercheLivre_checkedListBox.FormattingEnabled = true;
            this.FiltresDeRechercheLivre_checkedListBox.Location = new System.Drawing.Point(30, 180);
            this.FiltresDeRechercheLivre_checkedListBox.Name = "FiltresDeRechercheLivre_checkedListBox";
            this.FiltresDeRechercheLivre_checkedListBox.Size = new System.Drawing.Size(300, 445);
            this.FiltresDeRechercheLivre_checkedListBox.TabIndex = 49;
            // 
            // RechercherLivre_textBox
            // 
            this.RechercherLivre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherLivre_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherLivre_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherLivre_textBox.Name = "RechercherLivre_textBox";
            this.RechercherLivre_textBox.Size = new System.Drawing.Size(750, 30);
            this.RechercherLivre_textBox.TabIndex = 46;
            this.RechercherLivre_textBox.Text = "Rechercher un livre";
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
            // AnneeParutionLivre_label
            // 
            this.AnneeParutionLivre_label.AutoSize = true;
            this.AnneeParutionLivre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AnneeParutionLivre_label.Location = new System.Drawing.Point(30, 415);
            this.AnneeParutionLivre_label.Name = "AnneeParutionLivre_label";
            this.AnneeParutionLivre_label.Size = new System.Drawing.Size(188, 25);
            this.AnneeParutionLivre_label.TabIndex = 74;
            this.AnneeParutionLivre_label.Text = "Année de parution";
            // 
            // DateParutionLivre_numericUpDown
            // 
            this.DateParutionLivre_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.DateParutionLivre_numericUpDown.Location = new System.Drawing.Point(285, 415);
            this.DateParutionLivre_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.DateParutionLivre_numericUpDown.Name = "DateParutionLivre_numericUpDown";
            this.DateParutionLivre_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.DateParutionLivre_numericUpDown.TabIndex = 76;
            this.DateParutionLivre_numericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // AgeMaxLivre_numericUpDown
            // 
            this.AgeMaxLivre_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMaxLivre_numericUpDown.Location = new System.Drawing.Point(285, 515);
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
            this.AgeMaxLivre_label.Location = new System.Drawing.Point(30, 515);
            this.AgeMaxLivre_label.Name = "AgeMaxLivre_label";
            this.AgeMaxLivre_label.Size = new System.Drawing.Size(147, 25);
            this.AgeMaxLivre_label.TabIndex = 79;
            this.AgeMaxLivre_label.Text = "Age maximum";
            // 
            // AgeMinLivre_label
            // 
            this.AgeMinLivre_label.AutoSize = true;
            this.AgeMinLivre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMinLivre_label.Location = new System.Drawing.Point(30, 465);
            this.AgeMinLivre_label.Name = "AgeMinLivre_label";
            this.AgeMinLivre_label.Size = new System.Drawing.Size(141, 25);
            this.AgeMinLivre_label.TabIndex = 78;
            this.AgeMinLivre_label.Text = "Age minimum";
            // 
            // AgeMinLivre_numericUpDown
            // 
            this.AgeMinLivre_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMinLivre_numericUpDown.Location = new System.Drawing.Point(285, 465);
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
            ((System.ComponentModel.ISupportInitialize)(this.NbExemplairesLivre_numericUpDown)).EndInit();
            this.EditLivre_tabPage.ResumeLayout(false);
            this.EditLivre_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatLivre_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateParutionLivre_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMaxLivre_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMinLivre_numericUpDown)).EndInit();
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
        private System.Windows.Forms.CheckedListBox FiltresDeRechercheLivre_checkedListBox;
        private System.Windows.Forms.TextBox RechercherLivre_textBox;
        private System.Windows.Forms.Label BiblioFusion_label2;
        private System.Windows.Forms.Label BiblioFusion_label1;
        private System.Windows.Forms.DataGridView ResultatLivre_dataGridView;
        private System.Windows.Forms.ComboBox CategorieLivre_comboBox;
        private System.Windows.Forms.Label NbExemplairesLivre_label;
        private System.Windows.Forms.NumericUpDown NbExemplairesLivre_numericUpDown;
        private System.Windows.Forms.Label AnneeParutionLivre_label;
        private System.Windows.Forms.NumericUpDown DateParutionLivre_numericUpDown;
        private System.Windows.Forms.NumericUpDown AgeMaxLivre_numericUpDown;
        private System.Windows.Forms.Label AgeMaxLivre_label;
        private System.Windows.Forms.Label AgeMinLivre_label;
        private System.Windows.Forms.NumericUpDown AgeMinLivre_numericUpDown;
    }
}