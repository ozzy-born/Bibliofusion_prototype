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
        public static int NbExemplairesLivre;

        public Form_Livres()
        {
            InitializeComponent();

        }

        private void ActualisationAuteursCategoriesEditeurs()
        {
            string requetteNomAuteursComboBox = "SELECT Nom FROM Auteurs";
            MySqlCommand commandeAuteur = new MySqlCommand(requetteNomAuteursComboBox, Program.connection);
            MySqlDataReader lectureAuteurs = commandeAuteur.ExecuteReader();
            while (lectureAuteurs.Read())
            {
                NomAuteurLivre_comboBox.Items.Add(lectureAuteurs.GetString(0));
            }
            lectureAuteurs.Close();

            string requetteCategoriesComboBox = "SELECT Nom FROM Categories";
            MySqlCommand commandeCategorie = new MySqlCommand(requetteCategoriesComboBox, Program.connection);
            MySqlDataReader lectureCategories = commandeCategorie.ExecuteReader();
            while (lectureCategories.Read())
            {
                CategorieLivre_comboBox.Items.Add(lectureCategories.GetString(0));
            }
            lectureCategories.Close();

            string requetteEditeursComboBox = "SELECT Nom FROM Editeurs";
            MySqlCommand commandeEditeur = new MySqlCommand(requetteEditeursComboBox, Program.connection);
            MySqlDataReader lectureEditeur = commandeEditeur.ExecuteReader();
            while (lectureEditeur.Read())
            {
                EditeurLivre_comboBox.Items.Add(lectureEditeur.GetString(0));
            }
            lectureEditeur.Close();


        }
        private void AfficherDonnees()
        {
            try
            {
                string requette =   "SELECT idLivres_Isbn AS ISBN, " +
                                    "Titre, " +
                                    "Auteurs.Nom AS Nom, " +
                                    "Auteurs.Prenom AS Prenom, " +
                                    "Editeurs.Nom AS Editeur, " +
                                    "Categories.Nom AS Categorie, " +
                                    "Date AS Parution, " +
                                    "Tranche_Ages AS Ages, " +
                                    "categories.Emplacement AS Emplacement, " +
                                    "Exemplaires_Disponibles AS Quantite, " +
                                    "Date_Entree_Bibliotheque AS Enregistrement " +
                                    "FROM livres " +
                                    "INNER JOIN Auteurs ON Livres.Auteurs_idAuteurs = Auteurs.idAuteurs " +
                                    "INNER JOIN Categories ON Livres.Categories_idCategories = Categories.idCategorie " +
                                    "INNER JOIN Editeurs ON Livres.Editeurs_idEditeurs = Editeurs.idEditeurs " +
                                    "WHERE Titre LIKE @Recherche " +
                                    "OR idLivres_Isbn LIKE @Recherche";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@Recherche", RechercherLivre_textBox.Text);
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
        private void Form_Livres_Load(object sender, EventArgs e)
        {
            ActualisationAuteursCategoriesEditeurs();
        }
        private void ModifierAjoutLivre_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous modifier ce livre ?", "Modifier ce livre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                try
                {
                    string TrancheAges = $"{AgeMinLivre_numericUpDown.Text}-{AgeMaxLivre_numericUpDown.Text}";
                    VerificationDoublonAuteur();
                    VerificationDoublonEditeur();
                    string requette =   "UPDATE livres " +
                                        "SET idLivres_Isbn = @newISBN, " +
                                        "Titre = @titre, " +
                                        "Date = @date, " +
                                        "Exemplaires_Disponibles = @Exemplaires_Disponibles, " +
                                        "Emplacement = ( SELECT categories.Emplacement FROM categories WHERE categories.Nom = @Categorie), " +
                                        "Auteurs_idAuteurs = (SELECT auteurs.idAuteurs FROM auteurs WHERE auteurs.Nom = @NomAuteur AND auteurs.Prenom = @PrenomAuteur), " +
                                        "Categories_idCategories = (SELECT categories.idCategorie FROM categories WHERE categories.Nom = @Categorie), " +
                                        "Editeurs_idEditeurs = (SELECT editeurs.idEditeurs FROM editeurs WHERE editeurs.Nom = @Editeur), " +
                                        "Tranche_Ages = @Tranche_Ages " +
                                        "WHERE idLivres_Isbn = @isbn";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@ISBN", ISBNModifierLivre_label.Text);
                    commande.Parameters.AddWithValue("@newISBN", ISBNLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Titre", TitreLivre_textBox.Text);
                    commande.Parameters.AddWithValue("@Date", DateParutionLivre_dateTimePicker.Text);
                    commande.Parameters.AddWithValue("@Exemplaires_Disponibles", NbExemplairesLivre_numericUpDown.Text);
                    commande.Parameters.AddWithValue("@NomAuteur", NomAuteurLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@PrenomAuteur", PrenomAuteurLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@Categorie", CategorieLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@Editeur", EditeurLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@Tranche_Ages", TrancheAges);
                    commande.ExecuteNonQuery();

                    AfficherDonnees();

                    MessageBox.Show($"Livre : {TitreLivre_textBox.Text} Modifié");

                    NettoyerChamps();
                }
                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur: {erreur.Message}");
                }
            }
        }
        private void NettoyerChamps()
        {
            ISBNModifierLivre_label.Text = "";
            ISBNLivre_textBox.Text = "";
            TitreLivre_textBox.Text = "";
            NomAuteurLivre_comboBox.Text = "";
            PrenomAuteurLivre_comboBox.Text = "";
            CategorieLivre_comboBox.Text = "";
            EditeurLivre_comboBox.Text = "";
            EmplacementLivre_textBox.Text = "";
            DateParutionLivre_dateTimePicker.Value = DateTime.Parse("1900-01-01");
            AgeMinLivre_numericUpDown.Value = 1;
            AgeMaxLivre_numericUpDown.Value = 1;
            NbExemplairesLivre_numericUpDown.Value = 1;
        }
        private void RechercherEditerLivre_button_Click(object sender, EventArgs e)
        {
            AfficherDonnees();
        }
        private void selectionnerLivre_button_click(object sender, EventArgs e)
        {
            try
            {
                ISBNModifierLivre_label.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                ISBNLivre_textBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                TitreLivre_textBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                NomAuteurLivre_comboBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                PrenomAuteurLivre_comboBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                EditeurLivre_comboBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                CategorieLivre_comboBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                DateParutionLivre_dateTimePicker.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                EmplacementLivre_textBox.Text = ResultatLivre_dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                NbExemplairesLivre_numericUpDown.Value = Convert.ToInt32(ResultatLivre_dataGridView.SelectedRows[0].Cells[9].Value);
                string[] ages = ResultatLivre_dataGridView.SelectedRows[0].Cells[7].Value.ToString().Split('-');
                AgeMinLivre_numericUpDown.Value = Convert.ToInt32(ages[0]);
                AgeMaxLivre_numericUpDown.Value = Convert.ToInt32(ages[1]);
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur ResultatLivre_dataGridView: {erreur.Message}");
            }
            AfficherDonnees();
            Livre_tabControl.SelectTab(AjoutLivre_tabPage);
        }
        private void SupprimerLivre_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous Supprimer ce livre ?", "Supprimer un livre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                try
                {
                    string requette = "DELETE FROM livres WHERE idLivres_ISBN = @ISBN";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@ISBN", ResultatLivre_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Livre : {TitreLivre_textBox.Text} Supprimé");
                    AfficherDonnees();
                    NettoyerChamps();
                }
                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur: {erreur.Message}");
                }
            }
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

                    VerificationDoublonAuteur();
                    VerificationDoublonEditeur();

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
                    commande.Parameters.AddWithValue("@PrenomAuteur", PrenomAuteurLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@Categorie", CategorieLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@Editeur", EditeurLivre_comboBox.Text);
                    commande.Parameters.AddWithValue("@Tranche_Ages", TrancheAges);
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Livre : {TitreLivre_textBox.Text} ajouté");
                    NettoyerChamps();

                }
                catch(Exception erreur)
                {
                    MessageBox.Show($"erreur lors de la validation :{erreur.Message}");
                }

            }
        }
        private void ValiderNom_button_Click(object sender, EventArgs e)
        {
            PrenomAuteurLivre_comboBox.Items.Clear();
            PrenomAuteurLivre_comboBox.Text = "";
            string requettePrenomComboBox = "SELECT Prenom FROM Auteurs WHERE Nom LIKE @nom";
            MySqlCommand commandePrenom = new MySqlCommand(requettePrenomComboBox, Program.connection);
            commandePrenom.Parameters.AddWithValue("@nom", NomAuteurLivre_comboBox.Text);
            MySqlDataReader lecturePrenoms = commandePrenom.ExecuteReader();
            while (lecturePrenoms.Read())
            {
                PrenomAuteurLivre_comboBox.Items.Add(lecturePrenoms.GetString(0));
            }
            lecturePrenoms.Close();
        }
        private void VerificationDoublonAuteur()
        {
            MySqlCommand commandeCountAuteurs = new MySqlCommand("SELECT COUNT(*) FROM Auteurs WHERE Nom LIKE @Auteur AND Prenom LIKE @Prenom", Program.connection);
            commandeCountAuteurs.Parameters.AddWithValue("@Auteur", NomAuteurLivre_comboBox.Text);
            commandeCountAuteurs.Parameters.AddWithValue("@Prenom", PrenomAuteurLivre_comboBox.Text);

            if (Convert.ToInt32(commandeCountAuteurs.ExecuteScalar()) == 0)
            {
                try
                {
                    MySqlCommand commandeAjoutAuteur = new MySqlCommand("INSERT INTO auteurs (Nom, Prenom) VALUES (@Nom, @Prenom)", Program.connection);
                    commandeAjoutAuteur.Parameters.AddWithValue("@Nom", NomAuteurLivre_comboBox.Text);
                    commandeAjoutAuteur.Parameters.AddWithValue("@Prenom", PrenomAuteurLivre_comboBox.Text);
                    commandeAjoutAuteur.ExecuteNonQuery();
                }

                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur lors de l'ajout de l'auteur : {erreur.Message}");
                }
            }
        }
        private void VerificationDoublonEditeur()
        {
            MySqlCommand commandeCountEditeurs = new MySqlCommand("SELECT COUNT(*) FROM Editeurs WHERE Nom LIKE @Editeur", Program.connection);
            commandeCountEditeurs.Parameters.AddWithValue("@Editeur", EditeurLivre_comboBox.Text);

            if (Convert.ToInt32(commandeCountEditeurs.ExecuteScalar()) == 0)
            {
                try
                {
                    MySqlCommand commandeAjoutEditeur = new MySqlCommand("INSERT INTO Editeurs (Nom) VALUES (@Nom)", Program.connection);
                    commandeAjoutEditeur.Parameters.AddWithValue("@Nom", EditeurLivre_comboBox.Text);
                    commandeAjoutEditeur.ExecuteNonQuery();
                }
                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur lors de l'ajout de l'éditeur : {erreur.Message}");
                }
            }
        }
    }
}
