using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W8_Lvanty_ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fplayer f_player = new fplayer();
            f_player.Dock = DockStyle.Fill;
            f_player.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(f_player);
            f_player.Show();
        }

        private void showMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmatch f_match = new fmatch();
            f_match.Dock = DockStyle.Fill;
            f_match.TopLevel = false;
            panel1.Controls.Clear();
            this.panel1.Controls.Add(f_match);
            f_match.Show();
        }
    }
}
