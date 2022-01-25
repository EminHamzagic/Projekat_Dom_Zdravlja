using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekat_Dom_Zdravlja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pacijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pacijent Pacijent = new frm_Pacijent();
            Pacijent.Show();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Doktori Doktori = new frm_Doktori();
            Doktori.Show();
        }

        private void zdrastveniKartoniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Lecenja Lecenja = new frm_Lecenja();
            Lecenja.Show();
        }

        private void dijagnozeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Dijagnoze Dijagnoze = new frm_Dijagnoze();
            Dijagnoze.Show();
        }

        private void preglediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pregledi Pregledi = new frm_Pregledi();
            Pregledi.Show();
        }
    }
}
