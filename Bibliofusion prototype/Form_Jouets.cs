using MySql.Data.MySqlClient;
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

        private void RechercherEditerJouet_button_Click(object sender, EventArgs e)
        {
            try
            {
                string requette = "SELECT * FROM jouets WHERE Nom LIKE @nom";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@nom", RechercherJouet_textBox.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commande);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ResultatJouet_dataGridView.DataSource = table;
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }

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
                try
                {
                    DateTime DateActuelle = DateTime.Now;
                    string DateFormate = DateActuelle.ToString("yyyy-MM-dd");
                    string TrancheAges = $"{AgeMinJouet_numericUpDown.Text} - {AgeMaxJouet_numericUpDown.Text}";

                    string requette = "INSERT INTO jouets ( idJouets_Code_Barre, Nom, Marque, Date_Entree_Bibliotheque,Date_Mise_En_Vente, Emplacement,Exemplaires_Disponibles, Tranche_Ages) " +
                                        "VALUES ( @idJouets_Code_Barre, @Nom, @Marque, @Date_Entree_Bibliotheque, @Date_Mise_En_Vente, @Emplacement, @Exemplaires_Disponibles, @Tranche_Ages)";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@idJouets_Code_Barre", IdJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Nom", NomJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Marque", MarqueJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Date_Mise_En_Vente", DateVenteJouet_dateTimePicker.Text);
                    commande.Parameters.AddWithValue("@Date_Entree_Bibliotheque", DateFormate);
                    commande.Parameters.AddWithValue("@Exemplaires_Disponibles", NbExemplairesJouet_numericUpDown.Text);
                    commande.Parameters.AddWithValue("@Emplacement", EmplacementJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Tranche_Ages", TrancheAges);
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Jouet : {NomJouet_textBox.Text} ajouté");
                }
                catch (Exception erreur)
                {
                    MessageBox.Show(erreur.Message);
                }
            }
        }
    }
}
