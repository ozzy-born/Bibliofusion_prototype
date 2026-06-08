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
    public partial class Form_Adherents : Form
    {
        public static string Nom, Prenom, DateNaissance, Email, Mobile, Fixe, Adresse, Classe;
        public static int CodePostal;

        public Form_Adherents()
        {
            InitializeComponent();
            ResponsableAdherent_tabPage.Enabled = false;
            Classe_tabPage.Enabled = false;
            SupprClasse_label.Hide();
        }

        private void AdherentValider_button_Click(object sender, EventArgs e)
        {
            DialogResult verfication = MessageBox.Show("Voulez-vous ajouter cet adhérent ?", "Nouvel adhérent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verfication == DialogResult.Yes)
            {
                if (Mineur_checkBox.Checked == true)
                {
                    AjoutAdherentResponsable();
                }
                else
                {
                    AjoutAdherentsansResponsable();
                }
            }
        }
        private void AfficherDonneesAdherents()
        {
            try
            {
                string requette = "SELECT idAdherents AS id, " +
                                    "Nom, " +
                                    "Prenom, " +
                                    "Date_Naissance AS Naissance, " +
                                    "Adresse, Code_Postal AS CP, " +
                                    "Email, Num_Mobile AS Mobile, " +
                                    "Num_Fixe AS Fixe " +
                                    "FROM adherents " +
                                    "WHERE Nom LIKE @recherche " +
                                    "OR Prenom LIKE @recherche " +
                                    "OR idAdherents LIKE @recherche";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@recherche", RechercherAdherant_textBox.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commande);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ResultatAdherent_dataGridView.DataSource = table;
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur datagrid: {erreur}");
            }
        }
        private void AfficherDonneesResponsables()
        {
            try
            {
                string requette = "SELECT idAdherents AS id, " +
                                    "Nom, " +
                                    "Prenom " +
                                    "FROM adherents " +
                                    "WHERE Nom LIKE @recherche " +
                                    "OR Prenom LIKE @recherche " +
                                    "OR idAdherents LIKE @recherche";
                MySqlCommand commande = new MySqlCommand(requette, Program.connection);
                commande.Parameters.AddWithValue("@recherche", RechercherResponsableAdherent_textBox.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commande);
                DataTable table = new DataTable();
                adapter.Fill(table);
                RechercherResponsableAdherent_dataGridView.DataSource = table;
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur datagrid: {erreur}");
            }
        }
        private void AjoutAdherentsansResponsable()
        {
            string requette = "INSERT INTO adherents (Nom, Prenom, Date_Naissance, Adresse, Code_Postal, Email, Num_Mobile, Num_Fixe) " +
                                "VALUES (@Nom, @Prenom, @DateNaissance, @Adresse, @CodePostal, @Email, @Mobile, @Fixe)";
            MySqlCommand commande = new MySqlCommand(requette, Program.connection);
            commande.Parameters.AddWithValue("@Nom", NomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Prenom", PrenomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@DateNaissance", NaissanceAdherent_dateTimePicker.Value);
            commande.Parameters.AddWithValue("@Adresse", AdresseAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@CodePostal", CodePostalAdherent_numericUpDown.Value.ToString());
            commande.Parameters.AddWithValue("@Email", MailAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Mobile", MobileAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Fixe", FixeAdherent_textBox.Text);
            commande.ExecuteNonQuery();
        }
        private void AjoutAdherentResponsable()
        {
            string requette = "INSERT INTO adherents (Nom, Prenom, Date_Naissance, Adresse, Code_Postal, Email, Num_Mobile, Num_Fixe,  Adherents_idAdherents_Responsable1, Adherents_idAdherents_Responsable2) " +
                                "VALUES (@Nom, @Prenom, @DateNaissance, @Adresse, @CodePostal, @Email, @Mobile, @Fixe,@Responsable1, @Responsable2)";
            MySqlCommand commande = new MySqlCommand(requette, Program.connection);
            commande.Parameters.AddWithValue("@Nom", NomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Prenom", PrenomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@DateNaissance", NaissanceAdherent_dateTimePicker.Value);
            commande.Parameters.AddWithValue("@Adresse", AdresseAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@CodePostal", CodePostalAdherent_numericUpDown.Value.ToString());
            commande.Parameters.AddWithValue("@Email", MailAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Mobile", MobileAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Fixe", FixeAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Responsable1", Responsable1Adherent_textBox.Text);
            commande.Parameters.AddWithValue("@Responsable2", Responsable2Adherent_textBox.Text);
            commande.ExecuteNonQuery();
        }
        private void AjoutResponsableAdherent_button_Click(object sender, EventArgs e)
        {
            try
            {
                string valeur = RechercherResponsableAdherent_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (Responsable1Adherent_textBox.Text == "")
                {
                    Responsable1Adherent_textBox.Text = valeur;
                }
                else if (Responsable2Adherent_textBox.Text == "")
                {
                    Responsable2Adherent_textBox.Text = valeur;
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur ResultatAdherent_dataGridView: {erreur.Message}");
            }
        }
        private void Eleve_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Eleve_checkBox.Checked == true)
            {
                Classe_tabPage.Enabled = true;
            }
            else
            {
                Classe_tabPage.Enabled = false;
            }
        }
        private void Mineur_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Mineur_checkBox.Checked == true)
            {
                ResponsableAdherent_tabPage.Enabled = true;
            }
            else
            {
                ResponsableAdherent_tabPage.Enabled = false;
            }
        }
        private void ModifierAdherentSansResponsable()
        {

            string requette = "UPDATE Adherents " +
                                "SET Nom = @Nom, " +
                                "Prenom = @Prenom, " +
                                "Date_Naissance = @DateNaissance, " +
                                "Adresse = @Adresse, " +
                                "Code_Postal = @CodePostal, " +
                                "Email = @Email, " +
                                "Num_Mobile = @Mobile, " +
                                "Num_Fixe = @Fixe " +
                                "WHERE idAdherents = @id";
            MySqlCommand commande = new MySqlCommand(requette, Program.connection);

            commande.Parameters.AddWithValue("@id", idModifierAdherent_label.Text);
            commande.Parameters.AddWithValue("@Nom", NomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Prenom", PrenomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@DateNaissance", NaissanceAdherent_dateTimePicker.Text);
            commande.Parameters.AddWithValue("@Adresse", AdresseAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@CodePostal", CodePostalAdherent_numericUpDown.Text);
            commande.Parameters.AddWithValue("@Email", MailAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Mobile", MobileAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Fixe", FixeAdherent_textBox.Text);
            commande.ExecuteNonQuery();
        }
        private void ModifierAdherentAvecResponsable()
        {
            string requette = "UPDATE Adherents " +
                                "SET Nom = @Nom, " +
                                "Prenom = @Prenom, " +
                                "Date_Naissance = @DateNaissance, " +
                                "Adresse = @Adresse, " +
                                "Code_Postal = @CodePostal, " +
                                "Email = @Email, " +
                                "Num_Mobile = @Mobile, " +
                                "Num_Fixe = @Fixe, " +
                                "Adherents_idAdherents_Responsable1 = @Responsable1, " +
                                "Adherents_idAdherents_Responsable2 = @Responsable2 " +
                                "WHERE idAdherents = @id";
            MySqlCommand commande = new MySqlCommand(requette, Program.connection);
            commande.Parameters.AddWithValue("@id", idModifierAdherent_label.Text);
            commande.Parameters.AddWithValue("@Nom", NomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Prenom", PrenomAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@DateNaissance", NaissanceAdherent_dateTimePicker.Text);
            commande.Parameters.AddWithValue("@Adresse", AdresseAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@CodePostal", CodePostalAdherent_numericUpDown.Text);
            commande.Parameters.AddWithValue("@Email", MailAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Mobile", MobileAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Fixe", FixeAdherent_textBox.Text);
            commande.Parameters.AddWithValue("@Responsable1", Responsable1Adherent_textBox.Text);
            commande.Parameters.AddWithValue("@Responsable2", Responsable2Adherent_textBox.Text);
            commande.ExecuteNonQuery();
        }
        private void ModifierAjoutAdherent_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous modifier cet Adhérent ?", "Modifier Adhérent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                try
                {
                    if (Mineur_checkBox.Checked == true)
                    {
                        ModifierAdherentAvecResponsable();
                    }
                    else
                    {
                        ModifierAdherentSansResponsable();
                    }
                    AfficherDonneesAdherents();

                    MessageBox.Show($"Adhérent : {NomAdherent_textBox.Text} {PrenomAdherent_textBox.Text} Modifié");

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
            idModifierAdherent_label.Text = "";
            NomAdherent_textBox.Clear();
            PrenomAdherent_textBox.Clear();
            NaissanceAdherent_dateTimePicker.Value = DateTime.Parse("1900-01-01");
            AdresseAdherent_textBox.Clear();
            CodePostalAdherent_numericUpDown.Value = 0;
            MailAdherent_textBox.Clear();
            MobileAdherent_textBox.Clear();
            FixeAdherent_textBox.Clear();
            Responsable1Adherent_textBox.Clear();
            Responsable2Adherent_textBox.Clear();
        }
        private void RechercherEditerAdherent_button_Click(object sender, EventArgs e)
        {
            AfficherDonneesAdherents();
        }
        private void RechercherAjoutAdherent_button_Click(object sender, EventArgs e)
        {
            AfficherDonneesResponsables();
        }
        private void selectionnerAdherent_button_Click(object sender, EventArgs e)
        {
            try
            {
                idModifierAdherent_label.Text = ResultatAdherent_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                NomAdherent_textBox.Text = ResultatAdherent_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                PrenomAdherent_textBox.Text = ResultatAdherent_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                NaissanceAdherent_dateTimePicker.Value = Convert.ToDateTime(ResultatAdherent_dataGridView.SelectedRows[0].Cells[3].Value);
                AdresseAdherent_textBox.Text = ResultatAdherent_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                CodePostalAdherent_numericUpDown.Value = Convert.ToInt32(ResultatAdherent_dataGridView.SelectedRows[0].Cells[5].Value);
                MailAdherent_textBox.Text = ResultatAdherent_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                MobileAdherent_textBox.Text = ResultatAdherent_dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                FixeAdherent_textBox.Text = ResultatAdherent_dataGridView.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur ResultatAdherent_dataGridView: {erreur.Message}");
            }
            AfficherDonneesAdherents();
            Adherent_tabControl.SelectTab(AjoutAdherent_tabPage);
        }
        private void SupprimerLivre_button_Click(object sender, EventArgs e)
        {
            DialogResult verification = MessageBox.Show("Voulez-vous Supprimer cet Adhérent ?", "Supprimer un adhérent", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verification == DialogResult.Yes)
            {
                try
                {
                    string requette = "DELETE FROM adherents WHERE idAdherents = @id";
                    MySqlCommand commande = new MySqlCommand(requette, Program.connection);

                    commande.Parameters.AddWithValue("@id", ResultatAdherent_dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    commande.ExecuteNonQuery();

                    MessageBox.Show($"Adhérent N° {ResultatAdherent_dataGridView.SelectedRows[0].Cells[0].Value.ToString()} Supprimé");
                    AfficherDonneesAdherents();
                }
                catch (Exception erreur)
                {
                    MessageBox.Show($"Erreur: {erreur.Message}");
                }
            }
        }
        private void SupprClasse_label_Click(object sender, EventArgs e)
        {
            Classe_label.Text = "Classe";
            SupprClasse_label.Hide();
        }
    }
}
