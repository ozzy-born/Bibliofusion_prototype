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
    public partial class Form_Adherents : Form
    {
        public static string Nom, Prenom, Classe, DateNaissance, Email, Mobile, Fixe;
        public static int CodePostal;
        public Form_Adherents()
        {
            InitializeComponent();
            ResponsableAdherent_tabPage.Enabled = false;
            ResponsableNonAdherent_tabPage.Enabled = false;
            Classe_tabPage.Enabled = false;
        }
        private void AjoutResponsabl()
        {

            if (Responsable1Adherent_label.Text != "Responsable 1")
            {
                Nom = NomResponsable_textBox.Text;
                Prenom = PrenomResponsable_textBox.Text;
                Responsable2NonAdherent_label.Text = "Responsable 2 : " + Nom + " " + Prenom;
                Responsable2Adherent_label.Text = "Responsable 2 : " + Nom + " " + Prenom;

            if (Responsable1Adherent_label.Text == "Responsable 1")
            {
                Nom = NomResponsable_textBox.Text;
                Prenom = PrenomResponsable_textBox.Text;
                Responsable1NonAdherent_label.Text = "Responsable 1 : " + Nom + " " + Prenom;
                Responsable1Adherent_label.Text = "Responsable 1 : " + Nom + " " + Prenom;
            }
            }
        }
        private void AjoutResponsableNonAdherent_button_Click(object sender, EventArgs e)
        {
            AjoutResponsabl();
        }

        private void AjoutResponsableAdherent_button_Click(object sender, EventArgs e)
        {
            AjoutResponsabl();
        }


        private void Eleve_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Eleve_checkBox.Checked == true)
            {
                ResponsableAdherent_tabPage.Enabled = true;
                ResponsableNonAdherent_tabPage.Enabled = true;
                Classe_tabPage.Enabled = true;
            }
            else
            {
                ResponsableAdherent_tabPage.Enabled = false;
                ResponsableNonAdherent_tabPage.Enabled = false;
                Classe_tabPage.Enabled = false;
            }
        }
        private void Mineur_checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (Mineur_checkBox.Checked == true)
            {
                ResponsableAdherent_tabPage.Enabled = true;
                ResponsableNonAdherent_tabPage.Enabled = true;
                Classe_tabPage.Enabled = false;
            }
            else
            {
                ResponsableAdherent_tabPage.Enabled = false;
                ResponsableNonAdherent_tabPage.Enabled = false;
                Classe_tabPage.Enabled = false;
            }
        }

        private void AdherentValider_button_Click(object sender, EventArgs e)
        {
            DialogResult verfication = MessageBox.Show("Voulez-vous valider cet adhérent ?", "Nouvel adhérent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verfication == DialogResult.Yes)
            {
                // Code pour valider l'adhérent
                MessageBox.Show("Nouvel adhérent créé !");
            }
            else
            {
                MessageBox.Show("Validation annulée.");
            }
        }
    }
}
