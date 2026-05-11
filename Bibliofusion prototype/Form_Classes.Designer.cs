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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RechercherAjoutClasse_button = new System.Windows.Forms.Button();
            this.RechercherEditerClasse_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Classes_tabControl.SuspendLayout();
            this.AjoutClasse_tabPage.SuspendLayout();
            this.EditClasse_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatClasse_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Classes_tabControl
            // 
            this.Classes_tabControl.Controls.Add(this.AjoutClasse_tabPage);
            this.Classes_tabControl.Controls.Add(this.EditClasse_tabPage);
            this.Classes_tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.Classes_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Classes_tabControl.Name = "Classes_tabControl";
            this.Classes_tabControl.SelectedIndex = 0;
            this.Classes_tabControl.Size = new System.Drawing.Size(1004, 725);
            this.Classes_tabControl.TabIndex = 1;
            // 
            // AjoutClasse_tabPage
            // 
            this.AjoutClasse_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AjoutClasse_tabPage.Controls.Add(this.dataGridView1);
            this.AjoutClasse_tabPage.Controls.Add(this.RechercherAjoutClasse_button);
            this.AjoutClasse_tabPage.Controls.Add(this.label3);
            this.AjoutClasse_tabPage.Controls.Add(this.label4);
            this.AjoutClasse_tabPage.Controls.Add(this.label2);
            this.AjoutClasse_tabPage.Controls.Add(this.label1);
            this.AjoutClasse_tabPage.Controls.Add(this.NiveauClasse_comboBox);
            this.AjoutClasse_tabPage.Controls.Add(this.RechercherEleve_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.ValiderAjoutClasse_button);
            this.AjoutClasse_tabPage.Controls.Add(this.NomClasse_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.NomProf_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.NomEtablissement_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.AdresseEtablissement_textBox);
            this.AjoutClasse_tabPage.Controls.Add(this.BiblioFusion_label1);
            this.AjoutClasse_tabPage.Location = new System.Drawing.Point(4, 29);
            this.AjoutClasse_tabPage.Name = "AjoutClasse_tabPage";
            this.AjoutClasse_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AjoutClasse_tabPage.Size = new System.Drawing.Size(996, 692);
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
            this.RechercherEleve_textBox.Size = new System.Drawing.Size(309, 30);
            this.RechercherEleve_textBox.TabIndex = 42;
            this.RechercherEleve_textBox.Text = "Rechercher un élève";
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
            this.NomClasse_textBox.Location = new System.Drawing.Point(237, 90);
            this.NomClasse_textBox.Name = "NomClasse_textBox";
            this.NomClasse_textBox.Size = new System.Drawing.Size(733, 30);
            this.NomClasse_textBox.TabIndex = 38;
            // 
            // NomProf_textBox
            // 
            this.NomProf_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomProf_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomProf_textBox.Location = new System.Drawing.Point(237, 140);
            this.NomProf_textBox.Name = "NomProf_textBox";
            this.NomProf_textBox.Size = new System.Drawing.Size(733, 30);
            this.NomProf_textBox.TabIndex = 37;
            // 
            // NomEtablissement_textBox
            // 
            this.NomEtablissement_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomEtablissement_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomEtablissement_textBox.Location = new System.Drawing.Point(237, 190);
            this.NomEtablissement_textBox.Name = "NomEtablissement_textBox";
            this.NomEtablissement_textBox.Size = new System.Drawing.Size(733, 30);
            this.NomEtablissement_textBox.TabIndex = 36;
            // 
            // AdresseEtablissement_textBox
            // 
            this.AdresseEtablissement_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdresseEtablissement_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.AdresseEtablissement_textBox.Location = new System.Drawing.Point(237, 240);
            this.AdresseEtablissement_textBox.Name = "AdresseEtablissement_textBox";
            this.AdresseEtablissement_textBox.Size = new System.Drawing.Size(733, 30);
            this.AdresseEtablissement_textBox.TabIndex = 35;
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
            this.EditClasse_tabPage.Controls.Add(this.RechercherEditerClasse_button);
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
            this.RechercherClasse_textBox.Size = new System.Drawing.Size(694, 30);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label3.Location = new System.Drawing.Point(25, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label4.Location = new System.Drawing.Point(25, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Etablissement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label2.Location = new System.Drawing.Point(25, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Professeur référant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nom de la classe";
            // 
            // RechercherAjoutClasse_button
            // 
            this.RechercherAjoutClasse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.RechercherAjoutClasse_button.Location = new System.Drawing.Point(350, 290);
            this.RechercherAjoutClasse_button.Margin = new System.Windows.Forms.Padding(8);
            this.RechercherAjoutClasse_button.Name = "RechercherAjoutClasse_button";
            this.RechercherAjoutClasse_button.Size = new System.Drawing.Size(140, 32);
            this.RechercherAjoutClasse_button.TabIndex = 58;
            this.RechercherAjoutClasse_button.Text = "Rechercher";
            this.RechercherAjoutClasse_button.UseVisualStyleBackColor = true;
            // 
            // RechercherEditerClasse_button
            // 
            this.RechercherEditerClasse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.RechercherEditerClasse_button.Location = new System.Drawing.Point(830, 115);
            this.RechercherEditerClasse_button.Margin = new System.Windows.Forms.Padding(8);
            this.RechercherEditerClasse_button.Name = "RechercherEditerClasse_button";
            this.RechercherEditerClasse_button.Size = new System.Drawing.Size(140, 32);
            this.RechercherEditerClasse_button.TabIndex = 59;
            this.RechercherEditerClasse_button.Text = "Rechercher";
            this.RechercherEditerClasse_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 300);
            this.dataGridView1.TabIndex = 59;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox NiveauClasse_comboBox;
        private System.Windows.Forms.DataGridView ResultatClasse_dataGridView;
        private System.Windows.Forms.Button RechercherAjoutClasse_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RechercherEditerClasse_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}