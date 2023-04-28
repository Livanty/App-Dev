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
    public partial class fmatch : Form
    {
        public fmatch()
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
        DataTable dtsource2 = new DataTable();
        private void fmatch_Load(object sender, EventArgs e)
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

        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_team.SelectedIndex != 0)
            {
                dtpemain.Clear();
                connectionString = "server=localhost;uid=root;pwd=0mR0Nh3Mc4b!;database=premier_league";
                sqlConnect = new MySqlConnection(connectionString);

                string simpan = cmb_team.SelectedValue.ToString();


                sqlQuery = $"SELECT match_id FROM `match` where team_home = '{simpan}' or team_away = '{simpan}';;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpemain);
                cmb_match.DisplayMember = "match_id";
                cmb_match.ValueMember = "match_id";
                cmb_match.DataSource = dtpemain;
            }
        }

        private void cmb_match_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_match.SelectedValue != null)
            {
                dtsource1.Clear();
                dtsource2.Clear();
                string simpanvalue = cmb_match.SelectedValue.ToString();


                sqlQuery = $"select d.`minute` as 'Minute', t.team_name as 'Team Name', p.player_name as 'Player Name', \r\nif (d.`type`='CY', \"Yellow Card\", \r\nif (d.`type`='RD', \"Red Card\",\r\nif (d.`type`='GO', \"Goal Scored\",  \r\nif (d.`type`='GW', \"Own Goal\", \r\nif (d.`type`='GP', \"Goal Penalty\", \" Penalty Missed\"))))) as 'Type'\r\nfrom dmatch d\r\ninner join team t ON t.team_id = d.team_id \r\ninner join player p ON p.player_id = d.player_id \r\nwhere d.match_id = '{simpanvalue}'\r\norder by 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtsource2);
                dgv2.DataSource = dtsource2;


                sqlQuery = $"select t.team_name as 'Team Name', p.player_name 'Player Name', p.playing_pos as 'Position'\r\nfrom player p\r\ninner join `match` m ON m.team_home = p.team_id or m.team_away = p.team_id\r\ninner join team t ON t.team_id = p.team_id \r\nwhere m.match_id = '{simpanvalue}'\r\norder by 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtsource1);
                dgv1.DataSource = dtsource1;

                
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
