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
            this.EditAdmin_tabPage = new System.Windows.Forms.TabPage();
            this.ResultatAdmin_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltresDeRechercheAdmin_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherAdmin_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label2 = new System.Windows.Forms.Label();
            this.AjoutAdmin_tabPage = new System.Windows.Forms.TabPage();
            this.CodePostalAdmin_textBox = new System.Windows.Forms.TextBox();
            this.NaissanceAdmin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ValiderAjoutAdmin_button = new System.Windows.Forms.Button();
            this.NomAdmin_textBox = new System.Windows.Forms.TextBox();
            this.MobileAdmin_textBox = new System.Windows.Forms.TextBox();
            this.AdresseAdmin_textBox = new System.Windows.Forms.TextBox();
            this.PrenomAdmin_textBox = new System.Windows.Forms.TextBox();
            this.EmailAdmin_textBox = new System.Windows.Forms.TextBox();
            this.FixeAdmin_textBox = new System.Windows.Forms.TextBox();
            this.BiblioFusion_label1 = new System.Windows.Forms.Label();
            this.Admin_tabControl = new System.Windows.Forms.TabControl();
            this.EditAdmin_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatAdmin_dataGridView)).BeginInit();
            this.AjoutAdmin_tabPage.SuspendLayout();
            this.Admin_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditAdmin_tabPage
            // 
            this.EditAdmin_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditAdmin_tabPage.Controls.Add(this.ResultatAdmin_dataGridView);
            this.EditAdmin_tabPage.Controls.Add(this.FiltresDeRechercheAdmin_checkedListBox);
            this.EditAdmin_tabPage.Controls.Add(this.RechercherAdmin_textBox);
            this.EditAdmin_tabPage.Controls.Add(this.BiblioFusion_label2);
            this.EditAdmin_tabPage.Location = new System.Drawing.Point(4, 22);
            this.EditAdmin_tabPage.Name = "EditAdmin_tabPage";
            this.EditAdmin_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditAdmin_tabPage.Size = new System.Drawing.Size(996, 699);
            this.EditAdmin_tabPage.TabIndex = 1;
            this.EditAdmin_tabPage.Text = "Editer les administrateurs";
            // 
            // ResultatAdmin_dataGridView
            // 
            this.ResultatAdmin_dataGridView.AllowUserToAddRows = false;
            this.ResultatAdmin_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatAdmin_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatAdmin_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatAdmin_dataGridView.Location = new System.Drawing.Point(350, 180);
            this.ResultatAdmin_dataGridView.Name = "ResultatAdmin_dataGridView";
            this.ResultatAdmin_dataGridView.ReadOnly = true;
            this.ResultatAdmin_dataGridView.Size = new System.Drawing.Size(620, 444);
            this.ResultatAdmin_dataGridView.TabIndex = 60;
            // 
            // FiltresDeRechercheAdmin_checkedListBox
            // 
            this.FiltresDeRechercheAdmin_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltresDeRechercheAdmin_checkedListBox.FormattingEnabled = true;
            this.FiltresDeRechercheAdmin_checkedListBox.Location = new System.Drawing.Point(30, 180);
            this.FiltresDeRechercheAdmin_checkedListBox.Name = "FiltresDeRechercheAdmin_checkedListBox";
            this.FiltresDeRechercheAdmin_checkedListBox.Size = new System.Drawing.Size(300, 445);
            this.FiltresDeRechercheAdmin_checkedListBox.TabIndex = 55;
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
            // AjoutAdmin_tabPage
            // 
            this.AjoutAdmin_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AjoutAdmin_tabPage.Controls.Add(this.CodePostalAdmin_textBox);
            this.AjoutAdmin_tabPage.Controls.Add(this.NaissanceAdmin_dateTimePicker);
            this.AjoutAdmin_tabPage.Controls.Add(this.ValiderAjoutAdmin_button);
            this.AjoutAdmin_tabPage.Controls.Add(this.NomAdmin_textBox);
            this.AjoutAdmin_tabPage.Controls.Add(this.MobileAdmin_textBox);
            this.AjoutAdmin_tabPage.Controls.Add(this.AdresseAdmin_textBox);
            this.AjoutAdmin_tabPage.Controls.Add(this.PrenomAdmin_textBox);
            this.AjoutAdmin_tabPage.Controls.Add(this.EmailAdmin_textBox);
            this.AjoutAdmin_tabPage.Controls.Add(this.FixeAdmin_textBox);
            this.AjoutAdmin_tabPage.Controls.Add(this.BiblioFusion_label1);
            this.AjoutAdmin_tabPage.Location = new System.Drawing.Point(4, 22);
            this.AjoutAdmin_tabPage.Name = "AjoutAdmin_tabPage";
            this.AjoutAdmin_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AjoutAdmin_tabPage.Size = new System.Drawing.Size(996, 699);
            this.AjoutAdmin_tabPage.TabIndex = 0;
            this.AjoutAdmin_tabPage.Text = "Ajouter un administrateur";
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
            // ValiderAjoutAdmin_button
            // 
            this.ValiderAjoutAdmin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.ValiderAjoutAdmin_button.Location = new System.Drawing.Point(850, 515);
            this.ValiderAjoutAdmin_button.Margin = new System.Windows.Forms.Padding(8);
            this.ValiderAjoutAdmin_button.Name = "ValiderAjoutAdmin_button";
            this.ValiderAjoutAdmin_button.Size = new System.Drawing.Size(101, 32);
            this.ValiderAjoutAdmin_button.TabIndex = 40;
            this.ValiderAjoutAdmin_button.Text = "Valider";
            this.ValiderAjoutAdmin_button.UseVisualStyleBackColor = true;
            this.ValiderAjoutAdmin_button.Click += new System.EventHandler(this.ValiderAjoutAdmin_button_Click);
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
            // Admin_tabControl
            // 
            this.Admin_tabControl.Controls.Add(this.AjoutAdmin_tabPage);
            this.Admin_tabControl.Controls.Add(this.EditAdmin_tabPage);
            this.Admin_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Admin_tabControl.Name = "Admin_tabControl";
            this.Admin_tabControl.SelectedIndex = 0;
            this.Admin_tabControl.Size = new System.Drawing.Size(1004, 725);
            this.Admin_tabControl.TabIndex = 1;
            // 
            // Form_Administrateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.Admin_tabControl);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_Administrateurs";
            this.Text = "BiblioFusion - administrateurs";
            this.EditAdmin_tabPage.ResumeLayout(false);
            this.EditAdmin_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatAdmin_dataGridView)).EndInit();
            this.AjoutAdmin_tabPage.ResumeLayout(false);
            this.AjoutAdmin_tabPage.PerformLayout();
            this.Admin_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EditAdmin_tabPage;
        private System.Windows.Forms.CheckedListBox FiltresDeRechercheAdmin_checkedListBox;
        private System.Windows.Forms.TextBox RechercherAdmin_textBox;
        private System.Windows.Forms.Label BiblioFusion_label2;
        private System.Windows.Forms.TabPage AjoutAdmin_tabPage;
        private System.Windows.Forms.Button ValiderAjoutAdmin_button;
        private System.Windows.Forms.TextBox NomAdmin_textBox;
        private System.Windows.Forms.TextBox MobileAdmin_textBox;
        private System.Windows.Forms.TextBox AdresseAdmin_textBox;
        private System.Windows.Forms.TextBox PrenomAdmin_textBox;
        private System.Windows.Forms.TextBox EmailAdmin_textBox;
        private System.Windows.Forms.TextBox FixeAdmin_textBox;
        private System.Windows.Forms.Label BiblioFusion_label1;
        private System.Windows.Forms.TabControl Admin_tabControl;
        private System.Windows.Forms.DateTimePicker NaissanceAdmin_dateTimePicker;
        private System.Windows.Forms.DataGridView ResultatAdmin_dataGridView;
        private System.Windows.Forms.TextBox CodePostalAdmin_textBox;
    }
}