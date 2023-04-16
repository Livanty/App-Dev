using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Livanty
{
    public partial class avatar : Form
    {
        public avatar()
        {
            InitializeComponent();
        }
        Panel panel1 = new Panel();
        List<Button> seat1 = new List<Button>();
        List<Button> seat2 = new List<Button>();
        List<Button> seat3 = new List<Button>();
        List<int> angka = new List<int>();
        Random random = new Random();     
      
        Label lbl_pilih1 = new Label();
        Label lbl_pilih2 = new Label();
        Label lbl_pilih3 = new Label();

        private void avatar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 200; i++)
            {
                angka.Add(i);
            }
            this.BackColor = Color.LightGoldenrodYellow;
            // Avatar
            PictureBox pb_avatar = new PictureBox();
            pb_avatar.Image = Image.FromFile("C:\\Users\\HP\\source\\repos\\THA_W7_Livanty\\THA_W7_Livanty\\avatar.jpg");
            pb_avatar.Location = new Point(20, 10);
            pb_avatar.Size = new Size(200, 210);
            pb_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pb_avatar);

            Label lbl_avatar = new Label();
            lbl_avatar.Text = "AVATAR";
            lbl_avatar.Location = new Point(20, 230);
            lbl_avatar.Size = new Size(150, 40);
            this.Controls.Add(lbl_avatar);


            //piuuu
            Button btn_jam1 = new Button();
            btn_jam1.Text = "09.00";
            btn_jam1.Location = new Point(230, 30);
            btn_jam1.Size = new Size(200, 40);
            btn_jam1.Click += btnjam1_Click;
            btn_jam1.BackColor= Color.Orange;
            this.Controls.Add(btn_jam1);

            Button btn_jam2 = new Button();
            btn_jam2.Text = "12.00";
            btn_jam2.Location = new Point(230, 90);
            btn_jam2.Size = new Size(200, 40);
            btn_jam2.Click += btnjam2_Click; ;
            btn_jam2.BackColor = Color.Orange;
            this.Controls.Add(btn_jam2);

            Button btn_jam3 = new Button();
            btn_jam3.Text = "15.00";
            btn_jam3.Location = new Point(230, 150);
            btn_jam3.Size = new Size(200, 40);
            btn_jam3.Click += btnjam3_Click;
            btn_jam3.BackColor = Color.Orange;
            this.Controls.Add(btn_jam3);

            // Ini kuubah
            panel1.Location = new System.Drawing.Point(485, 10);
            panel1.Size = new System.Drawing.Size(325, 340);
            panel1.BackColor = Color.LightSalmon;
            this.Controls.Add(panel1);

            Label lbl = new Label();
            lbl.Text = "//Klik Button PESAN TIKET Untuk KeHalaman Utama";
            lbl.Location = new Point(10, 338);
            lbl.Size = new Size(300, 20);
            this.Controls.Add(lbl);

        }
     
        
        private void btnjam1_Click(object sender, EventArgs e)
        {
            int hitung = 1;
            int x = 10;
            int y = 20;

            panel1.Controls.Clear();

            if (Form1.hitavatar1 == 0)
            {
                for (int i = 0; i < 70; i++)
                {
                    // MessageBox.Show("piu");
                    int random1 = random.Next(0,170); 
                    Form1.simpanavatar1.Add(random1);

                }

            }

            // ini warna nya ugaa
            Form1.hitavatar1 = 1;
            Button btnrst1 = new Button();
            btnrst1.Location = new Point(0, 0);
            btnrst1.Size = new Size(60, 20);
            btnrst1.Text = "Reset";
            panel1.Controls.Add(btnrst1);
            btnrst1.Click += btnrst1_Click;
            btnrst1.BackColor= Color.OrangeRed; 

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(x, y);
                    btn.Size = new Size(30, 25);
                    x += 30;
                    btn.Tag = angka[hitung];
                    btn.Text = hitung.ToString();
                    btn.BackColor = Color.NavajoWhite;
                    btn.Click += btn1_Click;
                    seat1.Add(btn);
                    panel1.Controls.Add(btn);
                    hitung++;
                }
                x = 10;
                y += 30;
            }
            Label lbl_layar = new Label();
            lbl_layar.Text = "Layar";
            lbl_layar.Location = new Point(145, 0);
            lbl_layar.Size = new Size(40, 40);
            panel1.Controls.Add(lbl_layar);

            for (int i = 0; i < Form1.simpanavatar1.Count; i++)
            {
                foreach (Button a in seat1)
                {
                    if (Form1.simpanavatar1[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = false;
                    }
                }
            }

            Label lbl_kursi = new Label();
            lbl_kursi.Text = "No Kursi Dipilih: ";
            lbl_kursi.Location = new Point(20, 315);
            lbl_kursi.Size = new Size(90, 30);
            panel1.Controls.Add(lbl_kursi);


            // sama INi ya
            Button btnoke1 = new Button();
            btnoke1.Location = new Point(260, 315);
            btnoke1.Size = new Size(60, 20);
            btnoke1.Text = "Pesan";
            panel1.Controls.Add(btnoke1);
            btnoke1.Click += btnoke1_Click;
            btnoke1.BackColor = Color.SpringGreen;


            lbl_pilih1.Location = new Point(109, 315);
            lbl_pilih1.Size = new Size(160, 50);
            panel1.Controls.Add(lbl_pilih1);

            kar2.Clear();
            karakter2 = "";
            lbl_pilih2.Text = "";

            kar3.Clear();
            karakter3 = "";
            lbl_pilih3.Text = "";
        }
        string karakter1;
        List<string> kar1 = new List<string>();
       
        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
            if (kar1.Contains(button.Text))
            {
                MessageBox.Show("Sudah Diklik ");
            }
            else
            {
                kar1.Add(button.Text);
                karakter1 += button.Text + ",";
            }                     
            lbl_pilih1.Text = karakter1;
                    
        }
        private void btnoke1_Click(object sender, EventArgs e)
        {
           
            foreach(var i in kar1)
            {
                Form1.simpanavatar1.Add(Convert.ToInt32(i));
            }

            for (int i = 0; i < Form1.simpanavatar1.Count; i++)
            {
                foreach (Button a in seat1)
                {
                    if (Form1.simpanavatar1[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = false;
                    }
                }
            }
            lbl_pilih1.Text = "";

        }
        private void btnrst1_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < Form1.simpanavatar1.Count; i++)
            {
                foreach (Button a in seat1)
                {
                    if (Form1.simpanavatar1[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = true;
                    }
                }
            }
            Form1.simpanavatar1.Clear();
            kar1.Clear();
            karakter1 = "";

        }
        private void btnjam2_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 20;
            int hitung = 1; 
            panel1.Controls.Clear();

            if (Form1.hitavatar2 == 0)
            {
                for (int i = 0; i < 70; i++)
                {
                    int random1 = random.Next(0, 170);
                    Form1.simpanavatar2.Add(random1);
                }
            }
            Form1.hitavatar2 = 1;
            Button btnrst2 = new Button();
            btnrst2.Location = new Point(0, 0);
            btnrst2.Size = new Size(60, 20);
            btnrst2.Text = "Reset";
            panel1.Controls.Add(btnrst2);
            btnrst2.Click += btnrst2_Click;
            btnrst2.BackColor= Color.OrangeRed;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(x, y);
                    btn.Size = new Size(30, 25);
                    x += 30;
                    btn.Tag = angka[hitung];
                    btn.Text = hitung.ToString();
                    btn.BackColor = Color.NavajoWhite;
                    btn.Click += btn2_Click;
                    seat2.Add(btn);
                    panel1.Controls.Add(btn);
                    hitung++;
                }
                x = 10;
                y += 30;
            }
            Label lbl_layar = new Label();
            lbl_layar.Text = "Layar";
            lbl_layar.Location = new Point(145, 0);
            lbl_layar.Size = new Size(40, 40);
            panel1.Controls.Add(lbl_layar);

            for (int i = 0; i < Form1.simpanavatar2.Count; i++)
            {
                foreach (Button a in seat2)
                {
                    if (Form1.simpanavatar2[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = false;
                    }
                }
            }

            Label lbl_kursi = new Label();
            lbl_kursi.Text = "No Kursi Dipilih: ";
            lbl_kursi.Location = new Point(20, 315);
            lbl_kursi.Size = new Size(90, 30);
            panel1.Controls.Add(lbl_kursi);

            Button btnoke2 = new Button();
            btnoke2.Location = new Point(260, 315);
            btnoke2.Size = new Size(60, 20);
            btnoke2.Text = "Pesan";
            panel1.Controls.Add(btnoke2);
            btnoke2.Click += btnoke2_Click;
            btnoke2.BackColor= Color.SpringGreen;

            lbl_pilih2.Location = new Point(109, 315);
            lbl_pilih2.Size = new Size(160, 50);
            panel1.Controls.Add(lbl_pilih2);

            kar1.Clear();
            karakter1 = "";
            lbl_pilih1.Text = "";

            kar3.Clear();
            karakter3 = "";
            lbl_pilih3.Text = "";
        }
        string karakter2;
        List<string> kar2= new List<string>();

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (kar2.Contains(button.Text))
            {
                MessageBox.Show("Sudah Diklik ");
            }
            else
            {
                kar2.Add(button.Text);
                karakter2 += button.Text + ",";
            }
            lbl_pilih2.Text = karakter2;

        }
        private void btnoke2_Click(object sender, EventArgs e)
        {

            foreach (var i in kar2)
            {
                Form1.simpanavatar2.Add(Convert.ToInt32(i));
            }

            for (int i = 0; i < Form1.simpanavatar2.Count; i++)
            {
                foreach (Button a in seat2)
                {
                    if (Form1.simpanavatar2[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = false;
                    }
                }
            }
            lbl_pilih2.Text = "";

        }

        private void btnrst2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.simpanavatar2.Count; i++)
            {
                foreach (Button a in seat2)
                {
                    if (Form1.simpanavatar2[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = true;
                    }
                }
            }
            Form1.simpanavatar2.Clear();
            kar2.Clear();
            karakter2 = "";

        }

        private void btnjam3_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 20;
            int hitung = 1;
            panel1.Controls.Clear();
  
            if (Form1.hitavatar3 == 0)
            {
                for (int i = 0; i < 70; i++)
                {
                    int random1 = random.Next(0, 170);
                    Form1.simpanavatar3.Add(random1);
                }
            }
            Form1.hitavatar3 = 1;

            Button btnrst3 = new Button();
            btnrst3.Location = new Point(0, 0);
            btnrst3.Size = new Size(60, 20);
            btnrst3.Text = "Reset";
            panel1.Controls.Add(btnrst3);
            btnrst3.Click += btnrst3_Click;
            btnrst3.BackColor = Color.OrangeRed;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(x, y);
                    btn.Size = new Size(30, 25);
                    x += 30;
                    btn.Tag = angka[hitung];
                    btn.Text = hitung.ToString();
                    btn.BackColor = Color.NavajoWhite;
                    btn.Click += btn3_Click;
                    seat3.Add(btn);
                    panel1.Controls.Add(btn);
                    hitung++;
                }
                x = 10;
                y += 30;
            }
            Label lbl_layar = new Label();
            lbl_layar.Text = "Layar";
            lbl_layar.Location = new Point(145, 0);
            lbl_layar.Size = new Size(40, 40);
            panel1.Controls.Add(lbl_layar);

            for (int i = 0; i < Form1.simpanavatar3.Count; i++)
            {
                foreach (Button a in seat3)
                {
                    if (Form1.simpanavatar3[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = false;
                    }
                }
            }
            Label lbl_kursi = new Label();
            lbl_kursi.Text = "No Kursi Dipilih: ";
            lbl_kursi.Location = new Point(20, 315);
            lbl_kursi.Size = new Size(90, 30);
            panel1.Controls.Add(lbl_kursi);

            Button btnoke3 = new Button();
            btnoke3.Location = new Point(260, 315);
            btnoke3.Size = new Size(60, 20);
            btnoke3.Text = "Pesan";
            panel1.Controls.Add(btnoke3);
            btnoke3.Click += btnoke3_Click;
            btnoke3.BackColor = Color.SpringGreen;


            lbl_pilih3.Location = new Point(109, 315);
            lbl_pilih3.Size = new Size(160, 50);
            panel1.Controls.Add(lbl_pilih3);

            kar1.Clear();
            karakter1 = "";
            lbl_pilih1.Text = "";

            kar2.Clear();
            karakter2 = "";
            lbl_pilih2.Text = "";
        }
        string karakter3;
        List<string> kar3 = new List<string>();

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (kar3.Contains(button.Text))
            {
                MessageBox.Show("Sudah Diklik ");
            }
            else
            {
                kar3.Add(button.Text);
                karakter3 += button.Text + ",";
            }
            lbl_pilih3.Text = karakter3;

        }
        private void btnoke3_Click(object sender, EventArgs e)
        {

            foreach (var i in kar3)
            {
                Form1.simpanavatar3.Add(Convert.ToInt32(i));
            }

            for (int i = 0; i < Form1.simpanavatar3.Count; i++)
            {
                foreach (Button a in seat3)
                {
                    if (Form1.simpanavatar3[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = false;
                    }
                }
            }
            lbl_pilih3.Text = "";

        }

        private void btnrst3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.simpanavatar3.Count; i++)
            {
                foreach (Button a in seat3)
                {
                    if (Form1.simpanavatar3[i].ToString() == a.Tag.ToString())
                    {
                        a.Enabled = true;
                    }
                }
            }
            Form1.simpanavatar3.Clear();
            kar3.Clear();
            karakter3 = "";

        }
    }
}
