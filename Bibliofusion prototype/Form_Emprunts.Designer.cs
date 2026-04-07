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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filtre_recherche = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Connexion = new System.Windows.Forms.Button();
            this.EnregistrerUnRetour_tabPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReserverUnArticle_tabPage = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Emprunts_tabControl.SuspendLayout();
            this.NouvelEmprunt_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.EnregistrerUnRetour_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ReserverUnArticle_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Emprunts_tabControl
            // 
            this.Emprunts_tabControl.Controls.Add(this.NouvelEmprunt_tabPage);
            this.Emprunts_tabControl.Controls.Add(this.EnregistrerUnRetour_tabPage);
            this.Emprunts_tabControl.Controls.Add(this.ReserverUnArticle_tabPage);
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
            this.NouvelEmprunt_tabPage.Controls.Add(this.dataGridView1);
            this.NouvelEmprunt_tabPage.Controls.Add(this.filtre_recherche);
            this.NouvelEmprunt_tabPage.Controls.Add(this.textBox2);
            this.NouvelEmprunt_tabPage.Controls.Add(this.label1);
            this.NouvelEmprunt_tabPage.Controls.Add(this.textBox8);
            this.NouvelEmprunt_tabPage.Controls.Add(this.Connexion);
            this.NouvelEmprunt_tabPage.Location = new System.Drawing.Point(4, 22);
            this.NouvelEmprunt_tabPage.Name = "NouvelEmprunt_tabPage";
            this.NouvelEmprunt_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NouvelEmprunt_tabPage.Size = new System.Drawing.Size(997, 699);
            this.NouvelEmprunt_tabPage.TabIndex = 0;
            this.NouvelEmprunt_tabPage.Text = "Nouvel emprunt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(620, 444);
            this.dataGridView1.TabIndex = 67;
            // 
            // filtre_recherche
            // 
            this.filtre_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.filtre_recherche.FormattingEnabled = true;
            this.filtre_recherche.Location = new System.Drawing.Point(30, 180);
            this.filtre_recherche.Name = "filtre_recherche";
            this.filtre_recherche.Size = new System.Drawing.Size(300, 445);
            this.filtre_recherche.TabIndex = 66;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox2.Location = new System.Drawing.Point(125, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(750, 30);
            this.textBox2.TabIndex = 65;
            this.textBox2.Text = "Rechercher un livre ou un jouet";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25F);
            this.label1.Location = new System.Drawing.Point(400, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 64;
            this.label1.Text = "BiblioFusion";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox8.Location = new System.Drawing.Point(650, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(320, 30);
            this.textBox8.TabIndex = 63;
            this.textBox8.Text = "Adhérant";
            // 
            // Connexion
            // 
            this.Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Connexion.Location = new System.Drawing.Point(850, 640);
            this.Connexion.Margin = new System.Windows.Forms.Padding(8);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(101, 32);
            this.Connexion.TabIndex = 62;
            this.Connexion.Text = "Valider";
            this.Connexion.UseVisualStyleBackColor = true;
            // 
            // EnregistrerUnRetour_tabPage
            // 
            this.EnregistrerUnRetour_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.dataGridView2);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.checkedListBox2);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.textBox1);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.label2);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.textBox3);
            this.EnregistrerUnRetour_tabPage.Controls.Add(this.button1);
            this.EnregistrerUnRetour_tabPage.Location = new System.Drawing.Point(4, 22);
            this.EnregistrerUnRetour_tabPage.Name = "EnregistrerUnRetour_tabPage";
            this.EnregistrerUnRetour_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnregistrerUnRetour_tabPage.Size = new System.Drawing.Size(997, 699);
            this.EnregistrerUnRetour_tabPage.TabIndex = 1;
            this.EnregistrerUnRetour_tabPage.Text = "Enregister un retour";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(350, 181);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(620, 444);
            this.dataGridView2.TabIndex = 67;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(30, 180);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(300, 445);
            this.checkedListBox2.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox1.Location = new System.Drawing.Point(125, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 30);
            this.textBox1.TabIndex = 65;
            this.textBox1.Text = "Rechercher un livre ou un jouet";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 25F);
            this.label2.Location = new System.Drawing.Point(400, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 42);
            this.label2.TabIndex = 64;
            this.label2.Text = "BiblioFusion";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox3.Location = new System.Drawing.Point(650, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(320, 30);
            this.textBox3.TabIndex = 63;
            this.textBox3.Text = "Adhérant";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.button1.Location = new System.Drawing.Point(850, 640);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 62;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReserverUnArticle_tabPage
            // 
            this.ReserverUnArticle_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReserverUnArticle_tabPage.Controls.Add(this.dataGridView3);
            this.ReserverUnArticle_tabPage.Controls.Add(this.checkedListBox4);
            this.ReserverUnArticle_tabPage.Controls.Add(this.textBox4);
            this.ReserverUnArticle_tabPage.Controls.Add(this.label3);
            this.ReserverUnArticle_tabPage.Controls.Add(this.textBox5);
            this.ReserverUnArticle_tabPage.Controls.Add(this.button2);
            this.ReserverUnArticle_tabPage.Location = new System.Drawing.Point(4, 22);
            this.ReserverUnArticle_tabPage.Name = "ReserverUnArticle_tabPage";
            this.ReserverUnArticle_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReserverUnArticle_tabPage.Size = new System.Drawing.Size(997, 699);
            this.ReserverUnArticle_tabPage.TabIndex = 2;
            this.ReserverUnArticle_tabPage.Text = "Reserver un article";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(350, 180);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(620, 444);
            this.dataGridView3.TabIndex = 67;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Location = new System.Drawing.Point(30, 180);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(300, 445);
            this.checkedListBox4.TabIndex = 66;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox4.Location = new System.Drawing.Point(125, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(750, 30);
            this.textBox4.TabIndex = 65;
            this.textBox4.Text = "Rechercher un livre ou un jouet";
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
            this.label3.TabIndex = 64;
            this.label3.Text = "BiblioFusion";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox5.Location = new System.Drawing.Point(650, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(320, 30);
            this.textBox5.TabIndex = 63;
            this.textBox5.Text = "Adhérant";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.button2.Location = new System.Drawing.Point(850, 640);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 62;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.EnregistrerUnRetour_tabPage.ResumeLayout(false);
            this.EnregistrerUnRetour_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ReserverUnArticle_tabPage.ResumeLayout(false);
            this.ReserverUnArticle_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Emprunts_tabControl;
        private System.Windows.Forms.TabPage NouvelEmprunt_tabPage;
        private System.Windows.Forms.TabPage EnregistrerUnRetour_tabPage;
        private System.Windows.Forms.TabPage ReserverUnArticle_tabPage;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox filtre_recherche;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}