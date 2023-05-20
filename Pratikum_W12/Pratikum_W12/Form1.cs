using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Pratikum_W12
{
    public partial class Form1 : Form
    {

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        string connectionString;
        string sqlQuery;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        DataTable dt7 = new DataTable();
        public Form1()
        {
            try
            {
                connectionString = "server=localhost;uid=root;pwd=0mR0Nh3Mc4b!;database=premier_league";
                sqlConnect = new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }


        private void updateDGV3()
        {
            dt7.Clear();
            try
            {
                sqlQuery = $"select player_name, n.nation, p.team_number, p.height, p.weight, p.birthdate\r\nfrom player p, nationality n\r\nwhere team_id = '{cmb4.SelectedValue.ToString()}' and status = '1';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt7);
                dgv3.DataSource = dt7;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDGV2()
        {
            dt5.Clear();         
            try
            {
                sqlQuery = $"select m.manager_name, t.team_name, m.birthdate, n.nation, m.manager_id \r\nfrom manager m, team t, nationality n \r\nwhere m.working = '0'  and n.nationality_id = m.nationality_id ;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt5);
                dgv2.DataSource = dt5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv2.Columns[4].Visible = false;
        }

        private void updateDGV1()
        {
            dt4.Clear();
            try
            {
                sqlQuery = $"select m.manager_name, t.team_name, m.birthdate, n.nation from manager m, team t, nationality n where m.working = '1' and m.manager_id = t.manager_id and n.nationality_id = m.nationality_id and team_id = '{cmb3.SelectedValue}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt4);
                dgv1.DataSource = dt4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteSQL(string command)
        {
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(command, sqlConnect);
                sqlDataReader = sqlCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlConnect.Close();               
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = $"select * from nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);
            cmb1.DisplayMember = "nation";
            cmb1.ValueMember = "nationality_id";
            cmb1.DataSource = dt;

            sqlQuery = $"select * from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt2);
            cmb2.DisplayMember = "team_name";
            cmb2.ValueMember = "team_id";
            cmb2.DataSource = dt2;

            sqlQuery = $"select * from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt3);
            cmb3.DisplayMember = "team_name";
            cmb3.ValueMember = "team_id";
            cmb3.DataSource = dt3;

            sqlQuery = $"select * from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt6);
            cmb4.DisplayMember = "team_name";
            cmb4.ValueMember = "team_id";
            cmb4.DataSource = dt6;

            //sqlQuery = $"select m.manager_name, t.team_name, m.birthdate, n.nation from manager m, team t, nationality n where m.working = '1' and m.manager_id = t.manager_id and n.nationality_id = m.nationality_id and team_id = '{cmb3.SelectedValue}';";
            //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            //sqlAdapter = new MySqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(dt7);
            //dgv3.DataSource = dt7;


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            string number = txt2.Text;
            string position = txt3.Text;
            string height = txt4.Text;
            string weight = txt5.Text;
            string playerid = txt6.Text;
           
            string tgl = dtp.Value.ToString("yyyy-MM-dd");
            string command = $"insert into player values ('{playerid}' ,'{number}', '{name}', '{cmb1.SelectedValue}', '{position}', '{height}', '{weight}', '{tgl}', '{cmb2.SelectedValue}', '1', '0');" ;
            ExecuteSQL(command);
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
        }

       
        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt5.Clear();
            dt4.Clear();
            dt5 = new DataTable();
            dt4 = new DataTable();

            sqlQuery = $"select m.manager_name, t.team_name, m.birthdate, n.nation from manager m, team t, nationality n where m.working = '1' and m.manager_id = t.manager_id and n.nationality_id = m.nationality_id and team_id = '{cmb3.SelectedValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt4);
            dgv1.DataSource = dt4;

           
            sqlQuery = $"select m.manager_name, m.birthdate, n.nation, m.manager_id \r\nfrom manager m, nationality n \r\nwhere m.working = '0'  and n.nationality_id = m.nationality_id ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt5);
            dgv2.DataSource = dt5;
            dgv2.Columns[3].Visible = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
           
            if (dgv1.CurrentCell != null && dgv1.CurrentCell != null) // Pastikan ada sel yang saat ini dipilih
            {

                int rowIndex = dgv2.CurrentCell.RowIndex;
                DataGridViewRow row = dgv2.Rows[rowIndex];
                string value = row.Cells[0].Value.ToString();
                string valuess = row.Cells[3].Value.ToString();
                string command = $"update manager\r\nset working = '1' \r\nwhere manager_name = '{value}';";
                string coba = $"update team\r\nset manager_id = '{valuess}' \r\nwhere team_id = '{cmb3.SelectedValue}';";
                ExecuteSQL(command);
                ExecuteSQL(coba);
                updateDGV2();

                int rowIndex1 = dgv1.CurrentCell.RowIndex;
                DataGridViewRow row1 = dgv1.Rows[rowIndex1];
                string value1 = row1.Cells[0].Value.ToString();
                // MessageBox.Show(value.ToString());
                string commands = $"update manager\r\nset working = '0' \r\nwhere manager_name = '{value1}';";
                ExecuteSQL(commands);
                updateDGV1();
            }
            dt5.Clear();
            dt4.Clear();
            dt5 = new DataTable();
            dt4 = new DataTable();

            sqlQuery = $"select m.manager_name, t.team_name, m.birthdate, n.nation from manager m, team t, nationality n where m.working = '1' and m.manager_id = t.manager_id and n.nationality_id = m.nationality_id and team_id = '{cmb3.SelectedValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt4);
            dgv1.DataSource = dt4;


            sqlQuery = $"select m.manager_name, m.birthdate, n.nation, m.manager_id \r\nfrom manager m, nationality n \r\nwhere m.working = '0'  and n.nationality_id = m.nationality_id ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt5);
            dgv2.DataSource = dt5;
            dgv2.Columns[3].Visible = false;
        }
        private void btn3_Click(object sender, EventArgs e)
        {

            if (dgv3.Rows.Count > 12)
            {
                int rowIndex = dgv3.CurrentCell.RowIndex;
                DataGridViewRow row = dgv3.Rows[rowIndex];
                string value = row.Cells[0].Value.ToString();
            //    MessageBox.Show(value.ToString());

                string command = $"update player set status = '0' where player_name = '{value}';";
                ExecuteSQL(command);
                updateDGV3();

                dt7.Clear();
                dt7 = new DataTable();
                sqlQuery = $"select player_name, n.nation, p.team_number, p.height, p.weight, p.birthdate from player p left join nationality n on p.nationality_id = n.nationality_id where team_id = '{cmb4.SelectedValue}' and status = '1';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt7);
                dgv3.DataSource = dt7;
            }
            else
            {
                MessageBox.Show("Min 11");
            }
            
        }
        private void cmb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt7.Clear();
            dt7 = new DataTable();
            sqlQuery = $"select player_name, n.nation,p.playing_pos, p.team_number, p.height, p.weight, p.birthdate from player p left join nationality n on p.nationality_id = n.nationality_id where team_id = '{cmb4.SelectedValue}' and status = '1';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt7);
            dgv3.DataSource = dt7;
        }
     
    }
}
