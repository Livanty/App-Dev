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
    public partial class f_skirt : Form
    {
        Form1 form1;
        public f_skirt(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        int h = 1;
        private void f_skirt_Load(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargacelana1.Text);

            form1.updateData(celana1.Text, h, harga);
        }

        private void btn_tshirt2_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargacelana2.Text);

            form1.updateData(celana2.Text, h, harga);
        }

        private void btn_tshirt3_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargacelana3.Text);

            form1.updateData(celana3.Text, h, harga);
        }
    }
}
