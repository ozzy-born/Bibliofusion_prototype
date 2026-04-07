using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bibliofusion_prototype
{
    public partial class Form_Categories : Form
    {
        public static string TypeArticle, NomCatergorie;
        public Form_Categories()
        {
            InitializeComponent();
        }

        private void Form_Categories_Load(object sender, EventArgs e)
        {

        }

        private void ValiderAjoutCategorie_button_Click(object sender, EventArgs e)
        {
            if (CategorieJouet_radioButton.Checked == true) { 
                TypeArticle = "Jouet";
            }
            else if (CategorieLivre_radioButton.Checked == true)
            {
                TypeArticle = "Livre";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type d'article.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult verfication = MessageBox.Show("Voulez-vous valider cette catégorie ?", "Nouvelle catégorie de " + TypeArticle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verfication == DialogResult.Yes)
            {
                NomCatergorie = NomCategorie_textBox.Text;
                MessageBox.Show("Nouvelle catégorie de " + TypeArticle + " créée !" );
            }
        }
    }
}
