using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CA_W12
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
            dgv.DataSource = dt;
            tbox4.Enabled = false;
            tbox5.Enabled = false;
        }
       
       
        private void updateDGV1()
        {
            dt.Clear();
            try
            {
                string command = "select * from nationality";
                sqlCommand = new MySqlCommand(command, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt);
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
                updateDGV1();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            updateDGV1();
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {

            string id = tbox1.Text;
            string nation = tbox2.Text;
            string abv = tbox3.Text;
            string command = $"insert into nationality values ('{id}' ,'{abv}', '{nation}', 0";
            ExecuteSQL(command);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv.CurrentRow.Cells[0].Value.ToString();
            tbox4.Text = id;
            tbox5.Text = id;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox4.Text))
            {
                MessageBox.Show("ID Textbox must not be empty");
            }
            else
            {
                string id = tbox4.Text;
                string command = $"delete from nationality where nationality_id = '{id}'";
                ExecuteSQL(command);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string id = tbox5.Text;
            string nation = tbox6.Text;
            string abv = tbox7.Text;
            string command = $"update nationality set `abv` = '{abv}', `nation` = '{nation}' where` nationality_id` = '{id}'";
            ExecuteSQL(command);
            updateDGV1();
        }
    }
}
