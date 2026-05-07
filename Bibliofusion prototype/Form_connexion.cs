using Bibliofusion_prototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Connexion : Form
    {
        public static string Id, Mdp;
        public Form_Connexion()
        {
            InitializeComponent();
        }


        private void Connexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_textBox.Text) && string.IsNullOrEmpty(Mdp_textBox.Text))
            {
                MessageBox.Show("Veuillez vous identifier.");
                return;
            }

            if (string.IsNullOrEmpty(Id_textBox.Text))
            {
                MessageBox.Show("Veuillez remplir l'identifiant.");
                return;
            }

            if (string.IsNullOrEmpty(Mdp_textBox.Text))
            {
                MessageBox.Show("Veuillez remplir le mot de passe.");
                return;
            }

            // Vérification login
            if (Id_textBox.Text == "id" && Mdp_textBox.Text == "mdp")
            {
                Id = Id_textBox.Text;
                Mdp = Mdp_textBox.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Mdp_textBox.Clear();

                MessageBox.Show("Identifiant ou mot de passe incorrect.");
            }
        }

        private void Mdp_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Connexion_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Up)
            {
                Id_textBox.Focus();

            }
        }

        private void Id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                Mdp_textBox.Focus();
            }
        }
    }
}
