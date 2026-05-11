using MySql.Data.MySqlClient;
using Package1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Bibliofusion_prototype
{
    internal static class Program
    {

        public static bool IsAuthenticated = false;
        public static string server = ConfigurationManager.AppSettings["ServerName"];
        public static string uid = ConfigurationManager.AppSettings["UserId"];
        public static string password = ConfigurationManager.AppSettings["Password"];
        public static string database = ConfigurationManager.AppSettings["DataBase"];
        public static string conString = $"server={server};uid={uid};pwd={password};database={database}";
        public static MySqlConnection connection = new MySqlConnection(conString);
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            connection.Open();

            Form_test Formtest = new Form_test();
            Formtest.ShowDialog();
            while (true)
            {
                Form_Connexion FormulaireConnection = new Form_Connexion();
                if (FormulaireConnection.ShowDialog() == DialogResult.OK)
                    { break; }
            }
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
