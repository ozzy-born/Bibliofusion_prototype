namespace WindowsFormsApp1
{
    partial class Form_Connexion
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
            this.Connexion_button = new System.Windows.Forms.Button();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.Mdp_textBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.MDP = new System.Windows.Forms.Label();
            this.BiblioFusion_label = new System.Windows.Forms.Label();
            this.MdpOublie_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connexion_button
            // 
            this.Connexion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Connexion_button.Location = new System.Drawing.Point(52, 263);
            this.Connexion_button.Margin = new System.Windows.Forms.Padding(8);
            this.Connexion_button.Name = "Connexion_button";
            this.Connexion_button.Size = new System.Drawing.Size(254, 32);
            this.Connexion_button.TabIndex = 0;
            this.Connexion_button.Text = "Connexion";
            this.Connexion_button.UseVisualStyleBackColor = true;
            this.Connexion_button.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // Id_textBox
            // 
            this.Id_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.Id_textBox.Location = new System.Drawing.Point(52, 133);
            this.Id_textBox.Margin = new System.Windows.Forms.Padding(8);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.Size = new System.Drawing.Size(254, 27);
            this.Id_textBox.TabIndex = 1;
            this.Id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_textBox_KeyPress);
            // 
            // Mdp_textBox
            // 
            this.Mdp_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mdp_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.Mdp_textBox.Location = new System.Drawing.Point(52, 197);
            this.Mdp_textBox.Margin = new System.Windows.Forms.Padding(8);
            this.Mdp_textBox.Name = "Mdp_textBox";
            this.Mdp_textBox.Size = new System.Drawing.Size(254, 27);
            this.Mdp_textBox.TabIndex = 2;
            this.Mdp_textBox.UseSystemPasswordChar = true;
            this.Mdp_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mdp_textBox_KeyPress);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(47, 108);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(97, 27);
            this.ID.TabIndex = 3;
            this.ID.Text = "Identifiant :";
            // 
            // MDP
            // 
            this.MDP.AutoSize = true;
            this.MDP.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDP.Location = new System.Drawing.Point(47, 168);
            this.MDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(119, 27);
            this.MDP.TabIndex = 4;
            this.MDP.Text = "Mot de Passe :";
            // 
            // BiblioFusion_label
            // 
            this.BiblioFusion_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BiblioFusion_label.AutoSize = true;
            this.BiblioFusion_label.Font = new System.Drawing.Font("Impact", 25F);
            this.BiblioFusion_label.Location = new System.Drawing.Point(92, 30);
            this.BiblioFusion_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BiblioFusion_label.Name = "BiblioFusion_label";
            this.BiblioFusion_label.Size = new System.Drawing.Size(191, 42);
            this.BiblioFusion_label.TabIndex = 5;
            this.BiblioFusion_label.Text = "BiblioFusion";
            // 
            // MdpOublie_button
            // 
            this.MdpOublie_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MdpOublie_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdpOublie_button.Location = new System.Drawing.Point(140, 226);
            this.MdpOublie_button.Margin = new System.Windows.Forms.Padding(0);
            this.MdpOublie_button.Name = "MdpOublie_button";
            this.MdpOublie_button.Size = new System.Drawing.Size(166, 29);
            this.MdpOublie_button.TabIndex = 6;
            this.MdpOublie_button.Text = "Mot de Passe oublié";
            this.MdpOublie_button.UseVisualStyleBackColor = false;
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 334);
            this.Controls.Add(this.MdpOublie_button);
            this.Controls.Add(this.BiblioFusion_label);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Mdp_textBox);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.Connexion_button);
            this.MaximumSize = new System.Drawing.Size(379, 373);
            this.MinimumSize = new System.Drawing.Size(379, 373);
            this.Name = "Form_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiblioFusion - connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connexion_button;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.TextBox Mdp_textBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label MDP;
        private System.Windows.Forms.Label BiblioFusion_label;
        private System.Windows.Forms.Button MdpOublie_button;
    }
}

