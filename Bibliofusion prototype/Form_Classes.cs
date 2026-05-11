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
    public partial class Form_Classes : Form
    {
        public static string NomClasse, NomProf, NomEtablissement, AdresseEtablissement, NiveauClasse;
        public Form_Classes()
        {
            InitializeComponent();
        }

        private void ValiderAjoutClasse_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous valider cette classe", "Nouvelle classe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {


                MessageBox.Show(
                    "Nom de la classe : " + NomClasse +
                    "\nNom du professeur : " + NomProf +
                    "\nNom de l'établissement : " + NomEtablissement +
                    "\nAdresse de l'établissement : " + AdresseEtablissement +
                    "\nNiveau de la classe : " + NiveauClasse
                    ,"Nouvelle classe créée");
            }
        }
    }
}
