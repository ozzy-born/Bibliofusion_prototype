using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Bibliofusion_prototype
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (Form_Connexion loginForm = new Form_Connexion())
                {
                    // Si l'utilisateur annule -> quitter
                    if (loginForm.ShowDialog() != DialogResult.OK)
                        break;
                }

                using (MainForm mainForm = new MainForm())
                {
                    Application.Run(mainForm);
                }
            }
        }
    }
}