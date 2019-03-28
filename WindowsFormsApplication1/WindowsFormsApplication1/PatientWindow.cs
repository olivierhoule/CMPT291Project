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
    public partial class PatientWindow : Form
    {
        public static string firstName;
        public static string lastName;
        public static DateTime dob;
        public static string gender;
        public static int houseNumber;
        public static string street;
        public static string city;
        public static string postalCode;
        public static string province;

        private string errorMessage;
        private string houseNumberString;

        public PatientWindow()
        {
            InitializeComponent();
        }

        private Boolean validateInputs()
        {
            if (firstName.Length > 50 ||
                firstName.Length == 0 ||
                lastName.Length > 50 ||
                lastName.Length == 0 || 
                DateTime.Now - dob < TimeSpan.Zero ||
                gender == null ||
                gender.Length == 0 ||
                !Int32.TryParse(houseNumberString, out houseNumber) ||
                street.Length > 50 ||
                street.Length == 0 ||
                city.Length > 50 ||
                city.Length == 0 ||
                postalCode.Length > 6 ||
                postalCode.Length == 0 ||
                province == null ||
                province.Length == 0)
            {
                errorMessage = "Please fill all fields properly.";
                return false;
            }

            return true;
        }

        private void buttonSubmitPatient_Click(object sender, EventArgs e)
        {
            firstName = textFirstName.Text;
            lastName = textLastName.Text;
            dob = PatientDob.Value;
            gender = genderPickerPatient.SelectedText;
            houseNumberString = textHouseNumber.Text;
            street = textStreet.Text;
            city = textCity.Text;
            postalCode = textPostalCode.Text.Replace(" ", "");
            province = provincePicker.SelectedText;

            if (!validateInputs())
            {
                MessageBox.Show(errorMessage);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
