namespace Bibliofusion_prototype
{
    partial class Form_Administrateurs
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Filtres_de_Recherche = new System.Windows.Forms.CheckedListBox();
            this.RechercherAdmin_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NaissanceAdmin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Connexion = new System.Windows.Forms.Button();
            this.NomAdmin_textBox = new System.Windows.Forms.TextBox();
            this.MobileAdmin_textBox = new System.Windows.Forms.TextBox();
            this.AdresseAdmin_textBox = new System.Windows.Forms.TextBox();
            this.PrenomAdmin_textBox = new System.Windows.Forms.TextBox();
            this.EmailAdmin_textBox = new System.Windows.Forms.TextBox();
            this.FixeAdmin_textBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CodePostalAdmin_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Controls.Add(this.Filtres_de_Recherche);
            this.tabPage2.Controls.Add(this.RechercherAdmin_textBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editer les administrateurs";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(350, 180);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(620, 444);
            this.dataGridView.TabIndex = 60;
            // 
            // Filtres_de_Recherche
            // 
            this.Filtres_de_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Filtres_de_Recherche.FormattingEnabled = true;
            this.Filtres_de_Recherche.Location = new System.Drawing.Point(30, 180);
            this.Filtres_de_Recherche.Name = "Filtres_de_Recherche";
            this.Filtres_de_Recherche.Size = new System.Drawing.Size(300, 445);
            this.Filtres_de_Recherche.TabIndex = 55;
            // 
            // RechercherAdmin_textBox
            // 
            this.RechercherAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherAdmin_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherAdmin_textBox.Name = "RechercherAdmin_textBox";
            this.RechercherAdmin_textBox.Size = new System.Drawing.Size(750, 30);
            this.RechercherAdmin_textBox.TabIndex = 52;
            this.RechercherAdmin_textBox.Text = "Rechercher un Administrateur";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 25F);
            this.label3.Location = new System.Drawing.Point(400, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 42);
            this.label3.TabIndex = 51;
            this.label3.Text = "BiblioFusion";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.CodePostalAdmin_textBox);
            this.tabPage1.Controls.Add(this.NaissanceAdmin_dateTimePicker);
            this.tabPage1.Controls.Add(this.Connexion);
            this.tabPage1.Controls.Add(this.NomAdmin_textBox);
            this.tabPage1.Controls.Add(this.MobileAdmin_textBox);
            this.tabPage1.Controls.Add(this.AdresseAdmin_textBox);
            this.tabPage1.Controls.Add(this.PrenomAdmin_textBox);
            this.tabPage1.Controls.Add(this.EmailAdmin_textBox);
            this.tabPage1.Controls.Add(this.FixeAdmin_textBox);
            this.tabPage1.Controls.Add(this.Title);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter un administrateur";
            // 
            // NaissanceAdmin_dateTimePicker
            // 
            this.NaissanceAdmin_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NaissanceAdmin_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NaissanceAdmin_dateTimePicker.Location = new System.Drawing.Point(30, 215);
            this.NaissanceAdmin_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NaissanceAdmin_dateTimePicker.Name = "NaissanceAdmin_dateTimePicker";
            this.NaissanceAdmin_dateTimePicker.Size = new System.Drawing.Size(940, 30);
            this.NaissanceAdmin_dateTimePicker.TabIndex = 43;
            this.NaissanceAdmin_dateTimePicker.Tag = "";
            this.NaissanceAdmin_dateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // Connexion
            // 
            this.Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Connexion.Location = new System.Drawing.Point(850, 515);
            this.Connexion.Margin = new System.Windows.Forms.Padding(8);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(101, 32);
            this.Connexion.TabIndex = 40;
            this.Connexion.Text = "Valider";
            this.Connexion.UseVisualStyleBackColor = true;
            // 
            // NomAdmin_textBox
            // 
            this.NomAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomAdmin_textBox.Location = new System.Drawing.Point(30, 115);
            this.NomAdmin_textBox.Name = "NomAdmin_textBox";
            this.NomAdmin_textBox.Size = new System.Drawing.Size(940, 30);
            this.NomAdmin_textBox.TabIndex = 38;
            this.NomAdmin_textBox.Text = "Nom";
            // 
            // MobileAdmin_textBox
            // 
            this.MobileAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MobileAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.MobileAdmin_textBox.Location = new System.Drawing.Point(30, 315);
            this.MobileAdmin_textBox.Name = "MobileAdmin_textBox";
            this.MobileAdmin_textBox.Size = new System.Drawing.Size(940, 30);
            this.MobileAdmin_textBox.TabIndex = 36;
            this.MobileAdmin_textBox.Text = "N° de téléphone mobile";
            // 
            // AdresseAdmin_textBox
            // 
            this.AdresseAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdresseAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AdresseAdmin_textBox.Location = new System.Drawing.Point(30, 415);
            this.AdresseAdmin_textBox.Name = "AdresseAdmin_textBox";
            this.AdresseAdmin_textBox.Size = new System.Drawing.Size(940, 30);
            this.AdresseAdmin_textBox.TabIndex = 35;
            this.AdresseAdmin_textBox.Text = "Adresse postale";
            // 
            // PrenomAdmin_textBox
            // 
            this.PrenomAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrenomAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.PrenomAdmin_textBox.Location = new System.Drawing.Point(30, 165);
            this.PrenomAdmin_textBox.Name = "PrenomAdmin_textBox";
            this.PrenomAdmin_textBox.Size = new System.Drawing.Size(940, 30);
            this.PrenomAdmin_textBox.TabIndex = 34;
            this.PrenomAdmin_textBox.Text = "Prénom";
            // 
            // EmailAdmin_textBox
            // 
            this.EmailAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.EmailAdmin_textBox.Location = new System.Drawing.Point(30, 265);
            this.EmailAdmin_textBox.Name = "EmailAdmin_textBox";
            this.EmailAdmin_textBox.Size = new System.Drawing.Size(940, 30);
            this.EmailAdmin_textBox.TabIndex = 33;
            this.EmailAdmin_textBox.Text = "Adresse mail";
            // 
            // FixeAdmin_textBox
            // 
            this.FixeAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FixeAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.FixeAdmin_textBox.Location = new System.Drawing.Point(30, 365);
            this.FixeAdmin_textBox.Name = "FixeAdmin_textBox";
            this.FixeAdmin_textBox.Size = new System.Drawing.Size(940, 30);
            this.FixeAdmin_textBox.TabIndex = 32;
            this.FixeAdmin_textBox.Text = "N° de fixe";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 25F);
            this.Title.Location = new System.Drawing.Point(400, 35);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(191, 42);
            this.Title.TabIndex = 31;
            this.Title.Text = "BiblioFusion";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 725);
            this.tabControl1.TabIndex = 1;
            // 
            // CodePostalAdmin_textBox
            // 
            this.CodePostalAdmin_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodePostalAdmin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.CodePostalAdmin_textBox.Location = new System.Drawing.Point(30, 465);
            this.CodePostalAdmin_textBox.Name = "CodePostalAdmin_textBox";
            this.CodePostalAdmin_textBox.Size = new System.Drawing.Size(940, 30);
            this.CodePostalAdmin_textBox.TabIndex = 44;
            this.CodePostalAdmin_textBox.Text = "Code Postal";
            // 
            // Form_Administrateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_Administrateurs";
            this.Text = "BiblioFusion - administrateurs";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox Filtres_de_Recherche;
        private System.Windows.Forms.TextBox RechercherAdmin_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.TextBox NomAdmin_textBox;
        private System.Windows.Forms.TextBox MobileAdmin_textBox;
        private System.Windows.Forms.TextBox AdresseAdmin_textBox;
        private System.Windows.Forms.TextBox PrenomAdmin_textBox;
        private System.Windows.Forms.TextBox EmailAdmin_textBox;
        private System.Windows.Forms.TextBox FixeAdmin_textBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker NaissanceAdmin_dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox CodePostalAdmin_textBox;
    }
}