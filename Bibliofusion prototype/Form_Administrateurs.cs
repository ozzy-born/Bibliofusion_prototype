using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliofusion_prototype
{
    public partial class Form_Administrateurs : Form
    {
        public static string Nom, Prenom, DateNaissance, Email, Mobile, Fixe, Adresse;
        public static int CodePostal;
        public Form_Administrateurs()
        {
            InitializeComponent();
        }

        private void ValiderAjoutAdmin_button_Click(object sender, EventArgs e)
        {
            try 
            {
                CodePostal = int.Parse(CodePostalAdmin_textBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Le code postal doit être un nombre entier.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult verfication = MessageBox.Show("Voulez-vous valider cet Administrateur ?", "Nouvel Administrateur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verfication == DialogResult.Yes)
            {
                // Code pour valider l'adhérent
                Nom = NomAdmin_textBox.Text;
                Prenom = PrenomAdmin_textBox.Text;
                DateNaissance = NaissanceAdmin_dateTimePicker.Value.ToString("dd/MM/yyyy");
                Email = EmailAdmin_textBox.Text;
                Mobile = MobileAdmin_textBox.Text;
                Fixe = FixeAdmin_textBox.Text;
                Adresse = AdresseAdmin_textBox.Text;
                MessageBox.Show("Nouvel Administrateur créé !");
            }
        }
    }
}
