using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendeYe
{
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menuform = new Form1();
            menuform.Show();
        }
    }
}
