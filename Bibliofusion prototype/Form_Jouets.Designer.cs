namespace Bibliofusion_prototype
{
    partial class Form_Jouets
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
            this.Jouet_tabControl = new System.Windows.Forms.TabControl();
            this.AjoutJouet_tabPage = new System.Windows.Forms.TabPage();
            this.DateVenteJouet_label = new System.Windows.Forms.Label();
            this.DateVenteJouet_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgeMaxJouet_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgeMaxJouet_label = new System.Windows.Forms.Label();
            this.AgeMinJouet_label = new System.Windows.Forms.Label();
            this.AgeMinJouet_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NbExemplairesJouet_label = new System.Windows.Forms.Label();
            this.NbExemplairesJouet_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CategorieJouet_comboBox = new System.Windows.Forms.ComboBox();
            this.BiblioFusion_label1 = new System.Windows.Forms.Label();
            this.NomJouet_textBox = new System.Windows.Forms.TextBox();
            this.ValiderAjoutJouet_button = new System.Windows.Forms.Button();
            this.IdJouet_textBox = new System.Windows.Forms.TextBox();
            this.MarqueJouet_textBox = new System.Windows.Forms.TextBox();
            this.EmplacementJouet_textBox = new System.Windows.Forms.TextBox();
            this.EditJouet_tabPage = new System.Windows.Forms.TabPage();
            this.ResultatJouet_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltresDeRechercheJouet_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherJouet_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label2 = new System.Windows.Forms.Label();
            this.Jouet_tabControl.SuspendLayout();
            this.AjoutJouet_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateVenteJouet_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMaxJouet_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMinJouet_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbExemplairesJouet_numericUpDown)).BeginInit();
            this.EditJouet_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatJouet_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Jouet_tabControl
            // 
            this.Jouet_tabControl.Controls.Add(this.AjoutJouet_tabPage);
            this.Jouet_tabControl.Controls.Add(this.EditJouet_tabPage);
            this.Jouet_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Jouet_tabControl.Name = "Jouet_tabControl";
            this.Jouet_tabControl.SelectedIndex = 0;
            this.Jouet_tabControl.Size = new System.Drawing.Size(1005, 725);
            this.Jouet_tabControl.TabIndex = 31;
            // 
            // AjoutJouet_tabPage
            // 
            this.AjoutJouet_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AjoutJouet_tabPage.Controls.Add(this.DateVenteJouet_label);
            this.AjoutJouet_tabPage.Controls.Add(this.DateVenteJouet_numericUpDown);
            this.AjoutJouet_tabPage.Controls.Add(this.AgeMaxJouet_numericUpDown);
            this.AjoutJouet_tabPage.Controls.Add(this.AgeMaxJouet_label);
            this.AjoutJouet_tabPage.Controls.Add(this.AgeMinJouet_label);
            this.AjoutJouet_tabPage.Controls.Add(this.AgeMinJouet_numericUpDown);
            this.AjoutJouet_tabPage.Controls.Add(this.NbExemplairesJouet_label);
            this.AjoutJouet_tabPage.Controls.Add(this.NbExemplairesJouet_numericUpDown);
            this.AjoutJouet_tabPage.Controls.Add(this.CategorieJouet_comboBox);
            this.AjoutJouet_tabPage.Controls.Add(this.BiblioFusion_label1);
            this.AjoutJouet_tabPage.Controls.Add(this.NomJouet_textBox);
            this.AjoutJouet_tabPage.Controls.Add(this.ValiderAjoutJouet_button);
            this.AjoutJouet_tabPage.Controls.Add(this.IdJouet_textBox);
            this.AjoutJouet_tabPage.Controls.Add(this.MarqueJouet_textBox);
            this.AjoutJouet_tabPage.Controls.Add(this.EmplacementJouet_textBox);
            this.AjoutJouet_tabPage.Location = new System.Drawing.Point(4, 22);
            this.AjoutJouet_tabPage.Name = "AjoutJouet_tabPage";
            this.AjoutJouet_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AjoutJouet_tabPage.Size = new System.Drawing.Size(997, 699);
            this.AjoutJouet_tabPage.TabIndex = 0;
            this.AjoutJouet_tabPage.Text = "Ajouter un jouet";
            // 
            // DateVenteJouet_label
            // 
            this.DateVenteJouet_label.AutoSize = true;
            this.DateVenteJouet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.DateVenteJouet_label.Location = new System.Drawing.Point(30, 365);
            this.DateVenteJouet_label.Name = "DateVenteJouet_label";
            this.DateVenteJouet_label.Size = new System.Drawing.Size(248, 25);
            this.DateVenteJouet_label.TabIndex = 76;
            this.DateVenteJouet_label.Text = "Annee de Mise en Vente";
            // 
            // DateVenteJouet_numericUpDown
            // 
            this.DateVenteJouet_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.DateVenteJouet_numericUpDown.Location = new System.Drawing.Point(285, 365);
            this.DateVenteJouet_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.DateVenteJouet_numericUpDown.Name = "DateVenteJouet_numericUpDown";
            this.DateVenteJouet_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.DateVenteJouet_numericUpDown.TabIndex = 75;
            this.DateVenteJouet_numericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // AgeMaxJouet_numericUpDown
            // 
            this.AgeMaxJouet_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMaxJouet_numericUpDown.Location = new System.Drawing.Point(285, 465);
            this.AgeMaxJouet_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgeMaxJouet_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeMaxJouet_numericUpDown.Name = "AgeMaxJouet_numericUpDown";
            this.AgeMaxJouet_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.AgeMaxJouet_numericUpDown.TabIndex = 74;
            this.AgeMaxJouet_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AgeMaxJouet_label
            // 
            this.AgeMaxJouet_label.AutoSize = true;
            this.AgeMaxJouet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMaxJouet_label.Location = new System.Drawing.Point(30, 465);
            this.AgeMaxJouet_label.Name = "AgeMaxJouet_label";
            this.AgeMaxJouet_label.Size = new System.Drawing.Size(147, 25);
            this.AgeMaxJouet_label.TabIndex = 73;
            this.AgeMaxJouet_label.Text = "Age maximum";
            // 
            // AgeMinJouet_label
            // 
            this.AgeMinJouet_label.AutoSize = true;
            this.AgeMinJouet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMinJouet_label.Location = new System.Drawing.Point(30, 415);
            this.AgeMinJouet_label.Name = "AgeMinJouet_label";
            this.AgeMinJouet_label.Size = new System.Drawing.Size(141, 25);
            this.AgeMinJouet_label.TabIndex = 72;
            this.AgeMinJouet_label.Text = "Age minimum";
            // 
            // AgeMinJouet_numericUpDown
            // 
            this.AgeMinJouet_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AgeMinJouet_numericUpDown.Location = new System.Drawing.Point(285, 415);
            this.AgeMinJouet_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgeMinJouet_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeMinJouet_numericUpDown.Name = "AgeMinJouet_numericUpDown";
            this.AgeMinJouet_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.AgeMinJouet_numericUpDown.TabIndex = 71;
            this.AgeMinJouet_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NbExemplairesJouet_label
            // 
            this.NbExemplairesJouet_label.AutoSize = true;
            this.NbExemplairesJouet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NbExemplairesJouet_label.Location = new System.Drawing.Point(30, 515);
            this.NbExemplairesJouet_label.Name = "NbExemplairesJouet_label";
            this.NbExemplairesJouet_label.Size = new System.Drawing.Size(225, 25);
            this.NbExemplairesJouet_label.TabIndex = 70;
            this.NbExemplairesJouet_label.Text = "Nombre d\'exemplaires";
            // 
            // NbExemplairesJouet_numericUpDown
            // 
            this.NbExemplairesJouet_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NbExemplairesJouet_numericUpDown.Location = new System.Drawing.Point(285, 515);
            this.NbExemplairesJouet_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbExemplairesJouet_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbExemplairesJouet_numericUpDown.Name = "NbExemplairesJouet_numericUpDown";
            this.NbExemplairesJouet_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.NbExemplairesJouet_numericUpDown.TabIndex = 54;
            this.NbExemplairesJouet_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CategorieJouet_comboBox
            // 
            this.CategorieJouet_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.CategorieJouet_comboBox.FormattingEnabled = true;
            this.CategorieJouet_comboBox.Location = new System.Drawing.Point(30, 165);
            this.CategorieJouet_comboBox.Name = "CategorieJouet_comboBox";
            this.CategorieJouet_comboBox.Size = new System.Drawing.Size(940, 33);
            this.CategorieJouet_comboBox.TabIndex = 53;
            this.CategorieJouet_comboBox.Text = "Catégorie";
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
            // NomJouet_textBox
            // 
            this.NomJouet_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomJouet_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomJouet_textBox.Location = new System.Drawing.Point(30, 115);
            this.NomJouet_textBox.Name = "NomJouet_textBox";
            this.NomJouet_textBox.Size = new System.Drawing.Size(940, 30);
            this.NomJouet_textBox.TabIndex = 37;
            this.NomJouet_textBox.Text = "Nom";
            // 
            // ValiderAjoutJouet_button
            // 
            this.ValiderAjoutJouet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderAjoutJouet_button.Location = new System.Drawing.Point(850, 365);
            this.ValiderAjoutJouet_button.Margin = new System.Windows.Forms.Padding(8);
            this.ValiderAjoutJouet_button.Name = "ValiderAjoutJouet_button";
            this.ValiderAjoutJouet_button.Size = new System.Drawing.Size(101, 32);
            this.ValiderAjoutJouet_button.TabIndex = 29;
            this.ValiderAjoutJouet_button.Text = "Valider";
            this.ValiderAjoutJouet_button.UseVisualStyleBackColor = true;
            this.ValiderAjoutJouet_button.Click += new System.EventHandler(this.ValiderAjoutJouet_button_Click);
            // 
            // IdJouet_textBox
            // 
            this.IdJouet_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdJouet_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.IdJouet_textBox.Location = new System.Drawing.Point(30, 315);
            this.IdJouet_textBox.Name = "IdJouet_textBox";
            this.IdJouet_textBox.Size = new System.Drawing.Size(940, 30);
            this.IdJouet_textBox.TabIndex = 34;
            this.IdJouet_textBox.Text = "Code unique";
            // 
            // MarqueJouet_textBox
            // 
            this.MarqueJouet_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarqueJouet_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.MarqueJouet_textBox.Location = new System.Drawing.Point(30, 215);
            this.MarqueJouet_textBox.Name = "MarqueJouet_textBox";
            this.MarqueJouet_textBox.Size = new System.Drawing.Size(940, 30);
            this.MarqueJouet_textBox.TabIndex = 33;
            this.MarqueJouet_textBox.Text = "Marque";
            // 
            // EmplacementJouet_textBox
            // 
            this.EmplacementJouet_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmplacementJouet_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.EmplacementJouet_textBox.Location = new System.Drawing.Point(30, 265);
            this.EmplacementJouet_textBox.Name = "EmplacementJouet_textBox";
            this.EmplacementJouet_textBox.Size = new System.Drawing.Size(940, 30);
            this.EmplacementJouet_textBox.TabIndex = 32;
            this.EmplacementJouet_textBox.Text = "Emplacement";
            // 
            // EditJouet_tabPage
            // 
            this.EditJouet_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditJouet_tabPage.Controls.Add(this.ResultatJouet_dataGridView);
            this.EditJouet_tabPage.Controls.Add(this.FiltresDeRechercheJouet_checkedListBox);
            this.EditJouet_tabPage.Controls.Add(this.RechercherJouet_textBox);
            this.EditJouet_tabPage.Controls.Add(this.BiblioFusion_label2);
            this.EditJouet_tabPage.Location = new System.Drawing.Point(4, 22);
            this.EditJouet_tabPage.Name = "EditJouet_tabPage";
            this.EditJouet_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditJouet_tabPage.Size = new System.Drawing.Size(997, 699);
            this.EditJouet_tabPage.TabIndex = 1;
            this.EditJouet_tabPage.Text = "Editer les jouets";
            // 
            // ResultatJouet_dataGridView
            // 
            this.ResultatJouet_dataGridView.AllowUserToAddRows = false;
            this.ResultatJouet_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatJouet_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatJouet_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatJouet_dataGridView.Location = new System.Drawing.Point(350, 180);
            this.ResultatJouet_dataGridView.Name = "ResultatJouet_dataGridView";
            this.ResultatJouet_dataGridView.ReadOnly = true;
            this.ResultatJouet_dataGridView.Size = new System.Drawing.Size(620, 444);
            this.ResultatJouet_dataGridView.TabIndex = 60;
            // 
            // FiltresDeRechercheJouet_checkedListBox
            // 
            this.FiltresDeRechercheJouet_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltresDeRechercheJouet_checkedListBox.FormattingEnabled = true;
            this.FiltresDeRechercheJouet_checkedListBox.Location = new System.Drawing.Point(30, 180);
            this.FiltresDeRechercheJouet_checkedListBox.Name = "FiltresDeRechercheJouet_checkedListBox";
            this.FiltresDeRechercheJouet_checkedListBox.Size = new System.Drawing.Size(300, 445);
            this.FiltresDeRechercheJouet_checkedListBox.TabIndex = 55;
            // 
            // RechercherJouet_textBox
            // 
            this.RechercherJouet_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherJouet_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherJouet_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherJouet_textBox.Name = "RechercherJouet_textBox";
            this.RechercherJouet_textBox.Size = new System.Drawing.Size(750, 30);
            this.RechercherJouet_textBox.TabIndex = 52;
            this.RechercherJouet_textBox.Text = "Rechercher un jouet";
            // 
            // BiblioFusion_label2
            // 
            this.BiblioFusion_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BiblioFusion_label2.AutoSize = true;
            this.BiblioFusion_label2.Font = new System.Drawing.Font("Impact", 25F);
            this.BiblioFusion_label2.Location = new System.Drawing.Point(400, 35);
            this.BiblioFusion_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BiblioFusion_label2.Name = "BiblioFusion_label2";
            this.BiblioFusion_label2.Size = new System.Drawing.Size(191, 42);
            this.BiblioFusion_label2.TabIndex = 51;
            this.BiblioFusion_label2.Text = "BiblioFusion";
            // 
            // Form_Jouets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.Jouet_tabControl);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_Jouets";
            this.Text = "BiblioFusion - jouets";
            this.Jouet_tabControl.ResumeLayout(false);
            this.AjoutJouet_tabPage.ResumeLayout(false);
            this.AjoutJouet_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateVenteJouet_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMaxJouet_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeMinJouet_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbExemplairesJouet_numericUpDown)).EndInit();
            this.EditJouet_tabPage.ResumeLayout(false);
            this.EditJouet_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatJouet_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Jouet_tabControl;
        private System.Windows.Forms.TabPage AjoutJouet_tabPage;
        private System.Windows.Forms.TextBox NomJouet_textBox;
        private System.Windows.Forms.Button ValiderAjoutJouet_button;
        private System.Windows.Forms.TextBox IdJouet_textBox;
        private System.Windows.Forms.TextBox MarqueJouet_textBox;
        private System.Windows.Forms.TextBox EmplacementJouet_textBox;
        private System.Windows.Forms.TabPage EditJouet_tabPage;
        private System.Windows.Forms.TextBox RechercherJouet_textBox;
        private System.Windows.Forms.Label BiblioFusion_label2;
        private System.Windows.Forms.Label BiblioFusion_label1;
        private System.Windows.Forms.CheckedListBox FiltresDeRechercheJouet_checkedListBox;
        private System.Windows.Forms.DataGridView ResultatJouet_dataGridView;
        private System.Windows.Forms.ComboBox CategorieJouet_comboBox;
        private System.Windows.Forms.NumericUpDown NbExemplairesJouet_numericUpDown;
        private System.Windows.Forms.Label NbExemplairesJouet_label;
        private System.Windows.Forms.NumericUpDown AgeMaxJouet_numericUpDown;
        private System.Windows.Forms.Label AgeMaxJouet_label;
        private System.Windows.Forms.Label AgeMinJouet_label;
        private System.Windows.Forms.NumericUpDown AgeMinJouet_numericUpDown;
        private System.Windows.Forms.Label DateVenteJouet_label;
        private System.Windows.Forms.NumericUpDown DateVenteJouet_numericUpDown;
    }
}