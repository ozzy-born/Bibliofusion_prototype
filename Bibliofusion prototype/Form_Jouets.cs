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
        public static int AgeMinJouet, AgeMaxJouet, NbExemplaires;

        public Form_Jouets()
        {
            InitializeComponent();
        }


        private void ActualisationCategories()
        {
            string requetteCategoriesComboBox = "SELECT Nom FROM Categories";
            MySqlCommand commandeAuteur = new MySqlCommand(requetteCategoriesComboBox, Program.connection);
            MySqlDataReader lectureCategories = commandeAuteur.ExecuteReader();
            while (lectureCategories.Read())
            {
                CategorieJouet_comboBox.Items.Add(lectureCategories.GetString(0));
            }
            lectureCategories.Close();
        }
        private void AfficherDonnees()
        {
            try
            {
                string requette =   "SELECT idJouets_Code_Barre AS ID, " +
                                    "jouets.Nom, " +
                                    "Marque, " +
                                    "categories.Nom AS Categorie, " +
                                    "Date_Mise_En_Vente AS Date, " +
                                    "Tranche_Ages AS Ages, " +
                                    "categories.Emplacement AS Emplacement, " +
                                    "Exemplaires_Disponibles AS Quantite, " +
                                    "Date_Entree_Bibliotheque AS Enregistrement " +
                                    "FROM jouets " +
                                    "INNER JOIN Categories ON jouets.Categories_idCategories = categories.idCategorie " +
                                    "WHERE Jouets.Nom Like @Recherche " +
                                    "OR idJouets_Code_Barre Like @Recherche";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@Recherche", RechercherJouet_textBox.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commande);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ResultatJouet_dataGridView.DataSource = table;
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur datagrid: {erreur}");
            }
        }
        private void Form_Jouets_Load(object sender, EventArgs e)
        {
            ActualisationCategories();
        }
        private void ModifierAjoutJouet_button_Click(object sender, EventArgs e)
        {

            DialogResult verification = MessageBox.Show("Voulez-vous modifier ce jouet ?", "Modifier ce jouet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                try
                {
                    string TrancheAges = $"{AgeMinJouet_numericUpDown.Text}-{AgeMaxJouet_numericUpDown.Text}";
                    string requette =   "UPDATE Jouets " +
                                        "SET idJouets_Code_Barre = @NewCodeBarre, " +
                                        "Jouets.Nom = @Nom, " +
                                        "Marque = @Marque, " +
                                        "Date_Mise_En_Vente = @DateMiseEnVente, " +
                                        "Exemplaires_Disponibles = @ExemplairesDisponibles, " +
                                        "Emplacement = ( SELECT categories.Emplacement FROM categories WHERE categories.Nom = @Categorie), " +
                                        "Categories_idCategories = (SELECT categories.idCategorie FROM categories WHERE categories.Nom = @Categorie), " +
                                        "Tranche_Ages = @TrancheAges " +
                                        "WHERE idJouets_Code_Barre = @CodeBarre";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@CodeBarre", codeModifierJouet_label.Text);
                    commande.Parameters.AddWithValue("@NewCodeBarre", IdJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Nom", NomJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Marque", MarqueJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@DateMiseEnVente", DateVenteJouet_dateTimePicker.Text);
                    commande.Parameters.AddWithValue("@ExemplairesDisponibles", NbExemplairesJouet_numericUpDown.Text);
                    commande.Parameters.AddWithValue("@Categorie", CategorieJouet_comboBox.Text);
                    commande.Parameters.AddWithValue("@TrancheAges", TrancheAges);
                    commande.ExecuteNonQuery();

                    AfficherDonnees();

                    MessageBox.Show($"Jouet : {NomJouet_textBox.Text} Modifié");

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
            codeModifierJouet_label.Text = "";
            IdJouet_textBox.Clear();
            NomJouet_textBox.Clear();
            MarqueJouet_textBox.Text = "";
            CategorieJouet_comboBox.Text = "";
            EmplacementJouet_textBox.Clear();
            DateVenteJouet_dateTimePicker.Value = DateTime.Parse("1900-01-01");
            AgeMinJouet_numericUpDown.Value = 1;
            AgeMaxJouet_numericUpDown.Value = 1;
            NbExemplairesJouet_numericUpDown.Value = 1;
        }
        private void RechercherEditerJouet_button_Click(object sender, EventArgs e)
        {
            AfficherDonnees();
        }
        private void SelectionnerJouet_button_click(object sender, EventArgs e)
        {
            {
                try
                {
                    codeModifierJouet_label.Text = ResultatJouet_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    IdJouet_textBox.Text = ResultatJouet_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    NomJouet_textBox.Text = ResultatJouet_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    MarqueJouet_textBox.Text = ResultatJouet_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    CategorieJouet_comboBox.Text = ResultatJouet_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    DateVenteJouet_dateTimePicker.Text = ResultatJouet_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    EmplacementJouet_textBox.Text = ResultatJouet_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    NbExemplairesJouet_numericUpDown.Value = Convert.ToInt32(ResultatJouet_dataGridView.SelectedRows[0].Cells[7].Value);
                    string[] ages = ResultatJouet_dataGridView.SelectedRows[0].Cells[5].Value.ToString().Split('-');
                    AgeMinJouet_numericUpDown.Value = Convert.ToInt32(ages[0]);
                    AgeMaxJouet_numericUpDown.Value = Convert.ToInt32(ages[1]);
                }
                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur dataGridView: {erreur.Message}");
                }
                AfficherDonnees();
            }
            Jouet_tabControl.SelectTab(AjoutJouet_tabPage);
        }
        private void SupprimerJouet_button_Click(object sender, EventArgs e)
        {

            DialogResult verification = MessageBox.Show("Voulez-vous Supprimer ce jouet ?", "Supprimer un jouet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                try
                {
                    string requette = "DELETE FROM jouets WHERE idJouets_Code_Barre = @idJouets_Code_Barre";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@idJouets_Code_Barre", ResultatJouet_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Jouet : {NomJouet_textBox.Text} Supprimé");
                    AfficherDonnees();
                    NettoyerChamps();
                }
                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur: {erreur.Message}");
                }
            }
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

                    string requette =   "INSERT INTO jouets ( idJouets_Code_Barre, Nom, Marque, Date_Entree_Bibliotheque,Date_Mise_En_Vente, Emplacement, Exemplaires_Disponibles, Categories_idCategories, Tranche_Ages) " +
                                        "SELECT @idJouets_Code_Barre, @Nom, @Marque, @Date_Entree_Bibliotheque, @Date_Mise_En_Vente, categories.Emplacement, @Exemplaires_Disponibles, categories.idCategorie, @Tranche_Ages " +
                                        "FROM categories " +
                                        "WHERE categories.Nom = @Categorie ";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@idJouets_Code_Barre", IdJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Nom", NomJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Marque", MarqueJouet_textBox.Text);
                    commande.Parameters.AddWithValue("@Date_Mise_En_Vente", DateVenteJouet_dateTimePicker.Text);
                    commande.Parameters.AddWithValue("@Date_Entree_Bibliotheque", DateFormate);
                    commande.Parameters.AddWithValue("@Exemplaires_Disponibles", NbExemplairesJouet_numericUpDown.Text);
                    commande.Parameters.AddWithValue("@Categorie", CategorieJouet_comboBox.Text);
                    commande.Parameters.AddWithValue("@Tranche_Ages", TrancheAges);
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Jouet : {NomJouet_textBox.Text} ajouté");
                    NettoyerChamps();
                }
                catch (Exception erreur)
                {
                    MessageBox.Show(erreur.Message);
                }
            }
        }
    }
}
