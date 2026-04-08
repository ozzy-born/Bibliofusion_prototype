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
    public partial class Form_Livres : Form
    {
        public static string TitreLivre, uteurLivre, CategorieLivre, EmplacementLivre, ISBNLivre;
        public static int DateParutionLivre, NbExemplairesLivre;
        public Form_Livres()
        {
            InitializeComponent();
        }

        private void ValiderAjoutLivre_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous valider ce livre ?", "Nouveau livre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                if (CategorieLivre_comboBox != null)
                {
                    CategorieLivre = "NA";
                }
                else
                {
                    CategorieLivre = CategorieLivre_comboBox.SelectedItem.ToString();
                }
                TitreLivre = TitreLivre_textBox.Text;
                uteurLivre = AuteurLivre_textBox.Text;
                EmplacementLivre = EmplacementLivre_textBox.Text;
                ISBNLivre = ISBNLivre_textBox.Text;
                DateParutionLivre = (int)DateParutionLivre_numericUpDown.Value;
                NbExemplairesLivre = (int)NbExemplairesLivre_numericUpDown.Value;
                MessageBox.Show(
                    "Nom du livre : " + TitreLivre +
                    "\nAuteur du livre : " + uteurLivre +
                    "\nCatégorie du livre : " + CategorieLivre +
                    "\nEmplacement du livre : " + EmplacementLivre +
                    "\nISBN du livre : " + ISBNLivre +
                    "\nDate de parution du livre : " + DateParutionLivre +
                    "\nNombre d'exemplaires du livre : " + NbExemplairesLivre
                    ,"Nouveau livre créé");
            }
        }
    }
}
