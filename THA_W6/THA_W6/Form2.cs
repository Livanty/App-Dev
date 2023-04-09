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
using System.Xml.Linq;


namespace THA_W6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        Button[,] buttonarray;
        string[] keys = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        
        string[] kata = File.ReadAllText("C:\\Users\\HP\\Downloads\\Wordle Word List.txt").Split(',');

        List<char> yangsama = new List<char>();

        List<string> daftarkata = new List<string>();
        public static string save ;


        private void Form2_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show(ka.ToString());
            int x = 10;
            int y = 10;
            buttonarray = new Button[Form1.input, 5];
            for (int i = 0; i < Form1.input; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    buttonarray[i, j] = new Button();
                    buttonarray[i, j].Location = new Point(x, y);
                    buttonarray[i, j].Size = new Size(40, 40);
                    x += 50;
                    buttonarray[i, j].Tag = i + "," + j;
                    this.Controls.Add(buttonarray[i, j]);
                    // buttonarray[i, j].Click += buttonarray_Click;
                    // buttonarray[i, j].BackColor = Color.;
                   // buttonarray[i, j].Text = i + "," + j;
                }
                x = 10;
                y += 50;

                
            }


            int left = 300;
            int top = 90;


            foreach (string key in keys)
            {
                Button button = new Button();
                button.Text = key;
                button.Location = new Point(left, top);

                button.Width = 40;
                button.Height = 40;
                button.Click += button_Click;
                this.Controls.Add(button);
                left += 45;

                if (key == "P")
                {
                    left = 325;
                    top += 50;
                }
                else if (key == "L")
                {
                    left = 370;
                    top += 50;
                }


            }
            Button buttondelete = new Button();
            buttondelete.Location = new Point(685, 190);
            buttondelete.Size = new Size(55, 40);
            buttondelete.Click += buttondelete_Click;
            buttondelete.Text = "Delete";
            this.Controls.Add(buttondelete);
            Button buttonenter = new Button();
            buttonenter.Location = new Point(310, 190);
            this.Controls.Add(buttonenter);
            buttonenter.Size = new Size(55, 40);
            buttonenter.Click += buttonenter_Click;
            buttonenter.Text = "Enter";


            
            string guessesword = kata[new Random().Next(0, kata.Length)];
            MessageBox.Show(guessesword + " Ini Jawaban biar memudahkan :v");
            save = guessesword;

            for (int i = 0; i < guessesword.Length; i++)
            {
                string simpan = guessesword.Substring(i, 1);
                daftarkata.Add(simpan);
            }                      
        }
        
        int tebak = 0;
        int isi = 0;
        int simpani = 0;
        int simpanj=0;
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //SendKeys.Send(button.Text);

           string karakter = button.Text;

            for (int i = tebak; i < tebak +1; i++)
            {
                for ( int j = isi; j< isi +1;j++ )
                {
                    if (isi < 5)
                    {
                        buttonarray[i, j].Text = karakter;
                        simpani = i;
                        simpanj = j;
                        
                    }
                    else if (isi > 4)
                    {                        
                        isi = 4;
                    }
                    else if (isi < 0)
                    {
                        isi = 0;
                    }
                }
            }
            isi++;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (isi > 0)
            {               
                isi--;
                buttonarray[tebak, isi].Text = "";
            }
              

        }
        int hitung = 0;
        bool jalan = true;
        string cek;
        bool piu = true;
        string ya = "";


        
        private void buttonenter_Click(object sender, EventArgs e)
        {
            bool yah = true;
            //int pap = 0;
            //int yay = 0;
            //string poin = "";
            //string poinbutton = "";
            //for (int i = 0; i < daftarkata.Count; i++)
            //{
            //    for (int j = i + 1; j < daftarkata.Count; j++)
            //    {
            //        if (daftarkata[i] == daftarkata[j])
            //        {
            //            // piu = false;
            //            poin = daftarkata[i].ToUpper();

            //        }

            //    }

            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    int hitung = 0;
            //    for (int j = i + 1; j < 5; j++)
            //    {

            //        if (buttonarray[tebak, i].Text == buttonarray[tebak, j].Text)
            //        {
            //            hitung++;
            //            poinbutton = buttonarray[tebak, i].Text;


            //        }
            //        if (hitung > 2 && !yangsama.Contains(Convert.ToChar(buttonarray[tebak, i].Text)))
            //        {

            //            yangsama.Add(Convert.ToChar(buttonarray[tebak, i].Text));
            //        }

            //    }
            //}

            for (int j = 0; j < 5; j++)
            {
                if (buttonarray[tebak,j].Text == "")
                {
                    yah = false;
                }
            }
            bool jalan = true;
            for (int j = 0; j < 5; j++)
            {
                cek += buttonarray[tebak, j].Text;
            }

            foreach (var i in kata)
            {
                if (i.ToUpper() == cek)
                {
                    jalan = true;
                    break;
                }
                else
                {
                    jalan = false;
                }

            }
            
            if (jalan == false)
            {
                MessageBox.Show(cek + " Kata tidak ada dalam Word List");

            }
            if (yah == false)
            {
                MessageBox.Show(" Harap semua kotak diisi");
            }
            else if (jalan == true && yah ==true )
            {

                //foreach (var a in daftarkata)
                //{
                    
                //    for (int j = 0; j < 5; j++)
                //    {

                //        if (a.ToUpper() == buttonarray[tebak, j].Text)
                //        {
                //            buttonarray[tebak, j].BackColor = Color.Yellow;
                //            yay += 1;
                //        }
                //        if (yay > 1 && !yangsama.Contains(Convert.ToChar(a)))
                //        {                            
                //            buttonarray[tebak, j].BackColor = Color.White;
                //        }
                        
                //        if (a.ToUpper() == buttonarray[tebak, j].Text)
                //        {
                //            if (poin == poinbutton)
                //            {
                //                MessageBox.Show("piu");
                //                buttonarray[tebak, j].BackColor = Color.Pink;
                //            }
                //        }
                //        yay = 0;
                //    }
                    
                //}

                for (int j = 0; j < 5; j++)
                {
                    foreach (var a in daftarkata)
                    {
                        
                        if (daftarkata[j].ToString().ToUpper() == buttonarray[tebak, j].Text)
                        {
                            buttonarray[tebak, j].BackColor = Color.GreenYellow;

                        }
                        else if (a.ToUpper() == buttonarray[tebak, j].Text)
                        {
                            buttonarray[tebak, j].BackColor = Color.Yellow;

                        }

                    }
                }

                //for (int j = 0; j < 5; j++)
                //{
                //    if (buttonarray[tebak, j].BackColor == Color.GreenYellow && !yangsama.Contains(Convert.ToChar(buttonarray[tebak, j].Text)))
                //    {
                //        string text = buttonarray[tebak, j].Text;
                //        for (int k = 0; k < 5; k++)
                //        {
                //            if (buttonarray[tebak, k].BackColor == Color.Yellow && buttonarray[tebak, k].Text == text)
                //            {
                //                buttonarray[tebak, k].BackColor = Color.White;
                //            }
                //        }
                //    }

                //}

                if (buttonarray[tebak, 0].BackColor == Color.GreenYellow && buttonarray[tebak, 1].BackColor == Color.GreenYellow && buttonarray[tebak, 2].BackColor == Color.GreenYellow && buttonarray[tebak, 3].BackColor == Color.GreenYellow && buttonarray[tebak, 4].BackColor == Color.GreenYellow)
                {
                    MessageBox.Show("You Win. The world is " + save);
                    Environment.Exit(0);

                }
                else if (tebak == Form1.input - 1)
                {
                    MessageBox.Show("You Lose. The world is " + save);
                    Environment.Exit(0);
                }

                tebak++;
                isi = 0;
            }
            cek = null ;
            
        }
    }
}

   
