using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectionString;
        string sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtsource1 = new DataTable();
        DataTable dtsource2 = new DataTable();
        DataTable dtsource3 = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);

            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            cmb1.DisplayMember = "team_name";
            cmb1.ValueMember = "team_id";
            cmb1.DataSource = dtPemain;

        }

        private void teamDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtsource1.Clear();
            dtsource2.Clear();
            dgv2.Visible = true;
            dgv1.Visible = true;
            dgv3.Visible = false;
            cmb1.Visible = true;

            //string simpan = cmb1.SelectedValue.ToString();
            //sqlQuery = $"SELECT player_name, team_name, playing_pos, weight, height FROM player INNER JOIN team ON player.team_id = team.team_id WHERE team_name = '{cmb1.SelectedText}';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtsource1);
            //dgv1.DataSource = dtsource1;

            //sqlQuery = $"select team_name, manager_name, birthdate, nation FROM manager INNER JOIN team ON manager.manager_id = team.manager_id INNER JOIN nationality ON manager.nationality_id = nationality.nationality_id WHERE team_name='{simpan}';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtsource2);
            //dgv2.DataSource = dtsource2;
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(cmb1.SelectedValue.ToString());
            //dtsource1.Clear();

            string simpan = cmb1.SelectedValue.ToString();
            dtsource1.Clear();
            dtsource2.Clear();
            dtsource3.Clear();
            sqlQuery = $"SELECT player_name, team_name, playing_pos, weight, height FROM player INNER JOIN team ON player.team_id = team.team_id WHERE team_name = '{cmb1.SelectedText}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtsource1);
            dgv1.DataSource = dtsource1;

            sqlQuery = $"select team_name, manager_name, birthdate, nation FROM manager INNER JOIN team ON manager.manager_id = team.manager_id INNER JOIN nationality ON manager.nationality_id = nationality.nationality_id WHERE team_id='{simpan}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtsource2);
            dgv2.DataSource = dtsource2;

            string simpan1 = cmb1.SelectedValue.ToString();
            sqlQuery = $"select team_home, team_away, match_date, goal_home, goal_away, referee_name FROM `match` INNER JOIN team on `match`.team_home = team.team_id or `match`.team_away = team.team_id INNER JOIN referee on `match`.referee_id = referee.referee_id WHERE team_home='{simpan1}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtsource3);
            dgv3.DataSource = dtsource3;

            //dtsource2.Clear();

        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtsource1.Clear();
            dtsource2.Clear();
            dtsource3.Clear();
            dgv2.Visible = false;
           
            dgv1.Visible = false;
            dgv3.Visible = true;
            string simpan1 = cmb1.SelectedValue.ToString();
            sqlQuery = $"select team_home, team_away, match_date, goal_home, goal_away, referee_name FROM `match` INNER JOIN team on `match`.team_home = team.team_id or `match`.team_away = team.team_id INNER JOIN referee on `match`.referee_id = referee.referee_id WHERE team_home='{simpan1}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtsource3);
            dgv3.DataSource = dtsource3;
        }
    }
}
