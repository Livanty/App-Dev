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
    public partial class fplayer : Form
    {
        public fplayer()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectionString;
        string sqlQuery;

        DataTable dtteam = new DataTable();
        DataTable dtpemain = new DataTable();
        DataTable dtsource1 = new DataTable();
       
        private void fplayer_Load(object sender, EventArgs e)
        {

            connectionString = "server=localhost;uid=root;pwd=0mR0Nh3Mc4b!;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);

            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);
            cmb_team.DisplayMember = "team_name";
            cmb_team.ValueMember = "team_id";
            cmb_team.DataSource = dtteam;
            cmb_team.Text = "";

        }
        string simpannama;
        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_team.SelectedIndex != 0)
            {
                dtpemain.Clear();
                connectionString = "server=localhost;uid=root;pwd=0mR0Nh3Mc4b!;database=premier_league";
                sqlConnect = new MySqlConnection(connectionString);

                string simpan = cmb_team.SelectedValue.ToString();


                sqlQuery = $"SELECT player_name, player_id FROM player where team_id = '{simpan}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpemain);
                cmb_player.DisplayMember = "player_name";
                cmb_player.ValueMember = "player_id";
                cmb_player.DataSource = dtpemain;
                
            }                     

        }

        private void cmb_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_player.SelectedValue != null )
            {
                dtsource1.Clear();
                simpannama = cmb_player.SelectedValue.ToString();

                sqlQuery = $"SELECT p.player_name as \"Player Name\", p.playing_pos as \"Position\" , p.team_number as \"Squad Number\", t.team_name as \"Team Name\", n.nation as \"Nationality\", \r\n  COUNT(IF(d.type = 'CY', 1, NULL)) AS \"Yellow Cards\",\r\n  COUNT(IF(d.type = 'CR', 1, NULL)) AS \"Red Cards\",\r\n  COUNT(IF(d.type = 'GO', 1, NULL)) AS \"Goal Scored\",\r\n  COUNT(IF(d.type = 'PM', 1, NULL)) AS \"Penalty Missed\"\r\nFROM player p\r\nINNER JOIN team t ON p.team_id = t.team_id \r\nINNER JOIN nationality n ON p.nationality_id = n.nationality_id\r\nLEFT JOIN dmatch d ON p.player_id = d.player_id\r\nWHERE p.player_id = '{simpannama}'\r\nGROUP BY p.player_name;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtsource1);

                lbl1.Text = dtsource1.Rows[0][0].ToString();
                lbl2.Text = dtsource1.Rows[0][1].ToString();
                lbl3.Text = dtsource1.Rows[0][2].ToString();
                lbl4.Text = dtsource1.Rows[0][3].ToString();
                lbl5.Text = dtsource1.Rows[0][4].ToString();
                lbl6.Text = dtsource1.Rows[0][5].ToString();
                lbl7.Text = dtsource1.Rows[0][6].ToString();
                lbl8.Text = dtsource1.Rows[0][7].ToString();
                lbl9.Text = dtsource1.Rows[0][8].ToString();

            }
        }
       
    }
}
