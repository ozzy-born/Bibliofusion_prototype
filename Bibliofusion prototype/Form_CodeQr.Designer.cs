using System;

namespace QRcode_generator
{
    partial class Form_CodeQr
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
            this.genererQR_button = new System.Windows.Forms.Button();
            this.QRpicture = new System.Windows.Forms.PictureBox();
            this.qr_textBox = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.QRpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // genererQR_button
            // 
            this.genererQR_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genererQR_button.Location = new System.Drawing.Point(12, 47);
            this.genererQR_button.Name = "genererQR_button";
            this.genererQR_button.Size = new System.Drawing.Size(326, 33);
            this.genererQR_button.TabIndex = 0;
            this.genererQR_button.Text = "Générer le code QR";
            this.genererQR_button.UseVisualStyleBackColor = true;
            this.genererQR_button.Click += new System.EventHandler(this.genererQR_button_Click);
            // 
            // QRpicture
            // 
            this.QRpicture.Location = new System.Drawing.Point(89, 135);
            this.QRpicture.Name = "QRpicture";
            this.QRpicture.Size = new System.Drawing.Size(100, 50);
            this.QRpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.QRpicture.TabIndex = 1;
            this.QRpicture.TabStop = false;
            // 
            // qr_textBox
            // 
            this.qr_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qr_textBox.Location = new System.Drawing.Point(12, 12);
            this.qr_textBox.Name = "qr_textBox";
            this.qr_textBox.Size = new System.Drawing.Size(326, 29);
            this.qr_textBox.TabIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form_CodeQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 334);
            this.Controls.Add(this.qr_textBox);
            this.Controls.Add(this.QRpicture);
            this.Controls.Add(this.genererQR_button);
            this.MaximumSize = new System.Drawing.Size(379, 373);
            this.MinimumSize = new System.Drawing.Size(379, 373);
            this.Name = "Form_CodeQr";
            this.Text = "BiblioFusion - Génération de Code QR";
            ((System.ComponentModel.ISupportInitialize)(this.QRpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button genererQR_button;
        private System.Windows.Forms.PictureBox QRpicture;
        private System.Windows.Forms.TextBox qr_textBox;
        //private System.Windows.Forms.PrintDialog printDialog1;
    }
}

