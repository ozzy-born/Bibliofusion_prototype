using QRcode_generator;
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
        public static int nPage;
        public MainForm()
        {
            InitializeComponent();
        }

        private void NouvelEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nPage = 1;
            Form_Emprunts form_Emprents = new Form_Emprunts();
            form_Emprents.ShowDialog();

        }
        private void enregisterUnRetourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nPage = 2;
            Form_Emprunts form_Emprents = new Form_Emprunts();
            form_Emprents.ShowDialog();
        }

        private void reserverUnArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nPage = 3;
            Form_Emprunts form_Emprents = new Form_Emprunts();
            form_Emprents.ShowDialog();
        }

        private void LivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Livres formLivre = new Form_Livres();
            formLivre.ShowDialog();
        }

        private void JouetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Jouets formjouet = new Form_Jouets();
            formjouet.ShowDialog();
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Categories formCategorie = new Form_Categories();
            formCategorie.ShowDialog();
        }

        private void AdherantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Adherents formAdherent = new Form_Adherents();
            formAdherent.ShowDialog();
        }

        private void ClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Classes formClasses = new Form_Classes();
            formClasses.ShowDialog();
        }

        private void AdministateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Administrateurs formAdmin = new Form_Administrateurs();
            formAdmin.ShowDialog();
        }

        private void DeconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Connexion formConnexion = new Form_Connexion();
            formConnexion.ShowDialog();
        }

        private void qRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CodeQr formQrCode = new Form_CodeQr();
            formQrCode.ShowDialog();
        }
    }
}
