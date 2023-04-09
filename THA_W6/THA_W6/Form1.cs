using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static int input;
        private void button1_Click(object sender, EventArgs e)
        {
            bool containsstring = int.TryParse(txt_isi.Text, out int n);
            if (containsstring == true && Convert.ToInt32(txt_isi.Text) > 3)
            {
                input = Convert.ToInt32(txt_isi.Text);
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Harus angka dan Lebih besar dari tiga");
                txt_isi.Clear();
            }
        }
    }
}
