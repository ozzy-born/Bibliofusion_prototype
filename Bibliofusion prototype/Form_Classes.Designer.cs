namespace Bibliofusion_prototype
{
    partial class Form_Classes
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
            this.Classes_tabControl = new System.Windows.Forms.TabControl();
            this.AjoutClasse_tabPage = new System.Windows.Forms.TabPage();
            this.NiveauClasse_comboBox = new System.Windows.Forms.ComboBox();
            this.RechercherEleve_textBox = new System.Windows.Forms.TextBox();
            this.SelectionEleves_CheckListBox = new System.Windows.Forms.CheckedListBox();
            this.ValiderAjoutClasse_button = new System.Windows.Forms.Button();
            this.NomClasse_textBox = new System.Windows.Forms.TextBox();
            this.NomProf_textBox = new System.Windows.Forms.TextBox();
            this.NomEtablissement_textBox = new System.Windows.Forms.TextBox();
            this.AdresseEtablissement_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label1 = new System.Windows.Forms.Label();
            this.EditClasse_tabPage = new System.Windows.Forms.TabPage();
            this.ResultatClasse_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltresDeRechercheClasse_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherClasse_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label2 = new System.Windows.Forms.Label();
            this.Classes_tabControl.SuspendLayout();
            this.AjoutClasse_tabPage.SuspendLayout();
            this.EditClasse_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatClasse_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Classes_tabControl
            // 
            this.Classes_tabControl.Controls.Add(this.AjoutClasse_tabPage);
            this.Classes_tabControl.Controls.Add(this.EditClasse_tabPage);
            this.Classes_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Classes_tabControl.Name = "Classes_tabControl";
            this.Classes_tabControl.SelectedIndex = 0;
            this.Classes_tabControl.Size = new System.Drawing.Size(1004, 725);
            this.Classes_tabControl.TabIndex = 1;
            // 
            // AjoutClasse_tabPage
            // 
            this.AjoutClasse_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AjoutClasse_tabPage.Controls.Add(this.NiveauClasse_comboBox);
            this.AjoutClasse_tabPage.Controls.Add(this.RechercherEleve_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.SelectionEleves_CheckListBox);
            this.AjoutClasse_tabPage.Controls.Add(this.ValiderAjoutClasse_button);
            this.AjoutClasse_tabPage.Controls.Add(this.NomClasse_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.NomProf_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.NomEtablissement_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.AdresseEtablissement_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.BiblioFusion_label1);
            this.AjoutClasse_tabPage.Location = new System.Drawing.Point(4, 22);
            this.AjoutClasse_tabPage.Name = "AjoutClasse_tabPage";
            this.AjoutClasse_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AjoutClasse_tabPage.Size = new System.Drawing.Size(996, 699);
            this.AjoutClasse_tabPage.TabIndex = 0;
            this.AjoutClasse_tabPage.Text = "Ajouter une classe";
            // 
            // NiveauClasse_comboBox
            // 
            this.NiveauClasse_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NiveauClasse_comboBox.FormattingEnabled = true;
            this.NiveauClasse_comboBox.Location = new System.Drawing.Point(510, 290);
            this.NiveauClasse_comboBox.Name = "NiveauClasse_comboBox";
            this.NiveauClasse_comboBox.Size = new System.Drawing.Size(460, 33);
            this.NiveauClasse_comboBox.TabIndex = 44;
            this.NiveauClasse_comboBox.Text = "Niveau de la classe";
            // 
            // RechercherEleve_textBox
            // 
            this.RechercherEleve_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherEleve_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherEleve_textBox.Location = new System.Drawing.Point(30, 290);
            this.RechercherEleve_textBox.Name = "RechercherEleve_textBox";
            this.RechercherEleve_textBox.Size = new System.Drawing.Size(460, 30);
            this.RechercherEleve_textBox.TabIndex = 42;
            this.RechercherEleve_textBox.Text = "Rechercher un élève";
            // 
            // SelectionEleves_CheckListBox
            // 
            this.SelectionEleves_CheckListBox.FormattingEnabled = true;
            this.SelectionEleves_CheckListBox.Location = new System.Drawing.Point(30, 321);
            this.SelectionEleves_CheckListBox.Name = "SelectionEleves_CheckListBox";
            this.SelectionEleves_CheckListBox.Size = new System.Drawing.Size(460, 304);
            this.SelectionEleves_CheckListBox.TabIndex = 41;
            // 
            // ValiderAjoutClasse_button
            // 
            this.ValiderAjoutClasse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderAjoutClasse_button.Location = new System.Drawing.Point(850, 600);
            this.ValiderAjoutClasse_button.Margin = new System.Windows.Forms.Padding(8);
            this.ValiderAjoutClasse_button.Name = "ValiderAjoutClasse_button";
            this.ValiderAjoutClasse_button.Size = new System.Drawing.Size(101, 32);
            this.ValiderAjoutClasse_button.TabIndex = 40;
            this.ValiderAjoutClasse_button.Text = "Valider";
            this.ValiderAjoutClasse_button.UseVisualStyleBackColor = true;
            this.ValiderAjoutClasse_button.Click += new System.EventHandler(this.ValiderAjoutClasse_button_Click);
            // 
            // NomClasse_textBox
            // 
            this.NomClasse_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomClasse_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomClasse_textBox.Location = new System.Drawing.Point(30, 90);
            this.NomClasse_textBox.Name = "NomClasse_textBox";
            this.NomClasse_textBox.Size = new System.Drawing.Size(940, 30);
            this.NomClasse_textBox.TabIndex = 38;
            this.NomClasse_textBox.Text = "Nom de la classe";
            // 
            // NomProf_textBox
            // 
            this.NomProf_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomProf_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomProf_textBox.Location = new System.Drawing.Point(30, 140);
            this.NomProf_textBox.Name = "NomProf_textBox";
            this.NomProf_textBox.Size = new System.Drawing.Size(940, 30);
            this.NomProf_textBox.TabIndex = 37;
            this.NomProf_textBox.Text = "Nom du professeur";
            // 
            // NomEtablissement_textBox
            // 
            this.NomEtablissement_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomEtablissement_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomEtablissement_textBox.Location = new System.Drawing.Point(30, 190);
            this.NomEtablissement_textBox.Name = "NomEtablissement_textBox";
            this.NomEtablissement_textBox.Size = new System.Drawing.Size(940, 30);
            this.NomEtablissement_textBox.TabIndex = 36;
            this.NomEtablissement_textBox.Text = "Nom de l\'établissement";
            // 
            // AdresseEtablissement_textBox
            // 
            this.AdresseEtablissement_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdresseEtablissement_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AdresseEtablissement_textBox.Location = new System.Drawing.Point(30, 240);
            this.AdresseEtablissement_textBox.Name = "AdresseEtablissement_textBox";
            this.AdresseEtablissement_textBox.Size = new System.Drawing.Size(940, 30);
            this.AdresseEtablissement_textBox.TabIndex = 35;
            this.AdresseEtablissement_textBox.Text = "Adresse postale";
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
            this.BiblioFusion_label1.TabIndex = 31;
            this.BiblioFusion_label1.Text = "BiblioFusion";
            // 
            // EditClasse_tabPage
            // 
            this.EditClasse_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditClasse_tabPage.Controls.Add(this.ResultatClasse_dataGridView);
            this.EditClasse_tabPage.Controls.Add(this.FiltresDeRechercheClasse_checkedListBox);
            this.EditClasse_tabPage.Controls.Add(this.RechercherClasse_textBox);
            this.EditClasse_tabPage.Controls.Add(this.BiblioFusion_label2);
            this.EditClasse_tabPage.Location = new System.Drawing.Point(4, 22);
            this.EditClasse_tabPage.Name = "EditClasse_tabPage";
            this.EditClasse_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditClasse_tabPage.Size = new System.Drawing.Size(996, 699);
            this.EditClasse_tabPage.TabIndex = 1;
            this.EditClasse_tabPage.Text = "Editer les classes";
            // 
            // ResultatClasse_dataGridView
            // 
            this.ResultatClasse_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatClasse_dataGridView.Location = new System.Drawing.Point(350, 180);
            this.ResultatClasse_dataGridView.Name = "ResultatClasse_dataGridView";
            this.ResultatClasse_dataGridView.Size = new System.Drawing.Size(620, 445);
            this.ResultatClasse_dataGridView.TabIndex = 56;
            // 
            // FiltresDeRechercheClasse_checkedListBox
            // 
            this.FiltresDeRechercheClasse_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltresDeRechercheClasse_checkedListBox.FormattingEnabled = true;
            this.FiltresDeRechercheClasse_checkedListBox.Location = new System.Drawing.Point(30, 180);
            this.FiltresDeRechercheClasse_checkedListBox.Name = "FiltresDeRechercheClasse_checkedListBox";
            this.FiltresDeRechercheClasse_checkedListBox.Size = new System.Drawing.Size(300, 445);
            this.FiltresDeRechercheClasse_checkedListBox.TabIndex = 55;
            // 
            // RechercherClasse_textBox
            // 
            this.RechercherClasse_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherClasse_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherClasse_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherClasse_textBox.Name = "RechercherClasse_textBox";
            this.RechercherClasse_textBox.Size = new System.Drawing.Size(750, 30);
            this.RechercherClasse_textBox.TabIndex = 52;
            this.RechercherClasse_textBox.Text = "Rechercher une classe";
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
            // Form_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.Classes_tabControl);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_Classes";
            this.Text = "BiblioFusion - classes";
            this.Classes_tabControl.ResumeLayout(false);
            this.AjoutClasse_tabPage.ResumeLayout(false);
            this.AjoutClasse_tabPage.PerformLayout();
            this.EditClasse_tabPage.ResumeLayout(false);
            this.EditClasse_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatClasse_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Classes_tabControl;
        private System.Windows.Forms.TabPage AjoutClasse_tabPage;
        private System.Windows.Forms.Button ValiderAjoutClasse_button;
        private System.Windows.Forms.TextBox NomClasse_textBox;
        private System.Windows.Forms.TextBox NomProf_textBox;
        private System.Windows.Forms.TextBox NomEtablissement_textBox;
        private System.Windows.Forms.TextBox AdresseEtablissement_textBox;
        private System.Windows.Forms.Label BiblioFusion_label1;
        private System.Windows.Forms.TabPage EditClasse_tabPage;
        private System.Windows.Forms.CheckedListBox FiltresDeRechercheClasse_checkedListBox;
        private System.Windows.Forms.TextBox RechercherClasse_textBox;
        private System.Windows.Forms.Label BiblioFusion_label2;
        private System.Windows.Forms.TextBox RechercherEleve_textBox;
        private System.Windows.Forms.CheckedListBox SelectionEleves_CheckListBox;
        private System.Windows.Forms.ComboBox NiveauClasse_comboBox;
        private System.Windows.Forms.DataGridView ResultatClasse_dataGridView;
    }
}