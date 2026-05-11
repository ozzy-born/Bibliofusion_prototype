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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Emprunts_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NouvelEmprunt_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnregisterRetour_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReserverArticle_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Options_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Livres_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Jouets_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Categories_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Adherents_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Classes_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Administateurs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeQR_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Deconnexion_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_tabControl = new System.Windows.Forms.TabControl();
            this.TabDeBord_tabPage = new System.Windows.Forms.TabPage();
            this.Reservations_dataGridView = new System.Windows.Forms.DataGridView();
            this.Retours_dataGridView = new System.Windows.Forms.DataGridView();
            this.Retards_dataGridView = new System.Windows.Forms.DataGridView();
            this.Reservations_label = new System.Windows.Forms.Label();
            this.Retours_label = new System.Windows.Forms.Label();
            this.Retards_label = new System.Windows.Forms.Label();
            this.MainRechercher_tabPage = new System.Windows.Forms.TabPage();
            this.ResultatMain_dataGridView = new System.Windows.Forms.DataGridView();
            this.FiltresDeRechercheMain_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.RechercherMain_textBox = new System.Windows.Forms.TextBox();
            this.MainScanner_tabPage = new System.Windows.Forms.TabPage();
            this.descriptf = new System.Windows.Forms.ListBox();
            this.chaine_de_caracter = new System.Windows.Forms.ListBox();
            this.MainStat_tabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Main_menuStrip.SuspendLayout();
            this.Main_tabControl.SuspendLayout();
            this.TabDeBord_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservations_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retours_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retards_dataGridView)).BeginInit();
            this.MainRechercher_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatMain_dataGridView)).BeginInit();
            this.MainScanner_tabPage.SuspendLayout();
            this.MainStat_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_menuStrip
            // 
            this.Main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Emprunts_ToolStripMenuItem,
            this.Options_ToolStripMenuItem,
            this.Deconnexion_ToolStripMenuItem});
            this.Main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Main_menuStrip.Name = "Main_menuStrip";
            this.Main_menuStrip.Size = new System.Drawing.Size(1007, 24);
            this.Main_menuStrip.TabIndex = 0;
            this.Main_menuStrip.Text = "menuStrip1";
            // 
            // Emprunts_ToolStripMenuItem
            // 
            this.Emprunts_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NouvelEmprunt_ToolStripMenuItem,
            this.EnregisterRetour_ToolStripMenuItem,
            this.ReserverArticle_ToolStripMenuItem});
            this.Emprunts_ToolStripMenuItem.Name = "Emprunts_ToolStripMenuItem";
            this.Emprunts_ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.Emprunts_ToolStripMenuItem.Text = "Emprunts";
            // 
            // NouvelEmprunt_ToolStripMenuItem
            // 
            this.NouvelEmprunt_ToolStripMenuItem.Name = "NouvelEmprunt_ToolStripMenuItem";
            this.NouvelEmprunt_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.NouvelEmprunt_ToolStripMenuItem.Text = "Nouvel emprunt";
            this.NouvelEmprunt_ToolStripMenuItem.Click += new System.EventHandler(this.NouvelEmpruntToolStripMenuItem_Click);
            // 
            // EnregisterRetour_ToolStripMenuItem
            // 
            this.EnregisterRetour_ToolStripMenuItem.Name = "EnregisterRetour_ToolStripMenuItem";
            this.EnregisterRetour_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.EnregisterRetour_ToolStripMenuItem.Text = "Enregister un retour";
            this.EnregisterRetour_ToolStripMenuItem.Click += new System.EventHandler(this.enregisterUnRetourToolStripMenuItem_Click);
            // 
            // ReserverArticle_ToolStripMenuItem
            // 
            this.ReserverArticle_ToolStripMenuItem.Name = "ReserverArticle_ToolStripMenuItem";
            this.ReserverArticle_ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ReserverArticle_ToolStripMenuItem.Text = "Reserver un article";
            this.ReserverArticle_ToolStripMenuItem.Click += new System.EventHandler(this.reserverUnArticleToolStripMenuItem_Click);
            // 
            // Options_ToolStripMenuItem
            // 
            this.Options_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Livres_ToolStripMenuItem,
            this.Jouets_ToolStripMenuItem,
            this.Categories_ToolStripMenuItem,
            this.Adherents_ToolStripMenuItem,
            this.Classes_ToolStripMenuItem,
            this.Administateurs_ToolStripMenuItem,
            this.CodeQR_ToolStripMenuItem});
            this.Options_ToolStripMenuItem.Name = "Options_ToolStripMenuItem";
            this.Options_ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.Options_ToolStripMenuItem.Text = "Options";
            // 
            // Livres_ToolStripMenuItem
            // 
            this.Livres_ToolStripMenuItem.Name = "Livres_ToolStripMenuItem";
            this.Livres_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Livres_ToolStripMenuItem.Text = "Livres";
            this.Livres_ToolStripMenuItem.Click += new System.EventHandler(this.LivreToolStripMenuItem_Click);
            // 
            // Jouets_ToolStripMenuItem
            // 
            this.Jouets_ToolStripMenuItem.Name = "Jouets_ToolStripMenuItem";
            this.Jouets_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Jouets_ToolStripMenuItem.Text = "Jouets";
            this.Jouets_ToolStripMenuItem.Click += new System.EventHandler(this.JouetToolStripMenuItem_Click);
            // 
            // Categories_ToolStripMenuItem
            // 
            this.Categories_ToolStripMenuItem.Name = "Categories_ToolStripMenuItem";
            this.Categories_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Categories_ToolStripMenuItem.Text = "Catégories";
            this.Categories_ToolStripMenuItem.Click += new System.EventHandler(this.CategoriesToolStripMenuItem_Click);
            // 
            // Adherents_ToolStripMenuItem
            // 
            this.Adherents_ToolStripMenuItem.Name = "Adherents_ToolStripMenuItem";
            this.Adherents_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Adherents_ToolStripMenuItem.Text = "Adhérents";
            this.Adherents_ToolStripMenuItem.Click += new System.EventHandler(this.AdherantToolStripMenuItem_Click);
            // 
            // Classes_ToolStripMenuItem
            // 
            this.Classes_ToolStripMenuItem.Name = "Classes_ToolStripMenuItem";
            this.Classes_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Classes_ToolStripMenuItem.Text = "Classes";
            this.Classes_ToolStripMenuItem.Click += new System.EventHandler(this.ClassesToolStripMenuItem_Click);
            // 
            // Administateurs_ToolStripMenuItem
            // 
            this.Administateurs_ToolStripMenuItem.Name = "Administateurs_ToolStripMenuItem";
            this.Administateurs_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Administateurs_ToolStripMenuItem.Text = "Administateurs";
            this.Administateurs_ToolStripMenuItem.Click += new System.EventHandler(this.AdministateursToolStripMenuItem_Click);
            // 
            // CodeQR_ToolStripMenuItem
            // 
            this.CodeQR_ToolStripMenuItem.Name = "CodeQR_ToolStripMenuItem";
            this.CodeQR_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.CodeQR_ToolStripMenuItem.Text = "CodeQR";
            this.CodeQR_ToolStripMenuItem.Click += new System.EventHandler(this.qRCodeToolStripMenuItem_Click);
            // 
            // Deconnexion_ToolStripMenuItem
            // 
            this.Deconnexion_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Deconnexion_ToolStripMenuItem.Name = "Deconnexion_ToolStripMenuItem";
            this.Deconnexion_ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.Deconnexion_ToolStripMenuItem.Text = "Déconnexion";
            this.Deconnexion_ToolStripMenuItem.Click += new System.EventHandler(this.DeconnexionToolStripMenuItem_Click);
            // 
            // Main_tabControl
            // 
            this.Main_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_tabControl.Controls.Add(this.TabDeBord_tabPage);
            this.Main_tabControl.Controls.Add(this.MainRechercher_tabPage);
            this.Main_tabControl.Controls.Add(this.MainScanner_tabPage);
            this.Main_tabControl.Controls.Add(this.MainStat_tabPage);
            this.Main_tabControl.Location = new System.Drawing.Point(0, 27);
            this.Main_tabControl.Name = "Main_tabControl";
            this.Main_tabControl.SelectedIndex = 0;
            this.Main_tabControl.Size = new System.Drawing.Size(1007, 703);
            this.Main_tabControl.TabIndex = 1;
            // 
            // TabDeBord_tabPage
            // 
            this.TabDeBord_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabDeBord_tabPage.Controls.Add(this.Reservations_dataGridView);
            this.TabDeBord_tabPage.Controls.Add(this.Retours_dataGridView);
            this.TabDeBord_tabPage.Controls.Add(this.Retards_dataGridView);
            this.TabDeBord_tabPage.Controls.Add(this.Reservations_label);
            this.TabDeBord_tabPage.Controls.Add(this.Retours_label);
            this.TabDeBord_tabPage.Controls.Add(this.Retards_label);
            this.TabDeBord_tabPage.Location = new System.Drawing.Point(4, 22);
            this.TabDeBord_tabPage.Name = "TabDeBord_tabPage";
            this.TabDeBord_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabDeBord_tabPage.Size = new System.Drawing.Size(999, 677);
            this.TabDeBord_tabPage.TabIndex = 0;
            this.TabDeBord_tabPage.Text = "Tableau de Bord";
            // 
            // Reservations_dataGridView
            // 
            this.Reservations_dataGridView.AllowUserToAddRows = false;
            this.Reservations_dataGridView.AllowUserToDeleteRows = false;
            this.Reservations_dataGridView.AllowUserToOrderColumns = true;
            this.Reservations_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservations_dataGridView.Location = new System.Drawing.Point(670, 100);
            this.Reservations_dataGridView.Name = "Reservations_dataGridView";
            this.Reservations_dataGridView.ReadOnly = true;
            this.Reservations_dataGridView.Size = new System.Drawing.Size(300, 550);
            this.Reservations_dataGridView.TabIndex = 71;
            // 
            // Retours_dataGridView
            // 
            this.Retours_dataGridView.AllowUserToAddRows = false;
            this.Retours_dataGridView.AllowUserToDeleteRows = false;
            this.Retours_dataGridView.AllowUserToOrderColumns = true;
            this.Retours_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Retours_dataGridView.Location = new System.Drawing.Point(350, 100);
            this.Retours_dataGridView.Name = "Retours_dataGridView";
            this.Retours_dataGridView.ReadOnly = true;
            this.Retours_dataGridView.Size = new System.Drawing.Size(300, 550);
            this.Retours_dataGridView.TabIndex = 70;
            // 
            // Retards_dataGridView
            // 
            this.Retards_dataGridView.AllowUserToAddRows = false;
            this.Retards_dataGridView.AllowUserToDeleteRows = false;
            this.Retards_dataGridView.AllowUserToOrderColumns = true;
            this.Retards_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Retards_dataGridView.Location = new System.Drawing.Point(30, 100);
            this.Retards_dataGridView.Name = "Retards_dataGridView";
            this.Retards_dataGridView.ReadOnly = true;
            this.Retards_dataGridView.Size = new System.Drawing.Size(300, 550);
            this.Retards_dataGridView.TabIndex = 69;
            // 
            // Reservations_label
            // 
            this.Reservations_label.AutoSize = true;
            this.Reservations_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservations_label.Location = new System.Drawing.Point(730, 50);
            this.Reservations_label.Name = "Reservations_label";
            this.Reservations_label.Size = new System.Drawing.Size(165, 29);
            this.Reservations_label.TabIndex = 11;
            this.Reservations_label.Text = "Reservations";
            // 
            // Retours_label
            // 
            this.Retours_label.AutoSize = true;
            this.Retours_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retours_label.Location = new System.Drawing.Point(446, 50);
            this.Retours_label.Name = "Retours_label";
            this.Retours_label.Size = new System.Drawing.Size(104, 29);
            this.Retours_label.TabIndex = 10;
            this.Retours_label.Text = "Retours";
            // 
            // Retards_label
            // 
            this.Retards_label.AutoSize = true;
            this.Retards_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retards_label.Location = new System.Drawing.Point(126, 50);
            this.Retards_label.Name = "Retards_label";
            this.Retards_label.Size = new System.Drawing.Size(104, 29);
            this.Retards_label.TabIndex = 9;
            this.Retards_label.Text = "Retards";
            // 
            // MainRechercher_tabPage
            // 
            this.MainRechercher_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainRechercher_tabPage.Controls.Add(this.ResultatMain_dataGridView);
            this.MainRechercher_tabPage.Controls.Add(this.FiltresDeRechercheMain_checkedListBox);
            this.MainRechercher_tabPage.Controls.Add(this.RechercherMain_textBox);
            this.MainRechercher_tabPage.Location = new System.Drawing.Point(4, 22);
            this.MainRechercher_tabPage.Name = "MainRechercher_tabPage";
            this.MainRechercher_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainRechercher_tabPage.Size = new System.Drawing.Size(999, 677);
            this.MainRechercher_tabPage.TabIndex = 1;
            this.MainRechercher_tabPage.Text = "Rechercher";
            // 
            // ResultatMain_dataGridView
            // 
            this.ResultatMain_dataGridView.AllowUserToAddRows = false;
            this.ResultatMain_dataGridView.AllowUserToDeleteRows = false;
            this.ResultatMain_dataGridView.AllowUserToOrderColumns = true;
            this.ResultatMain_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultatMain_dataGridView.Location = new System.Drawing.Point(350, 100);
            this.ResultatMain_dataGridView.Name = "ResultatMain_dataGridView";
            this.ResultatMain_dataGridView.ReadOnly = true;
            this.ResultatMain_dataGridView.Size = new System.Drawing.Size(620, 550);
            this.ResultatMain_dataGridView.TabIndex = 68;
            // 
            // FiltresDeRechercheMain_checkedListBox
            // 
            this.FiltresDeRechercheMain_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FiltresDeRechercheMain_checkedListBox.FormattingEnabled = true;
            this.FiltresDeRechercheMain_checkedListBox.Location = new System.Drawing.Point(30, 100);
            this.FiltresDeRechercheMain_checkedListBox.Name = "FiltresDeRechercheMain_checkedListBox";
            this.FiltresDeRechercheMain_checkedListBox.Size = new System.Drawing.Size(300, 550);
            this.FiltresDeRechercheMain_checkedListBox.TabIndex = 55;
            // 
            // RechercherMain_textBox
            // 
            this.RechercherMain_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherMain_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.RechercherMain_textBox.Location = new System.Drawing.Point(125, 35);
            this.RechercherMain_textBox.Name = "RechercherMain_textBox";
            this.RechercherMain_textBox.Size = new System.Drawing.Size(750, 30);
            this.RechercherMain_textBox.TabIndex = 52;
            this.RechercherMain_textBox.Text = "Rechercher un livre, un jouet ou un adherant";
            // 
            // MainScanner_tabPage
            // 
            this.MainScanner_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainScanner_tabPage.Controls.Add(this.descriptf);
            this.MainScanner_tabPage.Controls.Add(this.chaine_de_caracter);
            this.MainScanner_tabPage.Location = new System.Drawing.Point(4, 22);
            this.MainScanner_tabPage.Name = "MainScanner_tabPage";
            this.MainScanner_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainScanner_tabPage.Size = new System.Drawing.Size(999, 677);
            this.MainScanner_tabPage.TabIndex = 2;
            this.MainScanner_tabPage.Text = "Scanner";
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
            // MainStat_tabPage
            // 
            this.MainStat_tabPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainStat_tabPage.Controls.Add(this.label6);
            this.MainStat_tabPage.Controls.Add(this.label5);
            this.MainStat_tabPage.Controls.Add(this.label4);
            this.MainStat_tabPage.Location = new System.Drawing.Point(4, 22);
            this.MainStat_tabPage.Name = "MainStat_tabPage";
            this.MainStat_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainStat_tabPage.Size = new System.Drawing.Size(999, 677);
            this.MainStat_tabPage.TabIndex = 3;
            this.MainStat_tabPage.Text = "Statistiques";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.Main_tabControl);
            this.Controls.Add(this.Main_menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Main_menuStrip;
            this.MaximumSize = new System.Drawing.Size(1023, 766);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "MainForm";
            this.Text = "BiblioFusion";
            this.Main_menuStrip.ResumeLayout(false);
            this.Main_menuStrip.PerformLayout();
            this.Main_tabControl.ResumeLayout(false);
            this.TabDeBord_tabPage.ResumeLayout(false);
            this.TabDeBord_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservations_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retours_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retards_dataGridView)).EndInit();
            this.MainRechercher_tabPage.ResumeLayout(false);
            this.MainRechercher_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultatMain_dataGridView)).EndInit();
            this.MainScanner_tabPage.ResumeLayout(false);
            this.MainStat_tabPage.ResumeLayout(false);
            this.MainStat_tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Options_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Deconnexion_ToolStripMenuItem;
        private System.Windows.Forms.TabControl Main_tabControl;
        private System.Windows.Forms.TabPage TabDeBord_tabPage;
        private System.Windows.Forms.TabPage MainRechercher_tabPage;
        private System.Windows.Forms.TabPage MainScanner_tabPage;
        private System.Windows.Forms.TabPage MainStat_tabPage;
        private System.Windows.Forms.ToolStripMenuItem Adherents_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Livres_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Categories_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Administateurs_ToolStripMenuItem;
        private System.Windows.Forms.Label Reservations_label;
        private System.Windows.Forms.Label Retours_label;
        private System.Windows.Forms.Label Retards_label;
        private System.Windows.Forms.ToolStripMenuItem Jouets_ToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox FiltresDeRechercheMain_checkedListBox;
        private System.Windows.Forms.TextBox RechercherMain_textBox;
        private System.Windows.Forms.ToolStripMenuItem Classes_ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox descriptf;
        private System.Windows.Forms.ToolStripMenuItem Emprunts_ToolStripMenuItem;
        private System.Windows.Forms.ListBox chaine_de_caracter;
        private System.Windows.Forms.ToolStripMenuItem NouvelEmprunt_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnregisterRetour_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReserverArticle_ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView Retards_dataGridView;
        private System.Windows.Forms.DataGridView ResultatMain_dataGridView;
        private System.Windows.Forms.DataGridView Reservations_dataGridView;
        private System.Windows.Forms.DataGridView Retours_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem CodeQR_ToolStripMenuItem;
    }
}

