using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RegistryWindow : Form
    {
        public int pid;
        public int wid;
        public int did;
        public string status;
        public string notes;

        private string errorMessage;

        public RegistryWindow()
        {
            InitializeComponent();
        }

        public RegistryWindow(DataGridViewRow row)
        {
            InitializeComponent();

            patientIdText.Text = Convert.ToString(row.Cells[1].Value);
            docIdText.Text = Convert.ToString(row.Cells[2].Value);
            wardIdText.Text = Convert.ToString(row.Cells[3].Value);
            textStatus.Text = (string)row.Cells[4].Value;
            docNotesText.Text = (string)row.Cells[5].Value;

            patientIdText.ReadOnly = true;
        }

        private bool validateInputs()
        {
            if (status.Length == 0 ||
                status.Length > 50)
            {
                errorMessage = "Error with status";
                return false;
            }

            if (notes.Length == 0 ||
                notes.Length > 200)
            {
                errorMessage = "Error with notes";
                return false;
            }

            if (!Int32.TryParse(patientIdText.Text, out pid))
            {
                errorMessage = "Error with patient id";
                return false;
            }

            if (!Int32.TryParse(docIdText.Text, out did))
            {
                errorMessage = "Error with doctor id";
                return false;
            }

            if (!Int32.TryParse(wardIdText.Text, out wid))
            {
                errorMessage = "Error with ward id";
                return false;
            }

            return true;
        }

        private void buttonSubmitRegistry_Click(object sender, EventArgs e)
        {
            status = textStatus.Text;
            notes = docNotesText.Text;

            if (!validateInputs())
            {
                MessageBox.Show(errorMessage);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelRegistry_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
