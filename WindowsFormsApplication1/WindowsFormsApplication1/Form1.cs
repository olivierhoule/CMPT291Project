using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private SqlConnection db;

        public Form1()
        {
            InitializeComponent();
            LoadConnectionString();

            db = new SqlConnection(connectionString);
            db.Open();

            LoadAllData();
        }

        private void LoadConnectionString()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../connectionstring.txt");
            connectionString = File.ReadAllText(path);
        }

        private void LoadAllData()
        {
            LoadPatients();
            LoadDoctors();
            LoadWards();
            LoadRegistrations();
        }

        private void LoadPatients()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patient", db);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                object[] row = { reader.GetValue(0), reader.GetValue(2), reader.GetValue(3) };
                dataGridView1.Rows.Add(row);
            }

            reader.Close();
            cmd.Dispose();
        }

        private void LoadDoctors()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Doctors", db);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                object[] row = { reader.GetValue(0), reader.GetValue(2), reader.GetValue(3) };
                dataGridView2.Rows.Add(row);
            }

            reader.Close();
            cmd.Dispose();
        }

        private void LoadWards()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Wards", db);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                object[] row = { reader.GetValue(0), reader.GetValue(2), reader.GetValue(3) };
                dataGridView3.Rows.Add(row);
            }

            reader.Close();
            cmd.Dispose();
        }

        private void LoadRegistrations()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Registrations", db);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                object[] row = { reader.GetValue(0), reader.GetValue(2), reader.GetValue(3) };
                dataGridView4.Rows.Add(row);
            }

            reader.Close();
            cmd.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
