using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Livanty_ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_age.Text) >= 18 )
            {
                MessageBox.Show("Name: " + textBox_name.Text + "\nAge: " + textBox_age.Text + "\nEmail: " + textBox_email.Text + "\nPhone Number: "+ textBox_phonenumber.Text + "\nIs Adult");
            }
            else
            {
                MessageBox.Show("Name: " + textBox_name  + "\nAge: " + textBox_age.Text + "\nEmail: " + textBox_email.Text + "\nPhone Number: "+textBox_phonenumber.Text + "\nIs Minor");
            }
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_email.Clear();
            textBox_phonenumber.Clear();

        }
    }
}
