using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CA_W8
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectionString;
        string sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtnamaclub = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);
            //sqlConnect.Open(); // hanya digunakan ketika kalian DML (insert, update, delete) || Kalau cuma select aja g perlu pakai ini

            //sqlQuery = "SELECT  player_id as 'player ID', player_name as 'player Name', height as 'player Height' FROM player;";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtPemain);
            //dgv_pemain.DataSource = dtPemain;

            //sqlQuery = "SELECT abv as 'Abrevation', nation as 'Nation' FROM nationality;";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtNationality);
            //combo_Nationality.DataSource = dtNationality;
            //combo_Nationality.ValueMember = "Abrevation";
            //combo_Nationality.DisplayMember = "Nation"; // yang nampak


            //sqlQuery = "SELECT player_id, player_name, height, team_name FROM player INNER JOIN team ON player.team_id = team.team_id;";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dtPemain);
            //dgv_pemain.DataSource = dtPemain;

            sqlQuery = "SELECT team_name FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtnamaclub);
            cmb_namaclub.DataSource = dtnamaclub;
            cmb_namaclub.DisplayMember = "team_name";
            cmb_namaclub.ValueMember = "team_name";

            // SELECT player_id, player_name, height, team_name FROM player INNER JOIN team ON player.team_id = team.team_id WHERE team_name='Arsenal';
        }

        private void combo_Nationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label_Value.Text = combo_Nationality.SelectedValue.ToString();
        }

        private void cmb_namaclub_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPemain.Clear();          
            string simpan = cmb_namaclub.SelectedValue.ToString();
            sqlQuery = $"SELECT player_id, player_name, height, team_name FROM player INNER JOIN team ON player.team_id = team.team_id WHERE team_name='{simpan}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            dgv_pemain.DataSource = dtPemain;
        }
    }
}
