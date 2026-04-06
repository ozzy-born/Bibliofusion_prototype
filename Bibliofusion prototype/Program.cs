using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Bibliofusion_prototype
{
    internal static class Program
    {

        public static bool IsAuthenticated = false;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_Connexion formConnexion = new Form_Connexion();
            MainForm mainForm = new MainForm();
            Application.Run(formConnexion);
            if (Form_Connexion.Id == "id" && Form_Connexion.Mdp == "mdp"){
                Application.Run(mainForm);
            }
        }
    }
}
