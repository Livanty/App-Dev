using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_child f_child = new Form_child();
            // f_child.MdiParent = this;
            f_child.Dock = DockStyle.Fill;
            f_child.TopLevel = false;
            this.panel1.Controls.Add(f_child);
            f_child.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
                Form_childkanan f_childK = new Form_childkanan();
                // f_child.MdiParent = this;
                f_childK.Dock = DockStyle.Fill;
                f_childK.TopLevel = false;
                this.panel2.Controls.Add(f_childK);
                f_childK.Show();
            
        }
    }
}
