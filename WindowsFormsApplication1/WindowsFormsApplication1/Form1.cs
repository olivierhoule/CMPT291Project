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

            dataGridView4.Rows.Clear();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Doctor", db);
            SqlDataReader reader = cmd.ExecuteReader();

            dataGridView4.Rows.Clear();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ward", db);
            SqlDataReader reader = cmd.ExecuteReader();

            dataGridView4.Rows.Clear();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Registration", db);
            SqlDataReader reader = cmd.ExecuteReader();

            dataGridView4.Rows.Clear();
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

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            PatientWindow window = new WindowsFormsApplication1.PatientWindow();
            window.ShowDialog();
        }

        private void tabWards_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPatients_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
