using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
//ing System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Livanty_ED_W3
{
    public partial class SecondWindowForm : Form
    {
        public static SecondWindowForm instance;
        public Label lbl;

        

        public SecondWindowForm()
        {
            InitializeComponent();
            instance = this;
            lbl = label_swf_himyname;
            
        }



        private void checkBox_swf_iagree_CheckedChanged (object sender, EventArgs e)
        {
            if (checkBox_swf_iagree.Checked && checkBox_swf_allthechoice.Checked)
            {
                button_swf_magic.Enabled = true;
            }
            else
            {
                button_swf_magic.Enabled = false;
            }
        }
        

        private void checkBox_swf_allthechoice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_swf_iagree.Checked && checkBox_swf_allthechoice.Checked)
            {
                button_swf_magic.Enabled = true;
            }
            else
            {
                button_swf_magic.Enabled = false;
            }
        }


        private void button_swf_magic_Click(object sender, EventArgs e)
        {
            if (!radioButton_blue.Checked && !radioButton_green.Checked && !radioButton_purple.Checked && !radioButton_red.Checked && !radioButton_yellow.Checked)
            {
                MessageBox.Show(" Pilih 1 RadioButton BackColor", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!radioButton_2_darkblue.Checked && !radioButton_2_darkgray.Checked && !radioButton_2_darkred.Checked)
            {
                MessageBox.Show(" Pilih 1 RadioButton TextColor", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radioButton_green.Checked)
                {
                    MainWindowForm.Instance2.BackColor = Color.Green;
                }
                if (radioButton_blue.Checked)
                {
                    MainWindowForm.Instance2.BackColor = Color.Blue;
                }
                if (radioButton_purple.Checked)
                {
                    MainWindowForm.Instance2.BackColor = Color.Purple;
                }
                if (radioButton_red.Checked)
                {
                    MainWindowForm.Instance2.BackColor = Color.Red;
                }
                if (radioButton_yellow.Checked)
                {
                    MainWindowForm.Instance2.BackColor = Color.Yellow;
                }


                if (radioButton_2_darkblue.Checked)
                {
                    MainWindowForm.Instance2.ForeColor = Color.DarkBlue;
                }
                if (radioButton_2_darkgray.Checked)
                {
                    MainWindowForm.Instance2.ForeColor = Color.DarkGray;
                }
                if (radioButton_2_darkred.Checked)
                {
                    MainWindowForm.Instance2.ForeColor = Color.DarkRed;
                }
            }







        }
    }
}
