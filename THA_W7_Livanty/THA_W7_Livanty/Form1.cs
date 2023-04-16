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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel panel1 = new Panel();
        public static List<int> simpanavatar1 = new List<int>();
        public static List<int> simpanavatar2 = new List<int>();
        public static List<int> simpanavatar3 = new List<int>();
        public static int hitavatar1 = 0;
        public static int hitavatar2 = 0;
        public static int hitavatar3 = 0;

        public static List<int> simpanaquaman1 = new List<int>();
        public static List<int> simpanaquaman2 = new List<int>();
        public static List<int> simpanaquaman3 = new List<int>();
        public static int hitaquaman1 = 0;
        public static int hitaquaman2 = 0;
        public static int hitaquaman3 = 0;

        public static List<int> simpanbighero1 = new List<int>();
        public static List<int> simpanbighero2 = new List<int>();
        public static List<int> simpanbighero3 = new List<int>();
        public static int hitbighero1 = 0;
        public static int hitbighero2 = 0;
        public static int hitbighero3 = 0;

        public static List<int> simpanendgame1 = new List<int>();
        public static List<int> simpanendgame2 = new List<int>();
        public static List<int> simpanendgame3 = new List<int>();
        public static int hitendgame1 = 0;
        public static int hitendgame2 = 0;
        public static int hitendgame3 = 0;

        public static List<int> simpaninfinitywar1 = new List<int>();
        public static List<int> simpaninfinitywar2 = new List<int>();
        public static List<int> simpaninfinitywar3 = new List<int>();
        public static int hitinfinitywar1 = 0;
        public static int hitinfinitywar2 = 0;
        public static int hitinfinitywar3 = 0;


        public static List<int> simpanjumanji1 = new List<int>();
        public static List<int> simpanjumanji2 = new List<int>();
        public static List<int> simpanjumanji3 = new List<int>();
        public static int hitjumanji1 = 0;
        public static int hitjumanji2 = 0;
        public static int hitjumanji3 = 0;

        public static List<int> simpanmariposa1 = new List<int>();
        public static List<int> simpanmariposa2 = new List<int>();
        public static List<int> simpanmariposa3 = new List<int>();
        public static int hitmariposa1 = 0;
        public static int hitmariposa2 = 0;
        public static int hitmariposa3 = 0;

        public static List<int> simpanminions1 = new List<int>();
        public static List<int> simpanminions2 = new List<int>();
        public static List<int> simpanminions3 = new List<int>();
        public static int hitminions1 = 0;
        public static int hitminions2 = 0;
        public static int hitminions3 = 0;
        public void setform (object form)
        {
            panel1.Controls.Clear();
            if (form.GetType().ToString().Contains("avatar"))
            {
                var obj = form as avatar;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("aquaman"))
            {
                var obj = form as aquaman;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("bighero"))
            {
                var obj = form as bighero;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("endgame"))
            {
                var obj = form as endgame;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("infinitywar"))
            {
                var obj = form as infinitywar;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("jumanji"))
            {
                var obj = form as jumanji;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("mariposa"))
            {
                var obj = form as mariposa;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
            else if (form.GetType().ToString().Contains("minions"))
            {
                var obj = form as minions;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "PESAN TIKET";
            btn.Location = new Point(5, 5);
            btn.Size = new Size(100, 40);
            btn.Click += btn_Click;
            btn.BackColor= Color.White;
            this.Controls.Add(btn);
            this.BackColor = Color.DarkSeaGreen;

            Label lbl_xixi = new Label();
            lbl_xixi.Text = "XINEMA XIXI ";
            lbl_xixi.Location = new Point(690, 17);
            lbl_xixi.Size = new Size(200, 20);
            lbl_xixi.Font = new Font("TIMES NEW ROMAN", 16, FontStyle.Bold);
            this.Controls.Add(lbl_xixi);
        }
        private void btn_Click(object sender, EventArgs e)
        {

            panel1.Location = new System.Drawing.Point(0, 50);
            panel1.Size = new System.Drawing.Size(1946, 504);
            //panel1.BackColor = Color.LightGray;
            this.Controls.Add(panel1);

            pilihanfilm film = new pilihanfilm(this);
            film.Dock = DockStyle.Fill;
            film.TopLevel = false;
            panel1.Controls.Clear();
            film.Show();

            panel1.Controls.Add(film);

        }


    }
}
