namespace Bibliofusion_prototype
{
    partial class Form_Categories
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Connexion = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Liste_des_Categories_Livres = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.Liste_des_Categories_Jouets = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.vScrollBar2);
            this.tabPage2.Controls.Add(this.Liste_des_Categories_Jouets);
            this.tabPage2.Controls.Add(this.vScrollBar1);
            this.tabPage2.Controls.Add(this.Liste_des_Categories_Livres);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.Title);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editer les catégories";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.button1.Location = new System.Drawing.Point(866, 636);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 38;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.Connexion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter une catégorie";
            // 
            // Connexion
            // 
            this.Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Connexion.Location = new System.Drawing.Point(806, 549);
            this.Connexion.Margin = new System.Windows.Forms.Padding(8);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(101, 32);
            this.Connexion.TabIndex = 29;
            this.Connexion.Text = "Valider";
            this.Connexion.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 725);
            this.tabControl1.TabIndex = 31;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 25F);
            this.Title.Location = new System.Drawing.Point(395, 81);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(191, 42);
            this.Title.TabIndex = 51;
            this.Title.Text = "BiblioFusion";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox1.Location = new System.Drawing.Point(120, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(754, 30);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "Rechercher une catégorie";
            // 
            // Liste_des_Categories_Livres
            // 
            this.Liste_des_Categories_Livres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Liste_des_Categories_Livres.FormattingEnabled = true;
            this.Liste_des_Categories_Livres.ItemHeight = 25;
            this.Liste_des_Categories_Livres.Location = new System.Drawing.Point(503, 187);
            this.Liste_des_Categories_Livres.Name = "Liste_des_Categories_Livres";
            this.Liste_des_Categories_Livres.Size = new System.Drawing.Size(466, 429);
            this.Liste_des_Categories_Livres.TabIndex = 53;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(951, 187);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 430);
            this.vScrollBar1.TabIndex = 54;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(479, 187);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 430);
            this.vScrollBar2.TabIndex = 56;
            // 
            // Liste_des_Categories_Jouets
            // 
            this.Liste_des_Categories_Jouets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Liste_des_Categories_Jouets.FormattingEnabled = true;
            this.Liste_des_Categories_Jouets.ItemHeight = 25;
            this.Liste_des_Categories_Jouets.Location = new System.Drawing.Point(31, 187);
            this.Liste_des_Categories_Jouets.Name = "Liste_des_Categories_Jouets";
            this.Liste_des_Categories_Jouets.Size = new System.Drawing.Size(466, 429);
            this.Liste_des_Categories_Jouets.TabIndex = 55;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox4.Location = new System.Drawing.Point(16, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(964, 30);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "Nom de la Catégorie";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.checkBox1.Location = new System.Drawing.Point(146, 276);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 26);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Jouet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.checkBox2.Location = new System.Drawing.Point(16, 276);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 26);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Livre";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25F);
            this.label1.Location = new System.Drawing.Point(402, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 52;
            this.label1.Text = "BiblioFusion";
            // 
            // Form_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form_Categories";
            this.Text = "BiblioFusion - Catégories";
            this.Load += new System.EventHandler(this.Form_Categories_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.ListBox Liste_des_Categories_Jouets;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox Liste_des_Categories_Livres;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}