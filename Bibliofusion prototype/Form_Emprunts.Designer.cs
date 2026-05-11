namespace Bibliofusion_prototype
{
    partial class Form_Emprunts
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
            this.Emprunts_tabControl = new System.Windows.Forms.TabControl();
            this.NouvelEmprunt_tabPage = new System.Windows.Forms.TabPage();
            this.NomAdherentEmprunt_label = new System.Windows.Forms.Label();
            this.ResultatEmprunt_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltreDeRechercheEmprunt_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherEmprunt_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label1 = new System.Windows.Forms.Label();
            this.ValiderEmprunt_button = new System.Windows.Forms.Button();
            this.EnregistrerUnRetour_tabPage = new System.Windows.Forms.TabPage();
            this.NomAdherentRetour_label = new System.Windows.Forms.Label();
            this.ResultatRetour_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltreDeRechercheRetour_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherRetour_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label2 = new System.Windows.Forms.Label();
            this.ValiderRetour_button = new System.Windows.Forms.Button();
            this.ReserverUnArticle_tabPage = new System.Windows.Forms.TabPage();
            this.NomAdherentReserver_label = new System.Windows.Forms.Label();
            this.ResultatResever_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltreDeRechercheReserver_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherReserver_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label3 = new System.Windows.Forms.Label();
            this.ValiderReserver_button = new System.Windows.Forms.Button();
            this.RechercherNouvelEmprunt_button = new System.Windows.Forms.Button();
            this.RechercherEnregisterRetour_button = new System.Windows.Forms.Button();
            this.RechercherReserver_button = new System.Windows.Forms.Button();
            this.Emprunts_tabControl.SuspendLayout();
            this.NouvelEmprunt_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatEmprunt_dataGridView)).BeginInit();
            this.EnregistrerUnRetour_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatRetour_dataGridView)).BeginInit();
            this.ReserverUnArticle_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatResever_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Emprunts_tabControl
            // 
            this.Emprunts_tabControl.Controls.Add(this.NouvelEmprunt_tabPage);
            this.Emprunts_tabControl.Controls.Add(this.EnregistrerUnRetour_tabPage);
            this.Emprunts_tabControl.Controls.Add(this.ReserverUnArticle_tabPage);
            this.Emprunts_tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold);
            this.Emprunts_tabControl.ItemSize = new System.Drawing.Size(86, 18);
            this.Emprunts_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Emprunts_tabControl.Name = "Emprunts_tabControl";
            this.Emprunts_tabControl.SelectedIndex = 0;
            this.Emprunts_tabControl.Size = new System.Drawing.Size(1005, 725);
            this.Emprunts_tabControl.TabIndex = 32;
            // 
            // NouvelEmprunt_tabPage
            // 
            this.NouvelEmprunt_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NouvelEmprunt_tabPage.Controls.Add(this.RechercherNouvelEmprunt_button);
            this.NouvelEmprunt_tabPage.Controls.Add(this.NomAdherentEmprunt_label);
            this.NouvelEmprunt_tabPage.Controls.Add(this.ResultatEmprunt_dataGridView);
            this.NouvelEmprunt_tabPage.Controls.Add(this.FiltreDeRechercheEmprunt_checkedListBox);
            this.NouvelEmprunt_tabPage.Controls.Add(this.RechercherEmprunt_textBox);
            this.NouvelEmprunt_tabPage.Controls.Add(this.BiblioFusion_label1);
            this.NouvelEmprunt_tabPage.Controls.Add(this.ValiderEmprunt_button);
            this.NouvelEmprunt_tabPage.Location = new System.Drawing.Point(4, 22);
            this.NouvelEmprunt_tabPage.Name = "NouvelEmprunt_tabPage";
            this.NouvelEmprunt_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NouvelEmprunt_tabPage.Size = new System.Drawing.Size(997, 699);
            this.NouvelEmprunt_tabPage.TabIndex = 0;
            this.NouvelEmprunt_tabPage.Text = "Nouvel emprunt";
            // 
            // NomAdherentEmprunt_label
            // 
            this.NomAdherentEmprunt_label.AutoSize = true;
            this.NomAdherentEmprunt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomAdherentEmprunt_label.Location = new System.Drawing.Point(650, 65);
            this.NomAdherentEmprunt_label.Name = "NomAdherentEmprunt_label";
            this.NomAdherentEmprunt_label.Size = new System.Drawing.Size(149, 25);
            this.NomAdherentEmprunt_label.TabIndex = 68;
            this.NomAdherentEmprunt_label.Text = "Nom Adherent";
            // 
            // ResultatEmprunt_dataGridView
            // 
            this.ResultatEmprunt_dataGridView.AllowUserToAddRows = false;
            this.ResultatEmprunt_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatEmprunt_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatEmprunt_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatEmprunt_dataGridView.Location = new System.Drawing.Point(350, 180);
            this.ResultatEmprunt_dataGridView.Name = "ResultatEmprunt_dataGridView";
            this.ResultatEmprunt_dataGridView.ReadOnly = true;
            this.ResultatEmprunt_dataGridView.Size = new System.Drawing.Size(620, 445);
            this.ResultatEmprunt_dataGridView.TabIndex = 67;
            // 
            // FiltreDeRechercheEmprunt_checkedListBox
            // 
            this.FiltreDeRechercheEmprunt_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltreDeRechercheEmprunt_checkedListBox.FormattingEnabled = true;
            this.FiltreDeRechercheEmprunt_checkedListBox.Location = new System.Drawing.Point(30, 180);
            this.FiltreDeRechercheEmprunt_checkedListBox.Name = "FiltreDeRechercheEmprunt_checkedListBox";
            this.FiltreDeRechercheEmprunt_checkedListBox.Size = new System.Drawing.Size(300, 445);
            this.FiltreDeRechercheEmprunt_checkedListBox.TabIndex = 66;
            // 
            // RechercherEmprunt_textBox
            // 
            this.RechercherEmprunt_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherEmprunt_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherEmprunt_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherEmprunt_textBox.Name = "RechercherEmprunt_textBox";
            this.RechercherEmprunt_textBox.Size = new System.Drawing.Size(694, 30);
            this.RechercherEmprunt_textBox.TabIndex = 65;
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
            this.BiblioFusion_label1.TabIndex = 64;
            this.BiblioFusion_label1.Text = "BiblioFusion";
            // 
            // ValiderEmprunt_button
            // 
            this.ValiderEmprunt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderEmprunt_button.Location = new System.Drawing.Point(850, 640);
            this.ValiderEmprunt_button.Margin = new System.Windows.Forms.Padding(8);
            this.ValiderEmprunt_button.Name = "ValiderEmprunt_button";
            this.ValiderEmprunt_button.Size = new System.Drawing.Size(101, 32);
            this.ValiderEmprunt_button.TabIndex = 62;
            this.ValiderEmprunt_button.Text = "Valider";
            this.ValiderEmprunt_button.UseVisualStyleBackColor = true;
            // 
            // EnregistrerUnRetour_tabPage
            // 
            this.EnregistrerUnRetour_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.RechercherEnregisterRetour_button);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.NomAdherentRetour_label);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.ResultatRetour_dataGridView);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.FiltreDeRechercheRetour_checkedListBox);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.RechercherRetour_textBox);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.BiblioFusion_label2);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.ValiderRetour_button);
            this.EnregistrerUnRetour_tabPage.Location = new System.Drawing.Point(4, 22);
            this.EnregistrerUnRetour_tabPage.Name = "EnregistrerUnRetour_tabPage";
            this.EnregistrerUnRetour_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnregistrerUnRetour_tabPage.Size = new System.Drawing.Size(997, 699);
            this.EnregistrerUnRetour_tabPage.TabIndex = 1;
            this.EnregistrerUnRetour_tabPage.Text = "Enregister un retour";
            // 
            // NomAdherentRetour_label
            // 
            this.NomAdherentRetour_label.AutoSize = true;
            this.NomAdherentRetour_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomAdherentRetour_label.Location = new System.Drawing.Point(650, 65);
            this.NomAdherentRetour_label.Name = "NomAdherentRetour_label";
            this.NomAdherentRetour_label.Size = new System.Drawing.Size(149, 25);
            this.NomAdherentRetour_label.TabIndex = 69;
            this.NomAdherentRetour_label.Text = "Nom Adherent";
            // 
            // ResultatRetour_dataGridView
            // 
            this.ResultatRetour_dataGridView.AllowUserToAddRows = false;
            this.ResultatRetour_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatRetour_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatRetour_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatRetour_dataGridView.Location = new System.Drawing.Point(350, 180);
            this.ResultatRetour_dataGridView.Name = "ResultatRetour_dataGridView";
            this.ResultatRetour_dataGridView.ReadOnly = true;
            this.ResultatRetour_dataGridView.Size = new System.Drawing.Size(620, 445);
            this.ResultatRetour_dataGridView.TabIndex = 67;
            // 
            // FiltreDeRechercheRetour_checkedListBox
            // 
            this.FiltreDeRechercheRetour_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltreDeRechercheRetour_checkedListBox.FormattingEnabled = true;
            this.FiltreDeRechercheRetour_checkedListBox.Location = new System.Drawing.Point(30, 180);
            this.FiltreDeRechercheRetour_checkedListBox.Name = "FiltreDeRechercheRetour_checkedListBox";
            this.FiltreDeRechercheRetour_checkedListBox.Size = new System.Drawing.Size(300, 445);
            this.FiltreDeRechercheRetour_checkedListBox.TabIndex = 66;
            // 
            // RechercherRetour_textBox
            // 
            this.RechercherRetour_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherRetour_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherRetour_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherRetour_textBox.Name = "RechercherRetour_textBox";
            this.RechercherRetour_textBox.Size = new System.Drawing.Size(694, 30);
            this.RechercherRetour_textBox.TabIndex = 65;
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
            this.BiblioFusion_label2.TabIndex = 64;
            this.BiblioFusion_label2.Text = "BiblioFusion";
            // 
            // ValiderRetour_button
            // 
            this.ValiderRetour_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderRetour_button.Location = new System.Drawing.Point(850, 640);
            this.ValiderRetour_button.Margin = new System.Windows.Forms.Padding(8);
            this.ValiderRetour_button.Name = "ValiderRetour_button";
            this.ValiderRetour_button.Size = new System.Drawing.Size(101, 32);
            this.ValiderRetour_button.TabIndex = 62;
            this.ValiderRetour_button.Text = "Valider";
            this.ValiderRetour_button.UseVisualStyleBackColor = true;
            // 
            // ReserverUnArticle_tabPage
            // 
            this.ReserverUnArticle_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReserverUnArticle_tabPage.Controls.Add(this.RechercherReserver_button);
            this.ReserverUnArticle_tabPage.Controls.Add(this.NomAdherentReserver_label);
            this.ReserverUnArticle_tabPage.Controls.Add(this.ResultatResever_dataGridView);
            this.ReserverUnArticle_tabPage.Controls.Add(this.FiltreDeRechercheReserver_checkedListBox);
            this.ReserverUnArticle_tabPage.Controls.Add(this.RechercherReserver_textBox);
            this.ReserverUnArticle_tabPage.Controls.Add(this.BiblioFusion_label3);
            this.ReserverUnArticle_tabPage.Controls.Add(this.ValiderReserver_button);
            this.ReserverUnArticle_tabPage.Location = new System.Drawing.Point(4, 22);
            this.ReserverUnArticle_tabPage.Name = "ReserverUnArticle_tabPage";
            this.ReserverUnArticle_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReserverUnArticle_tabPage.Size = new System.Drawing.Size(997, 699);
            this.ReserverUnArticle_tabPage.TabIndex = 2;
            this.ReserverUnArticle_tabPage.Text = "Reserver un article";
            // 
            // NomAdherentReserver_label
            // 
            this.NomAdherentReserver_label.AutoSize = true;
            this.NomAdherentReserver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.NomAdherentReserver_label.Location = new System.Drawing.Point(650, 65);
            this.NomAdherentReserver_label.Name = "NomAdherentReserver_label";
            this.NomAdherentReserver_label.Size = new System.Drawing.Size(149, 25);
            this.NomAdherentReserver_label.TabIndex = 69;
            this.NomAdherentReserver_label.Text = "Nom Adherent";
            // 
            // ResultatResever_dataGridView
            // 
            this.ResultatResever_dataGridView.AllowUserToAddRows = false;
            this.ResultatResever_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatResever_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatResever_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatResever_dataGridView.Location = new System.Drawing.Point(350, 180);
            this.ResultatResever_dataGridView.Name = "ResultatResever_dataGridView";
            this.ResultatResever_dataGridView.ReadOnly = true;
            this.ResultatResever_dataGridView.Size = new System.Drawing.Size(620, 445);
            this.ResultatResever_dataGridView.TabIndex = 67;
            // 
            // FiltreDeRechercheReserver_checkedListBox
            // 
            this.FiltreDeRechercheReserver_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltreDeRechercheReserver_checkedListBox.FormattingEnabled = true;
            this.FiltreDeRechercheReserver_checkedListBox.Location = new System.Drawing.Point(30, 180);
            this.FiltreDeRechercheReserver_checkedListBox.Name = "FiltreDeRechercheReserver_checkedListBox";
            this.FiltreDeRechercheReserver_checkedListBox.Size = new System.Drawing.Size(300, 445);
            this.FiltreDeRechercheReserver_checkedListBox.TabIndex = 66;
            // 
            // RechercherReserver_textBox
            // 
            this.RechercherReserver_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherReserver_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherReserver_textBox.Location = new System.Drawing.Point(125, 115);
            this.RechercherReserver_textBox.Name = "RechercherReserver_textBox";
            this.RechercherReserver_textBox.Size = new System.Drawing.Size(694, 30);
            this.RechercherReserver_textBox.TabIndex = 65;
            // 
            // BiblioFusion_label3
            // 
            this.BiblioFusion_label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BiblioFusion_label3.AutoSize = true;
            this.BiblioFusion_label3.Font = new System.Drawing.Font("Impact", 25F);
            this.BiblioFusion_label3.Location = new System.Drawing.Point(400, 35);
            this.BiblioFusion_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BiblioFusion_label3.Name = "BiblioFusion_label3";
            this.BiblioFusion_label3.Size = new System.Drawing.Size(191, 42);
            this.BiblioFusion_label3.TabIndex = 64;
            this.BiblioFusion_label3.Text = "BiblioFusion";
            // 
            // ValiderReserver_button
            // 
            this.ValiderReserver_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderReserver_button.Location = new System.Drawing.Point(850, 640);
            this.ValiderReserver_button.Margin = new System.Windows.Forms.Padding(8);
            this.ValiderReserver_button.Name = "ValiderReserver_button";
            this.ValiderReserver_button.Size = new System.Drawing.Size(101, 32);
            this.ValiderReserver_button.TabIndex = 62;
            this.ValiderReserver_button.Text = "Valider";
            this.ValiderReserver_button.UseVisualStyleBackColor = true;
            // 
            // RechercherNouvelEmprunt_button
            // 
            this.RechercherNouvelEmprunt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.RechercherNouvelEmprunt_button.Location = new System.Drawing.Point(830, 115);
            this.RechercherNouvelEmprunt_button.Margin = new System.Windows.Forms.Padding(8);
            this.RechercherNouvelEmprunt_button.Name = "RechercherNouvelEmprunt_button";
            this.RechercherNouvelEmprunt_button.Size = new System.Drawing.Size(140, 32);
            this.RechercherNouvelEmprunt_button.TabIndex = 69;
            this.RechercherNouvelEmprunt_button.Text = "Rechercher";
            this.RechercherNouvelEmprunt_button.UseVisualStyleBackColor = true;
            // 
            // RechercherEnregisterRetour_button
            // 
            this.RechercherEnregisterRetour_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.RechercherEnregisterRetour_button.Location = new System.Drawing.Point(830, 115);
            this.RechercherEnregisterRetour_button.Margin = new System.Windows.Forms.Padding(8);
            this.RechercherEnregisterRetour_button.Name = "RechercherEnregisterRetour_button";
            this.RechercherEnregisterRetour_button.Size = new System.Drawing.Size(140, 32);
            this.RechercherEnregisterRetour_button.TabIndex = 70;
            this.RechercherEnregisterRetour_button.Text = "Rechercher";
            this.RechercherEnregisterRetour_button.UseVisualStyleBackColor = true;
            // 
            // RechercherReserver_button
            // 
            this.RechercherReserver_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.RechercherReserver_button.Location = new System.Drawing.Point(830, 115);
            this.RechercherReserver_button.Margin = new System.Windows.Forms.Padding(8);
            this.RechercherReserver_button.Name = "RechercherReserver_button";
            this.RechercherReserver_button.Size = new System.Drawing.Size(140, 32);
            this.RechercherReserver_button.TabIndex = 70;
            this.RechercherReserver_button.Text = "Rechercher";
            this.RechercherReserver_button.UseVisualStyleBackColor = true;
            // 
            // Form_Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.Emprunts_tabControl);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_Emprunts";
            this.Text = "BiblioFusion - emprunts";
            this.Emprunts_tabControl.ResumeLayout(false);
            this.NouvelEmprunt_tabPage.ResumeLayout(false);
            this.NouvelEmprunt_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatEmprunt_dataGridView)).EndInit();
            this.EnregistrerUnRetour_tabPage.ResumeLayout(false);
            this.EnregistrerUnRetour_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatRetour_dataGridView)).EndInit();
            this.ReserverUnArticle_tabPage.ResumeLayout(false);
            this.ReserverUnArticle_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatResever_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Emprunts_tabControl;
        private System.Windows.Forms.TabPage NouvelEmprunt_tabPage;
        private System.Windows.Forms.TabPage EnregistrerUnRetour_tabPage;
        private System.Windows.Forms.TabPage ReserverUnArticle_tabPage;
        private System.Windows.Forms.CheckedListBox FiltreDeRechercheRetour_checkedListBox;
        private System.Windows.Forms.TextBox RechercherRetour_textBox;
        private System.Windows.Forms.Label BiblioFusion_label2;
        private System.Windows.Forms.Button ValiderRetour_button;
        private System.Windows.Forms.CheckedListBox FiltreDeRechercheReserver_checkedListBox;
        private System.Windows.Forms.TextBox RechercherReserver_textBox;
        private System.Windows.Forms.Label BiblioFusion_label3;
        private System.Windows.Forms.Button ValiderReserver_button;
        private System.Windows.Forms.CheckedListBox FiltreDeRechercheEmprunt_checkedListBox;
        private System.Windows.Forms.TextBox RechercherEmprunt_textBox;
        private System.Windows.Forms.Label BiblioFusion_label1;
        private System.Windows.Forms.Button ValiderEmprunt_button;
        private System.Windows.Forms.DataGridView ResultatEmprunt_dataGridView;
        private System.Windows.Forms.DataGridView ResultatRetour_dataGridView;
        private System.Windows.Forms.DataGridView ResultatResever_dataGridView;
        private System.Windows.Forms.Label NomAdherentEmprunt_label;
        private System.Windows.Forms.Label NomAdherentRetour_label;
        private System.Windows.Forms.Label NomAdherentReserver_label;
        private System.Windows.Forms.Button RechercherNouvelEmprunt_button;
        private System.Windows.Forms.Button RechercherEnregisterRetour_button;
        private System.Windows.Forms.Button RechercherReserver_button;
    }
}