using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapasala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salas s = new salas();
            s, ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void salasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmSalas = new frmSalas();
            s,ShowDiaLog();
        }
    }
}
