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
            connectionString = Properties.Settings.Default.Cmpt_291_ProjectConnectionString;
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
                object[] row = { reader.GetValue(0), reader.GetValue(2), reader.GetValue(1) , ((DateTime)reader.GetValue(8)).ToShortDateString(), reader.GetValue(9),
                    reader.GetValue(6), reader.GetValue(5), reader.GetValue(7), reader.GetValue(3), reader.GetValue(4) };
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

        private void AddPatient(PatientWindow info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = "INSERT INTO Patient VALUES(@firstname, @lastname, @housenumber, @street, @city, @postalcode, @province, @dob, @gender)";

            cmd.Parameters.AddWithValue("@firstname", info.firstName);
            cmd.Parameters.AddWithValue("@lastname", info.lastName);
            cmd.Parameters.AddWithValue("@housenumber", info.houseNumber);
            cmd.Parameters.AddWithValue("@street", info.street);
            cmd.Parameters.AddWithValue("@city", info.city);
            cmd.Parameters.AddWithValue("@postalcode", info.postalCode);
            cmd.Parameters.AddWithValue("@province", info.province);
            cmd.Parameters.AddWithValue("@dob", info.dob);
            cmd.Parameters.AddWithValue("@gender", info.gender);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show((string)reader.GetValue(0));
            }

            reader.Close();
            cmd.Dispose();

            LoadPatients();
        }

        private void DeletePatient(int id)
        {

        }

        private void EditPatient(int id, object[] row)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            PatientWindow window = new WindowsFormsApplication1.PatientWindow();
            window.ShowDialog();

            if (window.DialogResult == DialogResult.OK)
            {
                AddPatient(window);
            }

            window.Dispose();
        }
    }
}
