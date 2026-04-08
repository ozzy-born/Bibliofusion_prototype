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
        public static string Nom, Nom1, Nom2, Prenom, Prenom1, Prenom2, DateNaissance, DateNaissance1, DateNaissance2, Email, Email1, Email2, Mobile, Mobile1, Mobile2, Fixe, Fixe1, Fixe2, Classe, Adresse, Adresse1, Adresse2;
        public static int CodePostal, CodePostal1, CodePostal2;
        public Form_Adherents()
        {
            InitializeComponent();
            ResponsableAdherent_tabPage.Enabled = false;
            ResponsableNonAdherent_tabPage.Enabled = false;
            Classe_tabPage.Enabled = false;
            SupprResponsable1NonAdherent_label.Hide();
            SupprResponsable1Adherent_label.Hide();
            SupprResponsable2NonAdherent_label.Hide();
            SupprResponsable2Adherent_label.Hide();
            SupprClasse_label.Hide();
        }
        private void SupprResponsable1()
        {
            if (Responsable2Adherent_label.Text != "Responsable 2")
            {
                Nom1 = Nom2;
                Prenom1 = Prenom2;
                Nom2 = null;
                Prenom2 = null;
                Responsable1NonAdherent_label.Text = "Responsable 1 : " + Nom1 + " " + Prenom1;
                Responsable1Adherent_label.Text = "Responsable 1 : " + Nom1 + " " + Prenom1;
                SupprResponsable1NonAdherent_label.Show();
                SupprResponsable1Adherent_label.Show();
                Responsable2Adherent_label.Text = "Responsable 2";
                Responsable2NonAdherent_label.Text = "Responsable 2";
                SupprResponsable2NonAdherent_label.Hide();
                SupprResponsable2Adherent_label.Hide();
            }
            else
            {
                Responsable1Adherent_label.Text = "Responsable 1";
                Responsable1NonAdherent_label.Text = "Responsable 1";
                SupprResponsable1NonAdherent_label.Hide();
                SupprResponsable1Adherent_label.Hide();
            }
        }
        
        private void SupprResponsable2()
        {
            Responsable2Adherent_label.Text = "Responsable 2";
            Responsable2NonAdherent_label.Text = "Responsable 2";
            SupprResponsable2NonAdherent_label.Hide();
            SupprResponsable2Adherent_label.Hide();
        }


        private void SupprResponsable1NonAdherent_label_Click(object sender, EventArgs e) {
            SupprResponsable1();
        }

        private void SupprResponsable1Adherent_label_Click(object sender, EventArgs e) {
            SupprResponsable1();
        }

        private void SupprResponsable2NonAdherent_label_Click(object sender, EventArgs e) {
            SupprResponsable2();
        }

        private void SupprResponsable2Adherent_label_Click(object sender, EventArgs e) {
            SupprResponsable2();
        }

        private void SupprClasse_label_Click(object sender, EventArgs e)
        {
            Classe_label.Text = "Classe";
            SupprClasse_label.Hide();
        }

        private void AjoutResponsableNonAdherent()
        {

            if (Responsable1Adherent_label.Text != "Responsable 1" && Responsable2Adherent_label.Text == "Responsable 2")
            {
                Nom2 = NomResponsable_textBox.Text;
                Prenom2 = PrenomResponsable_textBox.Text;
                Responsable2NonAdherent_label.Text = "Responsable 2 : " + Nom2 + " " + Prenom2;
                Responsable2Adherent_label.Text = "Responsable 2 : " + Nom2 + " " + Prenom2;
                SupprResponsable2NonAdherent_label.Show();
                SupprResponsable2Adherent_label.Show();
            }

            if (Responsable1Adherent_label.Text == "Responsable 1")
            {
                Nom1 = NomResponsable_textBox.Text;
                Prenom1 = PrenomResponsable_textBox.Text;
                Responsable1NonAdherent_label.Text = "Responsable 1 : " + Nom1 + " " + Prenom1;
                Responsable1Adherent_label.Text = "Responsable 1 : " + Nom1 + " " + Prenom1;
                SupprResponsable1NonAdherent_label.Show();
                SupprResponsable1Adherent_label.Show();
            }
        }

        private void AjoutResponsableNonAdherent_button_Click(object sender, EventArgs e)
        {
            AjoutResponsableNonAdherent();
        }

        private void AjoutResponsableAdherent_button_Click(object sender, EventArgs e)
        {
            AjoutResponsableNonAdherent();
        }


        private void Eleve_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Eleve_checkBox.Checked == true)
            {
                Classe_tabPage.Enabled = true;
            }
            else
            {
                Classe_tabPage.Enabled = false;
            }
        }
        private void Mineur_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Mineur_checkBox.Checked == true)
            {
                ResponsableAdherent_tabPage.Enabled = true;
                ResponsableNonAdherent_tabPage.Enabled = true;
            }
            else
            {
                ResponsableAdherent_tabPage.Enabled = false;
                ResponsableNonAdherent_tabPage.Enabled = false;
            }
        }

        private void AdherentValider_button_Click(object sender, EventArgs e)
        {
            try
            {
                CodePostal = int.Parse(CodePostalAdherent_textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Le code postal doit être un nombre entier. \nEntrez 0 Si le code postal est inconnu", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult verfication = MessageBox.Show("Voulez-vous ajouter cet adhérent ?", "Nouvel adhérent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verfication == DialogResult.Yes)
            {
                // Code pour valider l'adhérent
                Nom = NomAdherent_textBox.Text;
                Prenom = PrenomAdherent_textBox.Text;
                DateNaissance = NaissanceAdherent_dateTimePicker.Value.ToShortDateString();
                Email = MailAdherent_textBox.Text;
                Mobile = MobileAdherent_textBox.Text;
                Fixe = FixeAdherent_textBox.Text;
                Adresse = AdresseAdherent_textBox.Text;
                MessageBox.Show(
                    "Nom : " + Nom +
                    "\nPrénom : " + Prenom +
                    "\nDate de naissance : " + DateNaissance +
                    "\nEmail : " + Email +
                    "\nMobile : " + Mobile +
                    "\nFixe : " + Fixe +
                    "\nAdresse : " + Adresse + " " + CodePostal,
                    "Nouvel adhérent créé");
            }
        }
    }
}
