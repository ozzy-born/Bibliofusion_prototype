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
    public partial class Form_Jouets : Form
    {
        public static string NomJouet, CategorieJouet, MarqueJouet, EmplacementJouet, IdJouet, DateMiseEnVenteJouet;


        public static int AgeMinJouet, AgeMaxJouet, NbExemplaires;
        public Form_Jouets()
        {
            InitializeComponent();
        }

        private void ValiderAjoutJouet_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous valider ce jouet ?", "Nouveau jouet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                if (CategorieJouet_comboBox != null)
                {
                    CategorieJouet = "NA";
                }
                else
                {
                    CategorieJouet = CategorieJouet_comboBox.SelectedItem.ToString();
                }
                NomJouet = NomJouet_textBox.Text;
                MarqueJouet = MarqueJouet_textBox.Text;
                EmplacementJouet = EmplacementJouet_textBox.Text;
                IdJouet = IdJouet_textBox.Text;
                DateMiseEnVenteJouet = DateVenteJouet_dateTimePicker.Text;
                AgeMinJouet = (int)AgeMinJouet_numericUpDown.Value;
                AgeMaxJouet = (int)AgeMaxJouet_numericUpDown.Value;
                NbExemplaires = (int)NbExemplairesJouet_numericUpDown.Value;
                MessageBox.Show(
                    "Nom du jouet : " + NomJouet +
                    "\nCatégorie du jouet : " + CategorieJouet +
                    "\nMarque du jouet : " + MarqueJouet +
                    "\nEmplacement du jouet : " + EmplacementJouet +
                    "\nID du jouet : " + IdJouet +
                    "\nDate de mise en vente du jouet : " + DateMiseEnVenteJouet +
                    "\nÂge minimum recommandé pour le jouet : " + AgeMinJouet +
                    "\nÂge maximum recommandé pour le jouet : " + AgeMaxJouet +
                    "\nNombre d'exemplaires disponibles du jouet : " + NbExemplaires
                    ,"Nouveau jouet créé");
            }
        }
    }
}
