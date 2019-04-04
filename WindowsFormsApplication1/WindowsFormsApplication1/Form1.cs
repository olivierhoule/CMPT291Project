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
        public static SqlConnection db;

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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patient ORDER BY pid DESC", db);
            SqlDataReader reader = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();
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

            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                object[] row = { reader.GetValue(0), reader.GetValue(2), reader.GetValue(1), ((DateTime)reader.GetValue(3)).ToShortDateString() };
                dataGridView2.Rows.Add(row);
            }

            reader.Close();
            cmd.Dispose();
        }

        private void LoadWards()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ward", db);
            SqlDataReader reader = cmd.ExecuteReader();

            dataGridView3.Rows.Clear();
            while (reader.Read())
            {
                object[] row = { reader.GetValue(0), reader.GetValue(1), reader.GetValue(3), ((DateTime)reader.GetValue(2)).ToShortDateString() };
                dataGridView3.Rows.Add(row);
            }

            reader.Close();
            cmd.Dispose();
        }

        private void LoadRegistrations()
        {
            SqlCommand cmd = new SqlCommand("SELECT R.RID, P.PID, CONCAT(P.last_name, ', ', P.first_name), R.doc_id, CONCAT(D.last_name, ', ', D.first_name), R.ward_id, W.ward_type, R.status, R.doc_notes, R.date FROM Registration R, Patient P, Doctor D, Ward W WHERE R.PID = P.PID AND R.doc_id = D.doc_id AND R.ward_id = W.ward_id", db);
            SqlDataReader reader = cmd.ExecuteReader();

            dataGridView4.Rows.Clear();
            while (reader.Read())
            {
                object[] row = { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7), reader.GetValue(8), ((DateTime)reader.GetValue(9)).ToShortDateString() };
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

            MessageBox.Show("Successfully added new patient");

            reader.Close();
            cmd.Dispose();
            LoadPatients();
        }

        private void DeletePatients(List<int> ids)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = String.Format("DELETE FROM Patient WHERE pid IN ({0})", String.Join(", ", ids.ToArray()));

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show((string)reader.GetValue(0));
            }

            MessageBox.Show("Successfully deleted patient(s)");

            reader.Close();
            cmd.Dispose();
            LoadPatients();
        }

        private void EditPatient(int id, PatientWindow info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = "UPDATE Patient SET first_name = @fname, last_name = @lname, house_number = @house, street = @street, city = @city, postal_code = @pcode, province = @prov, date_of_birth = @dob, gender = @gender WHERE pid = @id";

            cmd.Parameters.AddWithValue("@fname", info.firstName);
            cmd.Parameters.AddWithValue("@lname", info.lastName);
            cmd.Parameters.AddWithValue("@house", info.houseNumber);
            cmd.Parameters.AddWithValue("@street", info.street);
            cmd.Parameters.AddWithValue("@city", info.city);
            cmd.Parameters.AddWithValue("@pcode", info.postalCode);
            cmd.Parameters.AddWithValue("@prov", info.province);
            cmd.Parameters.AddWithValue("@dob", info.dob);
            cmd.Parameters.AddWithValue("@gender", info.gender);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show((string)reader.GetValue(0));
            }

            MessageBox.Show("Successfully edited patient");

            reader.Close();
            cmd.Dispose();
            LoadPatients();
        }

        private void AddRegistration(RegistryWindow info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = "INSERT INTO Registration VALUES(@pid, @did, @wid, GETDATE(), @notes, @status)";

            cmd.Parameters.AddWithValue("@pid", info.pid);
            cmd.Parameters.AddWithValue("@did", info.did);
            cmd.Parameters.AddWithValue("@wid", info.wid);
            cmd.Parameters.AddWithValue("@notes", info.notes);
            cmd.Parameters.AddWithValue("@status", info.status);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show((string)reader.GetValue(0));
            }

            MessageBox.Show("Successfully added new registration");

            reader.Close();
            cmd.Dispose();
            LoadRegistrations();
        }

        private void EditRegistration(int id, RegistryWindow info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = "UPDATE Patient SET ward_id = @wid, doc_id = @did, status = @status, doc_notes = @notes WHERE rid = @id";

            cmd.Parameters.AddWithValue("@wid", info.wid);
            cmd.Parameters.AddWithValue("@did", info.did);
            cmd.Parameters.AddWithValue("@status", info.status);
            cmd.Parameters.AddWithValue("@notes", info.notes);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show((string)reader.GetValue(0));
            }

            MessageBox.Show("Successfully edited registration");

            reader.Close();
            cmd.Dispose();
            LoadRegistrations();
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

        private void buttonRemovePatient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one entire row.");
                return;
            }
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ids.Add((int)row.Cells[0].Value);
            }

            DeletePatients(ids);
        }


        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select only one row to edit.");
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            PatientWindow window = new WindowsFormsApplication1.PatientWindow(row);
            window.ShowDialog();

            if (window.DialogResult == DialogResult.OK)
            {
                EditPatient((int)row.Cells[0].Value, window);
            }

            window.Dispose();
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

        private void buttonRegSubmit_Click(object sender, EventArgs e)
        {
            RegistryWindow window = new RegistryWindow();
            window.ShowDialog();

            if (window.DialogResult == DialogResult.OK)
            {
                AddRegistration(window);
            }

            window.Dispose();
        }

        private void buttonRegEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select only one row to edit.");
                return;
            }
            DataGridViewRow row = dataGridView4.SelectedRows[0];

            RegistryWindow window = new RegistryWindow();
            window.ShowDialog();

            if (window.DialogResult == DialogResult.OK)
            {
                EditRegistration((int)row.Cells[0].Value, window);
            }

            window.Dispose();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
