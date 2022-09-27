using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Nuevo = new Form2();

            Nuevo.MdiParent = this;

            Nuevo.Show();

           
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Nuevo = new Form3();

            Nuevo.MdiParent = this;

            Nuevo.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Nuevo = new Form4();

            Nuevo.MdiParent = this;

            Nuevo.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Nuevo = new Form5();

            Nuevo.MdiParent = this;

            Nuevo.Show();
        }
    }
}
