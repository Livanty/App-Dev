using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W7_Latihan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_food f_food = new form_food();           
            f_food.Dock = DockStyle.Fill;
            f_food.TopLevel = false;
            this.panel1.Controls.Add(f_food);
            f_food.Show();
        }

        private void snackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
