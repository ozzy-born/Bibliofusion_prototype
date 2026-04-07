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
    public partial class Form_Emprunts : Form
    {
        public Form_Emprunts()
        {
            InitializeComponent();
            if (MainForm.nPage == 1)
            {
                Emprunts_tabControl.SelectTab(NouvelEmprunt_tabPage);
            }
            else if (MainForm.nPage == 2)
            {
                Emprunts_tabControl.SelectTab(EnregistrerUnRetour_tabPage);
            }
            else if (MainForm.nPage == 3)
            {
                Emprunts_tabControl.SelectTab(ReserverUnArticle_tabPage);
            }
        }
    }
}
