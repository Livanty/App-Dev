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
    public partial class ftshirt : Form
    {
        Form1 form1;
        public ftshirt(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }


        int h = 1;
        
        
        

        private void btn_tshirt1_Click_1(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargatshirtkerahbulat.Text);
            
            form1.updateData(tshirtkerahbulat.Text, h, harga);
        }
        
        private void ftshirt_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_tshirt2_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargatshirtkerahbulat2.Text);

            form1.updateData(tshirtkerahbulathijau.Text, h, harga);
        }

        private void btn_tshirt3_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(hargatshirtbiru.Text);

            form1.updateData(tshirtbiru.Text, h, harga);
        }
    }
}
