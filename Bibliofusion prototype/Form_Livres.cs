using Bibliofusion_prototype;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Livres : Form
    {
        public static string TitreLivre, uteurLivre, CategorieLivre, EmplacementLivre, ISBNLivre, DateParutionLivre;

        private void RechercherEditerLivre_button_Click(object sender, EventArgs e)
        {
            try
            {

                string requette = "SELECT * FROM livres WHERE Titre LIKE @titre";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@titre", RechercherLivre_textBox.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commande);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ResultatLivre_dataGridView.DataSource = table;
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }

        public static int NbExemplairesLivre;
        public Form_Livres()
        {
            InitializeComponent();

        }


        private void ValiderAjoutLivre_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous valider ce livre ?", "Nouveau livre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                try
                {
                    DateTime DateActuelle = DateTime.Now;
                    string DateFormate = DateActuelle.ToString("yyyy-MM-dd");
                    string TrancheAges = $"{AgeMinLivre_numericUpDown.Text} - {AgeMaxLivre_numericUpDown.Text}";

                    string requette =   "INSERT INTO livres ( idLivres_ISBN, Titre, Date, Date_Entree_Bibliotheque, Exemplaires_Disponibles, Emplacement, Tranche_Ages) " +
                                        "VALUES ( @idLivres_ISBN, @Titre, @Date, @Date_Entree_Bibliotheque, @Exemplaires_Disponibles, @Emplacement, @Tranche_Ages)";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@idLivres_ISBN", ISBNLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Titre", TitreLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Date", DateParutionLivre_dateTimePicker.Text);
                    commande.Parameters.AddWithValue("@Date_Entree_Bibliotheque", DateFormate);
                    commande.Parameters.AddWithValue("@Exemplaires_Disponibles", NbExemplairesLivre_numericUpDown.Text);
                    commande.Parameters.AddWithValue("@Emplacement", EmplacementLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Tranche_Ages", TrancheAges);
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Livre : {TitreLivre_textBox.Text} ajouté");

                }
                catch(Exception erreur)
                {
                    MessageBox.Show(erreur.Message);
                }

            }
        }
    }
}
