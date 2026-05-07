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
        public Form_test()
        {
            InitializeComponent();
            SGBD SGBD = new SGBD();
            server = ConfigurationManager.AppSettings["ServerName"];
            uid = ConfigurationManager.AppSettings["UserId"];
            password = ConfigurationManager.AppSettings["Password"];
            database = ConfigurationManager.AppSettings["DataBase"];

            conString = $"server={server};uid={uid};pwd={password};database={database}";
            //conString = "server = 'localhost';uid='root';pwd='';database='bibliofusionbdd'";

            DataGrid();
        }
        private void DataGrid()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "SELECT * FROM adherents";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception erreur){ 
                MessageBox.Show($"Erreur : {erreur}");
            }
        }
        private void btn_recherche_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "SELECT * FROM adherents WHERE Nom = @nom AND Adresse = @adresse AND Date_Naissance = @date";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@nom", tb_nom.Text);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show($"{tb_nom.Text}\n{tb_adresse.Text}\n{date_naissance.Text}\nAjouté avec succès!");
                    }
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur : {erreur.Message}");
            }
            btn_res_Click(sender, e);
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
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "INSERT INTO adherents (Nom, Adresse,Date_Naissance) VALUES (@nom, @adresse, @date)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@nom", tb_nom.Text);
                        cmd.Parameters.AddWithValue("@adresse", tb_adresse.Text);
                        cmd.Parameters.AddWithValue("@date", date_naissance.Text);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show($"{tb_nom.Text}\n{tb_adresse.Text}\n{date_naissance.Text}\nAjouté avec succès!");
                    }
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur : {erreur.Message}");
            }
            btn_res_Click(sender, e);
        }

        private void btn_testco_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    MessageBox.Show("Connection résusie!");
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show($"Erreur : {erreur.Message}");
            }
            
        }
    }
}
