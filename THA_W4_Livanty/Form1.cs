using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_Livanty
{
    public partial class Form1 : Form
    {

        List<string> playerManchester = new List<string>() {"David de Gea", "Victor Lindelof" , "Phil Jones", "Harry Maguire", "Lisandro Martinez", "Bruno Fernandez", "Anthony Martial", "Marcus Rashford", "Tyrell Malacia", "Christian Eriksen" , "Casemiro"};
        List<string> playerChelsea = new List<string>() { "Kepa Arrizabalaga", "Benoit Badiashile", "Enzo Fernandez", "Thiago Silva", "N'Golo Kante", "Mateo Kovacic", "Pierre-Emerick Aubameyang", "Christian Pulisic", "Joao Felix", "Ruben Loftus", "Raheem Sterling" };
        List<string> playerBayem = new List<string>() { "Manuel Neuer", "Dayot Upamecano", "Matthijs de Ligt", "Benjamin Pavart", "Joshua Kimmich", "Serge Gnabry", "Leon Goretzka", "Leroy Sane", "Paul Wanner", "Lucas Hernandez", "Thomas Muller" };

        List<string> numberManchester = new List<string>() { "01", "02", "04", "05", "06", "08", "09", "10", "12", "14", "18" };
        List<string> numberChealsea = new List<string>() { "01", "04", "05", "06", "07", "08", "09", "10", "11", "12", "17" };
        List<string> numberBayem = new List<string>() { "01", "02", "04", "05", "06", "07", "08", "10", "14", "21", "25" };

        List<string> posManchester = new List<string>() { "GK", "DF", "DF", "DF", "DF", "MF", "FW", "FW", "DF", "MF", "MF" };
        List<string> posChelsea = new List<string>() { "GK", "DF", "MF", "DF", "MF", "MF", "FW", "MF", "FW", "MF", "MF" };
        List<string> posBayem = new List<string>() { "GK", "DF", "DF", "DF", "MF", "FW", "MF", "FW", "MF", "DF", "FW" };
        public Form1()
        {
            InitializeComponent();
        }

        class Team
        {
            public string TeamName;
            public string teamName
            {
                get { return TeamName; }
                set { TeamName = value; }
            }

            public string TeamCountry;
            public string teamCountry
            {
                get { return TeamCountry; }
                set { TeamCountry = value; }
            }

            public string TeamCity;
            public string teamCity
            {
                get { return TeamCity; }
                set { TeamCity = value; }
            }
            public List<Player> Players = new List<Player>();
            public void coba (Player a)
            {
                Players.Add(a);
            }
        }
        
        List<Team> Teams = new List<Team>();
       
        //List<string> listcountry = new List<string>();
        
        class Player
        {          
            public string PlayerName;
            public string playerName
            {
                get { return PlayerName; }
                set { PlayerName = value; }
            }
            public string PlayerNum;
            public string playerNum
            {
                get { return PlayerNum; }
                set { PlayerNum = value; }
            }

            public string PlayerPos;
            public string playerPos
            {
                get { return PlayerPos; }
                set { PlayerPos = value; }
                
            }               
        }
        int count = 0;
        string cekNegara = "";
        string cekTim = "";
        public void isiNegara()
        {
           // List<string> negara = new List<string>();           
            //listBox_hasil.Items.Clear();
            cmb_choosecountry.Items.Clear();
            foreach (Team a in Teams)
            {
                count = 0;
                foreach (string b in cmb_choosecountry.Items)
                {
                    if (a.teamCountry == b)
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    cmb_choosecountry.Items.Add(a.teamCountry);
                }
            }
 
        }

        public void isiTeam()
        {
            cmb_chooseteam.Items.Clear();
            foreach ( Team i in Teams)
            {
                if(i.teamCountry == cekNegara)
                {
                    cmb_chooseteam.Items.Add(i.teamName);
                }
            }
        }

        public void isiPlayer()
        {
            listBox_hasil.Items.Clear();
            foreach (Team i in Teams)
            {
                if (i.teamName == cekTim && i.teamCountry == cekNegara)
                {
                    foreach (Player b in i.Players)
                    {
                        listBox_hasil.Items.Add($"({b.playerNum}) {b.playerName}, {b.playerPos}");
                    }
                }
            }
        }

        private void btn_addteam_Click(object sender, EventArgs e)
        {
            
            if (txt_teamname.Text == "")
            {
                MessageBox.Show("Harus Ada Input Team Name", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_country.Text == "")
            {
                MessageBox.Show("Harus Ada Input Team Country ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_teamcity.Text == "")
            {
                MessageBox.Show("Harus Ada Input Team City ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Team myteam = new Team();
                myteam.teamName = txt_teamname.Text;
                myteam.teamCity = txt_teamcity.Text;
                myteam.teamCountry = txt_country.Text;

                bool negarasudahada = false;
                foreach (var CekCountry in Teams)
                {
                    if (CekCountry.teamName == myteam.teamName)
                    {
                        negarasudahada = true;
                    }
                }

                if (negarasudahada == true)
                {
                    MessageBox.Show("Team sudah ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    Teams.Add(myteam);
                }
                txt_teamname.Clear();
                txt_teamcity.Clear();
                txt_country.Clear();
                isiNegara();
                isiTeam();

            }


        }

        private void btn_addplayer_Click(object sender, EventArgs e)
        {

            if (txt_playername.Text == "")
            {
                MessageBox.Show("Harus Ada Input Player Name", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_playernumber.Text == "")
            {
                MessageBox.Show("Harus Ada Input Player Number ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cmb_playerpositiom.Text == "")
                {
                    MessageBox.Show("Harus Dipilih ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Player myplayer = new Player();
                    myplayer.playerName = txt_playername.Text;
                    myplayer.playerNum = txt_playernumber.Text;
                    myplayer.playerPos = cmb_playerpositiom.Text;
                    //count = 0;
                    bool playersudahada = false;

                    //foreach (var CekPemain in Team.Players)
                    //{
                    //  if (CekPemain.playerNum == myplayer.playerNum)
                    //  {
                    //        playersudahada = true;
                    //  }

                    //}
                    foreach (string b in listBox_hasil.Items)
                    {
                        if (b.Contains($"({txt_playernumber.Text})"))
                        {
                            
                            playersudahada = true;
                        }

                    }
                    if (playersudahada == true)
                    {
                        MessageBox.Show("Player Number sudah ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    else
                    {
                        foreach (Team a in Teams)
                        {
                            if (a.teamName == cekTim && a.teamCountry == cekNegara)
                            {
                               
                                a.coba(myplayer);
                            }
                        }
                    }
                    txt_playername.Clear();
                    txt_playernumber.Clear();
                    cmb_playerpositiom.Text = null;
                    
                    isiPlayer();
                    listBox_hasil.Sorted = true;
                }


            }

        }

        private void cmb_choosecountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                        
            cekNegara = cmb_choosecountry.SelectedItem.ToString();
            isiTeam();

        }
        private void cmb_chooseteam_SelectedIndexChanged(object sender, EventArgs e)
        {         
           cekTim = cmb_chooseteam.SelectedItem.ToString();
            isiPlayer();
        }             
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_hasil.Sorted = true;
            // listBox_hasil.Sorted = false;

            

            Team myteam = new Team();
            myteam.teamName = "Manchester United";
            myteam.teamCountry = "England";
            myteam.teamCity = "United Kingdom";
            for (int i = 0; i < 11; i++)
            {
                Player players = new Player();
                players.playerName = playerManchester[i];
                players.playerNum = numberManchester[i];
                players.playerPos = posManchester[i];
                myteam.coba(players);
            }
            Teams.Add(myteam);

            Team teams1 = new Team();
            teams1.teamName = "Chelsea";
            teams1.teamCountry = "England";
            teams1.teamCity = "London";
            for (int i = 0; i < 11; i++)
            {
                Player players = new Player();
                players.playerName = playerChelsea[i];
                players.playerNum = numberChealsea[i];
                players.playerPos = posChelsea[i];
                teams1.coba(players);
            }
            Teams.Add(teams1);


   

            Team teams = new Team();
            teams.teamName = "Bayem Munich";
            teams.teamCountry = "Germany";
            teams.teamCity = "Munich";
            for (int i = 0; i < 11; i++)
            {
                Player players = new Player();
                players.playerName = playerBayem[i];
                players.playerNum = numberBayem[i];
                players.playerPos = posBayem[i];
                teams.coba(players);
            }
            Teams.Add(teams);

            isiNegara();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            
            if(listBox_hasil.SelectedItem == "")
            {
                MessageBox.Show("Pilih yang mau dihapus");
            }
            else
            {
                foreach (Team a in Teams)
                {
                    if (a.teamName == cekTim && a.teamCountry == cekNegara)
                    {
                        if (a.Players.Count < 12)
                        {
                            MessageBox.Show("Minimal 11 Player", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            
                            foreach (Player b in a.Players)
                            {
                                if (($"({b.playerNum}) {b.playerName}, {b.playerPos}") == listBox_hasil.SelectedItem.ToString())
                                {
                                    a.Players.Remove(b);
                                    break;
                                }

                            }
                        }
                    }
                }
                isiPlayer();
            }
        }
    }
}
