using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class perhiasan : Form
    {
        Form1 form1;
        public perhiasan(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void perhiasan_Load(object sender, EventArgs e)
        {

        }
        int h =1;
        private void btn_tshirt1_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargaperhiasan1.Text);

            form1.updateData(perhiasan1.Text, h, harga);
        }

        private void btn_tshirt2_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargaperhiasan2.Text);

            form1.updateData(perhiasan2.Text, h, harga);
        }

        private void btn_tshirt3_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargaperhiasan3.Text);

            form1.updateData(perhiasan3.Text, h, harga);
        }
    }
}
