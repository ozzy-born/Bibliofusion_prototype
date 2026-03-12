namespace WindowsFormsApp1
{
    partial class Form_connexion
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
            this.Connexion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.MDP = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connexion
            // 
            this.Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Connexion.Location = new System.Drawing.Point(52, 263);
            this.Connexion.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(254, 32);
            this.Connexion.TabIndex = 0;
            this.Connexion.Text = "Connexion";
            this.Connexion.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.textBox1.Location = new System.Drawing.Point(52, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.textBox2.Location = new System.Drawing.Point(52, 197);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 27);
            this.textBox2.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Himalaya", 15.2F);
            this.ID.Location = new System.Drawing.Point(48, 112);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(77, 21);
            this.ID.TabIndex = 3;
            this.ID.Text = "Identifiant :";
            // 
            // MDP
            // 
            this.MDP.AutoSize = true;
            this.MDP.Font = new System.Drawing.Font("Microsoft Himalaya", 15.2F);
            this.MDP.Location = new System.Drawing.Point(48, 176);
            this.MDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(93, 21);
            this.MDP.TabIndex = 4;
            this.MDP.Text = "Mot de Passe :";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 25F);
            this.Title.Location = new System.Drawing.Point(92, 30);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(191, 42);
            this.Title.TabIndex = 5;
            this.Title.Text = "BiblioFusion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(195, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mot de Passe oublié";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Connexion);
            this.MaximumSize = new System.Drawing.Size(379, 373);
            this.MinimumSize = new System.Drawing.Size(379, 373);
            this.Name = "Form1";
            this.Text = "BiblioFusion - connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label MDP;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button1;
    }
}

