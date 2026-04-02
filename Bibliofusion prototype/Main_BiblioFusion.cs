using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Bibliofusion_prototype
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nouvelEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Adherent formAdherant = new Form_Adherent();
            formAdherant.ShowDialog();
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Livre formLivre = new Form_Livre();
            formLivre.ShowDialog();
        }

        private void jouetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Jouet formjouet = new Form_Jouet();
            formjouet.ShowDialog();
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Categories formCategorie = new Form_Categories();
            formCategorie.ShowDialog();
        }

        private void adhérantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Adherent formAdherent = new Form_Adherent();
            formAdherent.ShowDialog();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Classes formClasses = new Form_Classes();
            formClasses.ShowDialog();
        }

        private void administateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Administrateurs formAdmin = new Form_Administrateurs();
            formAdmin.ShowDialog();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Connexion formConnexion = new Form_Connexion();
            formConnexion.ShowDialog();
            MainForm.ActiveForm.Close();
        }
    }
}
