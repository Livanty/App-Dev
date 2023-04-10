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
    public partial class shirt : Form
    {
        Form1 form1;
        public shirt(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        int h = 1;
        private void shirt_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_tshirt1_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargabajuhitam.Text);

            form1.updateData(baju1.Text, h, harga);
        }

        private void btn_tshirt2_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargabajuhijau.Text);

            form1.updateData(baju2.Text, h, harga);
        }

        private void btn_tshirt3_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargabajubiru.Text);

            form1.updateData(baju3.Text, h, harga);
        }
    }
}
