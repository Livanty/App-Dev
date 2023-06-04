using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;

namespace THA_W7_Livanty
{
    public partial class pilihanfilm : Form
    {
        Form1 form1;
        public pilihanfilm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        string[] judulfilm = File.ReadAllText(@"..\\..\\NamaFilm.txt").Split(',');
        string[] poster = { @"..\\..\\avatar.jpg", @"..\\..\\aquaman.jpg", @"..\\..\\bighero.jpg", @"..\\..\\endgame.jpg", @"..\\..\\infinitywar.jpeg", @"..\\..\\jumanji.jpg",@"..\\..\\mariposa.jpg", @"..\\..\\minions.jpeg" };
        Label[] labelfilm;
       // Button[] buttonfilm;
        PictureBox[] pbfilm;
        public void film()
        {
            int xlabel = 25;
            int ylabel = 180;

            int xbutton = 5;
            int ybutton = 200;

            int xpb = 5;
            int ypb = 55;

            labelfilm = new Label[8];
            // buttonfilm = new Button[8];
            pbfilm = new PictureBox[8];

            Button btn_avatar = new Button();
            btn_avatar.Location = new Point(xbutton, ybutton);
            btn_avatar.Size = new Size(100, 25);
            xbutton += 110;
            btn_avatar.Text = "Pilih";
            btn_avatar.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_avatar);
            btn_avatar.Click += btnavatar_Click;

            Button btn_aquaman = new Button();
            btn_aquaman.Location = new Point(xbutton, ybutton);
            btn_aquaman.Size = new Size(100, 25);
            xbutton += 110;
            btn_aquaman.Text = "Pilih";
            btn_aquaman.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_aquaman);
            btn_aquaman.Click += btnaquaman_Click;

            Button btn_bighero = new Button();
            btn_bighero.Location = new Point(xbutton, ybutton);
            btn_bighero.Size = new Size(100, 25);
            xbutton += 110;
            btn_bighero.Text = "Pilih";
            btn_bighero.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_bighero);
            btn_bighero.Click += btnbighero_Click;

            Button btn_endgame = new Button();
            btn_endgame.Location = new Point(xbutton, ybutton);
            btn_endgame.Size = new Size(100, 25);
            xbutton += 110;
            btn_endgame.Text = "Pilih";
            btn_endgame.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_endgame);
            btn_endgame.Click += btnendgame_Click;

            Button btn_infinitywar = new Button();
            btn_infinitywar.Location = new Point(xbutton, ybutton);
            btn_infinitywar.Size = new Size(100, 25);
            xbutton += 110;
            btn_infinitywar.Text = "Pilih";
            btn_infinitywar.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_infinitywar);
            btn_infinitywar.Click += btninfinitywar_Click;

            Button btn_jumanji = new Button();
            btn_jumanji.Location = new Point(xbutton, ybutton);
            btn_jumanji.Size = new Size(100, 25);
            xbutton += 110;
            btn_jumanji.Text = "Pilih";
            btn_jumanji.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_jumanji);
            btn_jumanji.Click += btnjumanji_Click;

            Button btn_mariposa = new Button();
            btn_mariposa.Location = new Point(xbutton, ybutton);
            btn_mariposa.Size = new Size(100, 25);
            xbutton += 110;
            btn_mariposa.Text = "Pilih";
            btn_mariposa.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_mariposa);
            btn_mariposa.Click += btnmariposa_Click;

            Button btn_minions = new Button();
            btn_minions.Location = new Point(xbutton, ybutton);
            btn_minions.Size = new Size(100, 25);
            xbutton += 110;
            btn_minions.Text = "Pilih";
            btn_minions.BackColor = Color.RosyBrown;
            this.Controls.Add(btn_minions);
            btn_minions.Click += btnminions_Click;


            for (int i = 0; i < 8; i++)
            {

                labelfilm[i] = new Label();
                labelfilm[i].Location = new Point(xlabel, ylabel);
                labelfilm[i].Size = new Size(90, 100);
                xlabel += 110;
                labelfilm[i].Tag = judulfilm[i];
                labelfilm[i].Text = judulfilm[i].ToUpper();
                this.Controls.Add(labelfilm[i]);

                pbfilm[i] = new PictureBox();
                pbfilm[i].Location = new Point(xpb, ypb);
                pbfilm[i].Image = Image.FromFile(poster[i]);
                pbfilm[i].Size = new Size(100, 110);
                pbfilm[i].SizeMode = PictureBoxSizeMode.StretchImage;
                xpb += 110;
                this.Controls.Add(pbfilm[i]);

            }
        }
        private void pilihanfilm_Load(object sender, EventArgs e)
        {
            film();
            this.BackColor = Color.LightGoldenrodYellow;
        }
        private void btnavatar_Click(object sender, EventArgs e)
        {
            avatar favatar = new avatar();
            form1.setform(favatar);
          
        }

        private void btnaquaman_Click(object sender, EventArgs e)
        {
            aquaman faquaman = new aquaman();
            form1.setform(faquaman);

        }
        private void btnbighero_Click(object sender, EventArgs e)
        {
            bighero form = new bighero();
            form1.setform(form);
        }

        private void btnendgame_Click(object sender, EventArgs e)
        {
            endgame form = new endgame();
            form1.setform(form);
        }

        private void btninfinitywar_Click(object sender, EventArgs e)
        {
            infinitywar form = new infinitywar();
            form1.setform(form); 
        }
        private void btnjumanji_Click(object sender, EventArgs e)
        { 
            jumanji form = new jumanji();
            form1.setform(form);
        }
        private void btnmariposa_Click(object sender, EventArgs e)
        {
            mariposa form = new mariposa();
            form1.setform(form);
        }
        private void btnminions_Click(object sender, EventArgs e)
        {
            minions form = new minions();
            form1.setform(form);
        }
    }
}
