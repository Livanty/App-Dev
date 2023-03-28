using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W3_Livanty_ED_W3
{
    
    public partial class MainWindowForm : Form
    {
        public static MainWindowForm Instance2;
        public TextBox tbx;
        public MainWindowForm()
        {
            InitializeComponent();
           Instance2= this;
            tbx = textBox_name;
        }

        private void checkBox_allofthe_CheckedChanged(object sender, EventArgs e)
        {
           
            if (Application.OpenForms.OfType<SecondWindowForm>().Any() && checkBox_allofthe.Checked)
            {
                button_submit.Enabled = true;
            }                   
            else
            {
                button_submit.Enabled = false;
            }
            

        }
      
    private void button_opennextform_Click(object sender, EventArgs e)
        {
            SecondWindowForm form = new SecondWindowForm();
            form.Show();            

        }

      
        private void button_submit_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "") 
            {
                MessageBox.Show("Harus Ada Input Nama", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox_myfavartist.Text == "") 
            {
                MessageBox.Show("Harus Ada Input Nama Artist ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            else
            {
                SecondWindowForm.instance.lbl.Text = "Hi, my name is " + textBox_name.Text + " and my favorite artist is " + textBox_myfavartist.Text;
            }
            
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
