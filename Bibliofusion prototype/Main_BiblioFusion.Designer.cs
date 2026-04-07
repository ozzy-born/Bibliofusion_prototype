namespace Bibliofusion_prototype
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregisterUnRetourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserverUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jouetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Filtres_de_Recherche = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.descriptf = new System.Windows.Forms.ListBox();
            this.chaine_de_caracter = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empruntsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelEmpruntToolStripMenuItem,
            this.enregisterUnRetourToolStripMenuItem,
            this.reserverUnArticleToolStripMenuItem});
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.empruntsToolStripMenuItem.Text = "Emprunts";
            // 
            // nouvelEmpruntToolStripMenuItem
            // 
            this.nouvelEmpruntToolStripMenuItem.Name = "nouvelEmpruntToolStripMenuItem";
            this.nouvelEmpruntToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nouvelEmpruntToolStripMenuItem.Text = "Nouvel emprunt";
            this.nouvelEmpruntToolStripMenuItem.Click += new System.EventHandler(this.NouvelEmpruntToolStripMenuItem_Click);
            // 
            // enregisterUnRetourToolStripMenuItem
            // 
            this.enregisterUnRetourToolStripMenuItem.Name = "enregisterUnRetourToolStripMenuItem";
            this.enregisterUnRetourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enregisterUnRetourToolStripMenuItem.Text = "Enregister un retour";
            this.enregisterUnRetourToolStripMenuItem.Click += new System.EventHandler(this.enregisterUnRetourToolStripMenuItem_Click);
            // 
            // reserverUnArticleToolStripMenuItem
            // 
            this.reserverUnArticleToolStripMenuItem.Name = "reserverUnArticleToolStripMenuItem";
            this.reserverUnArticleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reserverUnArticleToolStripMenuItem.Text = "Reserver un article";
            this.reserverUnArticleToolStripMenuItem.Click += new System.EventHandler(this.reserverUnArticleToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livreToolStripMenuItem,
            this.jouetToolStripMenuItem,
            this.catégoriesToolStripMenuItem,
            this.adhérantToolStripMenuItem,
            this.classesToolStripMenuItem,
            this.administateursToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.livreToolStripMenuItem.Text = "Livres";
            this.livreToolStripMenuItem.Click += new System.EventHandler(this.LivreToolStripMenuItem_Click);
            // 
            // jouetToolStripMenuItem
            // 
            this.jouetToolStripMenuItem.Name = "jouetToolStripMenuItem";
            this.jouetToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jouetToolStripMenuItem.Text = "Jouets";
            this.jouetToolStripMenuItem.Click += new System.EventHandler(this.JouetToolStripMenuItem_Click);
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            this.catégoriesToolStripMenuItem.Click += new System.EventHandler(this.CategoriesToolStripMenuItem_Click);
            // 
            // adhérantToolStripMenuItem
            // 
            this.adhérantToolStripMenuItem.Name = "adhérantToolStripMenuItem";
            this.adhérantToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.adhérantToolStripMenuItem.Text = "Adhérents";
            this.adhérantToolStripMenuItem.Click += new System.EventHandler(this.AdherantToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.ClassesToolStripMenuItem_Click);
            // 
            // administateursToolStripMenuItem
            // 
            this.administateursToolStripMenuItem.Name = "administateursToolStripMenuItem";
            this.administateursToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.administateursToolStripMenuItem.Text = "Administateurs";
            this.administateursToolStripMenuItem.Click += new System.EventHandler(this.AdministateursToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.DeconnexionToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 703);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(999, 677);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tableau de Bord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reservations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Retours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Retards";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.Filtres_de_Recherche);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(999, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rechercher";
            // 
            // Filtres_de_Recherche
            // 
            this.Filtres_de_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Filtres_de_Recherche.FormattingEnabled = true;
            this.Filtres_de_Recherche.Location = new System.Drawing.Point(30, 100);
            this.Filtres_de_Recherche.Name = "Filtres_de_Recherche";
            this.Filtres_de_Recherche.Size = new System.Drawing.Size(300, 550);
            this.Filtres_de_Recherche.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.textBox1.Location = new System.Drawing.Point(125, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 30);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "Rechercher un livre, un jouet ou un adherant";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.descriptf);
            this.tabPage3.Controls.Add(this.chaine_de_caracter);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(999, 677);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scanner";
            // 
            // descriptf
            // 
            this.descriptf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.descriptf.FormattingEnabled = true;
            this.descriptf.ItemHeight = 25;
            this.descriptf.Location = new System.Drawing.Point(210, 241);
            this.descriptf.Name = "descriptf";
            this.descriptf.Size = new System.Drawing.Size(589, 204);
            this.descriptf.TabIndex = 55;
            // 
            // chaine_de_caracter
            // 
            this.chaine_de_caracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.chaine_de_caracter.FormattingEnabled = true;
            this.chaine_de_caracter.ItemHeight = 25;
            this.chaine_de_caracter.Location = new System.Drawing.Point(201, 39);
            this.chaine_de_caracter.Name = "chaine_de_caracter";
            this.chaine_de_caracter.Size = new System.Drawing.Size(589, 104);
            this.chaine_de_caracter.TabIndex = 54;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(999, 677);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistiques";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Statistiques 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Statistiques 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Statistiques 1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(620, 550);
            this.dataGridView1.TabIndex = 68;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(300, 550);
            this.dataGridView2.TabIndex = 69;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(350, 100);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(300, 550);
            this.dataGridView3.TabIndex = 70;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(670, 100);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(300, 550);
            this.dataGridView4.TabIndex = 71;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "MainForm";
            this.Text = "BiblioFusion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem adhérantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administateursToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem jouetToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox Filtres_de_Recherche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox descriptf;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ListBox chaine_de_caracter;
        private System.Windows.Forms.ToolStripMenuItem nouvelEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregisterUnRetourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserverUnArticleToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

