using MySql.Data.MySqlClient;
using MySqlConnector;
using CarClassLibrary;
using System;
using MySqlConnection = MySqlConnector.MySqlConnection;
using MySqlCommand = MySqlConnector.MySqlCommand;
using MySqlDataReader = MySqlConnector.MySqlDataReader;
using MySqlDataAdapter = MySqlConnector.MySqlDataAdapter;
using System.Data;



namespace checkConnection
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=localhost;port=3306;uid=root;password=1998;database=gta_cardatabase";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;port=3306;uid=root;password=1998;database=gta_cardatabase";

                con.ConnectionString = connectionString;
                con.Open();


                /*
                MySqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                }
                con.Close();
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
        }

        //SHOWS IN A DATASET 
        public void GetData()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM compactclass", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtset = new DataTable();
            da.Fill(dtset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dtset;
            dataGridView1.DataSource = bsource;
            da.Update(dtset);


        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM compactclass WHERE maker = maker ", con);
            MySqlDataReader drx = cmd.ExecuteReader();
            while (drx.Read())
            {
                textBox1.Text = drx.GetValue(0).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
