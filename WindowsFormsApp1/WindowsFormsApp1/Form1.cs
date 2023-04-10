using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tShirtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ftshirt tshirt = new ftshirt(this);
            // f_child.MdiParent = this;
            tshirt.Dock = DockStyle.Fill;
            tshirt.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(tshirt);
            tshirt.Show();
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shirt shirt = new shirt(this);
            // f_child.MdiParent = this;
            shirt.Dock = DockStyle.Fill;
            shirt.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(shirt);
            shirt.Show();
        }

        internal DataTable dtnota = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dtnota.Columns.Add("Item");
            dtnota.Columns.Add("Qty");
            dtnota.Columns.Add("Price");
            dtnota.Columns.Add("Total");
 
            dgv.DataSource = dtnota;
        }
        
        public void updateData(string nama, int qty, int price)
        {
            bool cek = true;
            int subtotal = 0;
            int totall = 0;
            foreach (DataRow i in dtnota.Rows )
            {
                if (nama == i[0].ToString())
                {
                    cek = false;
                    i[1] = Convert.ToInt32(i[1]) + 1;
                    i[3] = Convert.ToInt32(i[1]) * Convert.ToInt32(i[2]);
                    break;
                }                                  
                
            }
            if (cek == true)
            {
                dtnota.Rows.Add(nama, qty, price, price * qty);
            }


            foreach (DataRow i in dtnota.Rows)
            {
                subtotal += Convert.ToInt32(i[3]);
                label3.Text = subtotal.ToString();

            }
            totall = subtotal * 10 / 100 + subtotal;
            label4.Text= totall.ToString();

        }

        private void pantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celana1 shirt = new celana1(this);
            // f_child.MdiParent = this;
            shirt.Dock = DockStyle.Fill;
            shirt.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(shirt);
            shirt.Show();
        }

        private void skirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_skirt shirt = new f_skirt(this);
            // f_child.MdiParent = this;
            shirt.Dock = DockStyle.Fill;
            shirt.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(shirt);
            shirt.Show();
        }

        private void jewelleriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perhiasan shirt = new perhiasan(this);
            // f_child.MdiParent = this;
            shirt.Dock = DockStyle.Fill;
            shirt.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(shirt);
            shirt.Show();
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shoes shirt = new shoes(this);
            // f_child.MdiParent = this;
            shirt.Dock = DockStyle.Fill;
            shirt.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(shirt);
            shirt.Show();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.ToString() == "0")
            {
                MessageBox.Show("piu");
                dtnota.Rows.RemoveAt(dgv.CurrentCell.RowIndex);
            }

        }
    }
}
