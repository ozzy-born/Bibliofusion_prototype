namespace Bibliofusion_prototype
{
    partial class Form_test
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
            this.btn_testco = new System.Windows.Forms.Button();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_res = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.date_naissance = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_testco
            // 
            this.btn_testco.Location = new System.Drawing.Point(519, 114);
            this.btn_testco.Name = "btn_testco";
            this.btn_testco.Size = new System.Drawing.Size(236, 52);
            this.btn_testco.TabIndex = 0;
            this.btn_testco.Text = "test connexion";
            this.btn_testco.UseVisualStyleBackColor = true;
            this.btn_testco.Click += new System.EventHandler(this.btn_testco_Click);
            // 
            // btn_suppr
            // 
            this.btn_suppr.Location = new System.Drawing.Point(519, 230);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(236, 52);
            this.btn_suppr.TabIndex = 1;
            this.btn_suppr.Text = "supprimer";
            this.btn_suppr.UseVisualStyleBackColor = true;
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(519, 172);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(236, 52);
            this.btn_ajout.TabIndex = 2;
            this.btn_ajout.Text = "ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(519, 346);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_res
            // 
            this.btn_res.Location = new System.Drawing.Point(519, 288);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(236, 52);
            this.btn_res.TabIndex = 5;
            this.btn_res.Text = "vider";
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(152, 128);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(214, 20);
            this.tb_id.TabIndex = 6;
            this.tb_id.Text = "id";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(152, 189);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(214, 20);
            this.tb_nom.TabIndex = 7;
            this.tb_nom.Text = "nom";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(152, 247);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(214, 20);
            this.tb_adresse.TabIndex = 8;
            this.tb_adresse.Text = "adresse";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 424);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(214, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(152, 363);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(214, 20);
            this.textBox6.TabIndex = 10;
            // 
            // tb_recherche
            // 
            this.tb_recherche.Location = new System.Drawing.Point(152, 55);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(214, 20);
            this.tb_recherche.TabIndex = 12;
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(519, 38);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(236, 52);
            this.btn_recherche.TabIndex = 13;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // date_naissance
            // 
            this.date_naissance.CustomFormat = "yyyy-MM-dd";
            this.date_naissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_naissance.Location = new System.Drawing.Point(158, 304);
            this.date_naissance.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.Size = new System.Drawing.Size(207, 20);
            this.date_naissance.TabIndex = 14;
            this.date_naissance.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 140);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.date_naissance);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.tb_recherche);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.btn_testco);
            this.Name = "Form_test";
            this.Text = "Form_test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_testco;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.DateTimePicker date_naissance;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}