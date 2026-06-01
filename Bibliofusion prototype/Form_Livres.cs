using Bibliofusion_prototype;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        private void ResultatLivre_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    ISBNLivre_textBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    TitreLivre_textBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    DateParutionLivre_dateTimePicker.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                }
                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur ResultatLivre_dataGridView: {erreur.Message}");
                }
                AfficherDonnees();
            }
        }

        private void ModifierAjoutLivre_button_Click(object sender, EventArgs e)
        {

            try
            {
                string requette = "UPDATE livres SET Titre = @titre, Emplacement = @emplacement, Date_Parution = @date WHERE ISBN = @isbn";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@isbn", ISBNLivre_textBox.Text);
                commande.Parameters.AddWithValue("@titre", TitreLivre_textBox.Text);
                commande.Parameters.AddWithValue("@emplacement", EmplacementLivre_textBox.Text);
                commande.Parameters.AddWithValue("@date", DateParutionLivre_dateTimePicker.Text);
                commande.ExecuteNonQuery();
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur: {erreur.Message}");
            }
        }

        private void Form_Livres_Load(object sender, EventArgs e)
        {
            
            string requetteNomAuteurComboBox = "SELECT Nom FROM Auteurs";
            MySqlCommand commandeAuteur = new MySqlCommand(requetteNomAuteurComboBox, Program.connection);
            MySqlDataReader lectureAuteurs = commandeAuteur.ExecuteReader();
            while (lectureAuteurs.Read())
            {
                NomAuteurLivre_comboBox.Items.Add(lectureAuteurs.GetString(0));
            }
            lectureAuteurs.Close();

            string requetteCategoriesComboBox = "SELECT Nom FROM Categories";
            MySqlCommand commande = new MySqlCommand(requetteCategoriesComboBox, Program.connection);
            MySqlDataReader lectureCategories = commande.ExecuteReader();
            while (lectureCategories.Read())
            {
                CategorieLivre_comboBox.Items.Add(lectureCategories.GetString(0));
            }
            lectureCategories.Close();

        }

        private void AfficherDonnees()
        {
            try
            {
                string requette =   "SELECT idLivres_Isbn AS ISBN, " +
                                    "Titre, " +
                                    "CONCAT(Auteurs.Nom, ' ', Auteurs.Prenom) AS Auteur, " +
                                    "Categories.Nom AS Categorie, " +
                                    "Categories.Emplacement AS Emplacement, " +
                                    "Editeurs.Nom AS Editeur, " +
                                    "Date AS Parution, " +
                                    "Date_Entree_Bibliotheque AS Entree, " +
                                    "Tranche_Ages AS Ages " +
                                    "FROM livres " +
                                    "INNER JOIN Auteurs ON Livres.Auteurs_idAuteurs = Auteurs.idAuteurs " +
                                    "INNER JOIN Categories ON Livres.Categories_idCategories = Categories.idCategorie " +
                                    "INNER JOIN Editeurs ON Livres.Editeurs_idEditeurs = Editeurs.idEditeurs " +
                                    "WHERE Titre LIKE @titre";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@titre", RechercherLivre_textBox.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commande);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ResultatLivre_dataGridView.DataSource = table;
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur datagrid: {erreur}");
            }
        }

        public static int NbExemplairesLivre;

        private void RechercherEditerLivre_button_Click(object sender, EventArgs e)
        {
            AfficherDonnees();
        }

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
                    string TrancheAges = $"{AgeMinLivre_numericUpDown.Text}-{AgeMaxLivre_numericUpDown.Text}";

                    MySqlCommand commandeCountAuteurs = new MySqlCommand("SELECT COUNT(*) FROM Auteurs WHERE Nom LIKE @Auteur AND Prenom LIKE @Prenom", Program.connection);
                    commandeCountAuteurs.Parameters.AddWithValue("@Auteur", NomAuteurLivre_comboBox.Text);
                    commandeCountAuteurs.Parameters.AddWithValue("@Prenom", PrenomAuteurLivre_textBox.Text);

                    if (Convert.ToInt32(commandeCountAuteurs.ExecuteScalar()) == 0)
                    {
                        try
                        {
                            MySqlCommand commandeAjoutAuteur = new MySqlCommand("INSERT INTO auteurs (Nom, Prenom) VALUES (@Nom, @Prenom)", Program.connection);
                            commandeAjoutAuteur.Parameters.AddWithValue("@Nom", NomAuteurLivre_comboBox.Text);
                            commandeAjoutAuteur.Parameters.AddWithValue("@Prenom", PrenomAuteurLivre_textBox.Text);
                            commandeAjoutAuteur.ExecuteNonQuery();
                        }

                        catch (Exception erreur)
                        {
                            MessageBox.Show($"Erreur lors de l'ajout de l'auteur : {erreur.Message}");
                        }
                    }

                    MySqlCommand commandeCountEditeurs = new MySqlCommand("SELECT COUNT(*) FROM Editeurs WHERE Nom LIKE @Editeur", Program.connection);
                    commandeCountEditeurs.Parameters.AddWithValue("@Editeur", EditeurLivre_textBox.Text);

                    if (Convert.ToInt32(commandeCountEditeurs.ExecuteScalar()) == 0)
                    {
                        try
                        {
                            MySqlCommand commandeAjoutEditeur = new MySqlCommand("INSERT INTO Editeurs (Nom) VALUES (@Nom)", Program.connection);
                            commandeAjoutEditeur.Parameters.AddWithValue("@Nom", EditeurLivre_textBox.Text);
                            commandeAjoutEditeur.ExecuteNonQuery();
                        }
                        catch (Exception erreur)
                        {
                            MessageBox.Show($"Erreur lors de l'ajout de l'éditeur : {erreur.Message}");
                        }
                    }

                    string requette =   "INSERT INTO livres ( idLivres_ISBN, Titre, Date, Date_Entree_Bibliotheque, Exemplaires_Disponibles, Emplacement, Auteurs_idAuteurs, Categories_idCategories, Editeurs_idEditeurs, Tranche_Ages)  " +
                                        "SELECT @ISBN, @Titre, @Date, @Date_Entree_Bibliotheque, @Exemplaires_Disponibles, Categories.Emplacement, Auteurs.idAuteurs, Categories.idCategorie, Editeurs.idEditeurs, @Tranche_Ages " +
                                        "FROM auteurs, categories, editeurs " +
                                        "WHERE categories.Nom = @Categorie " +
                                        "AND auteurs.Nom = @NomAuteur " +
                                        "AND auteurs.Prenom = @PrenomAuteur " +
                                        "AND editeurs.Nom = @Editeur";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@ISBN", ISBNLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Titre", TitreLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Date", DateParutionLivre_dateTimePicker.Text);
                    commande.Parameters.AddWithValue("@Date_Entree_Bibliotheque", DateFormate);
                    commande.Parameters.AddWithValue("@Exemplaires_Disponibles", NbExemplairesLivre_numericUpDown.Text);
                    commande.Parameters.AddWithValue("@NomAuteur", NomAuteurLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@PrenomAuteur", PrenomAuteurLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Categorie", CategorieLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@Editeur", EditeurLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Tranche_Ages", TrancheAges);
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Livre : {TitreLivre_textBox.Text} ajouté");

                }
                catch(Exception erreur)
                {
                    MessageBox.Show($"erreur lors de la validation :{erreur.Message}");
                }

            }
        }
    }
}
