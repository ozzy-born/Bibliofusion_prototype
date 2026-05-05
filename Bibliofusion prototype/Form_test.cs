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

            //conString = $"server={server};uid={uid};pwd={password};database={database}";
            //conString = "server = 'localhost';uid='root';pwd='';database='bibliofusionbdd'";
        }

        private void btn_testco_Click(object sender, EventArgs e)
        {
            
            /*
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
                MessageBox.Show($"erreur : {erreur.Message}");
            }
            */
        }
    }
}
