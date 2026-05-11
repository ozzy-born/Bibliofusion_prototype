using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Package1;

namespace Bibliofusion_prototype
{
    public partial class Form_test : Form
    {

        private readonly string server, uid, password, database, conString;
        public readonly MySqlConnection connection;
        public Form_test()
        {
            InitializeComponent();
            server = ConfigurationManager.AppSettings["ServerName"];
            uid = ConfigurationManager.AppSettings["UserId"];
            password = ConfigurationManager.AppSettings["Password"];
            database = ConfigurationManager.AppSettings["DataBase"];

            conString = $"server={server};uid={uid};pwd={password};database={database}";    //conString = "server = 'localhost';uid='root';pwd='';database='bibliofusionbdd'";

            SGBD sgbd = new SGBD(conString);
            connection = new MySqlConnection(conString);
            sgbd.connect();

            DataGrid();
        }
        private void DataGrid()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conString);
                connection.Open();
                string requette = "SELECT * FROM adherents";
                MySqlCommand commande = new MySqlCommand(requette, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commande);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception erreur){ 
                MessageBox.Show($"Erreur datagrid: {erreur}");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataGrid();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conString);

                connection.Open();
                string requette = "UPDATE adherents SET Nom = @nom, Adresse = @adresse, Date_Naissance = @date WHERE idAdherents = @id";
                MySqlCommand commande = new MySqlCommand(requette, connection);
                commande.Parameters.AddWithValue("@id", tb_id.Text);
                commande.Parameters.AddWithValue("@nom", tb_nom.Text);
                commande.Parameters.AddWithValue("@adresse", tb_adresse.Text);
                commande.Parameters.AddWithValue("@date", date_naissance.Text);
                commande.ExecuteNonQuery();
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur: {erreur.Message}");
            }

            DataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                date_naissance.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_adresse.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur dataGridView1_CellClick: {erreur.Message}");
            }
            DataGrid();
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conString);
                connection.Open();
                string requette = "DELETE FROM adherents WHERE idAdherents = @id";
                MySqlCommand commande = new MySqlCommand(requette, connection);
                commande.Parameters.AddWithValue("@id", tb_id.Text);
                commande.ExecuteNonQuery();
            }
            catch ( Exception erreur)
            {
                MessageBox.Show($"Erreur btn_suppr_click: {erreur.Message}");
            }
            DataGrid();
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection connection = new MySqlConnection(conString);
                connection.Open();
                string requette = "SELECT * FROM adherents WHERE Nom = @nom AND Adresse = @adresse AND Date_Naissance = @date";
                MySqlCommand commande = new MySqlCommand(requette, connection);
                commande.Parameters.AddWithValue("@nom", tb_nom.Text);
                commande.ExecuteNonQuery();
                MessageBox.Show($"{tb_nom.Text}\n{tb_adresse.Text}\n{date_naissance.Text}\nAjouté avec succès!");
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur btn_recherche_click: {erreur.Message}");
            }
            btn_res_Click(sender, e);
            DataGrid();
        }
        

        private void btn_res_Click(object sender, EventArgs e)
        {
            tb_recherche.Clear();
            tb_id.Clear();
            tb_nom.Clear();
            tb_adresse.Clear();

        }

        

        private void btn_ajout_Click(object sender, EventArgs e)
        {
             try
            {
                string requette = "INSERT INTO adherents (Nom, Adresse,Date_Naissance) VALUES (@nom, @adresse, @date)";
                MySqlCommand commande = new MySqlCommand(requette, connection);

                commande.Parameters.AddWithValue("@nom", tb_nom.Text);
                commande.Parameters.AddWithValue("@adresse", tb_adresse.Text);
                commande.Parameters.AddWithValue("@date", date_naissance.Text);
                commande.ExecuteNonQuery();


                MessageBox.Show($"{tb_nom.Text}\n{tb_adresse.Text}\n{date_naissance.Text}\nAjouté avec succès!");
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur btn_ajout_click: {erreur.Message}");
            }
            btn_res_Click(sender, e);
            DataGrid();
        }

        private void btn_testco_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                MySqlConnection connection = new MySqlConnection(conString);
                connection.Open();
                MessageBox.Show("Connection résusie!");
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur btn_textco_click: {erreur.Message}");
            }
            DataGrid();
        }
    }
}
