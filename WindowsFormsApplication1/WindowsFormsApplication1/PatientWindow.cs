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
        public string firstName;
        public string lastName;
        public DateTime dob;
        public string gender;
        public int houseNumber;
        public string street;
        public string city;
        public string postalCode;
        public string province;

        private string errorMessage;
        private string houseNumberString;

        public PatientWindow()
        {
            InitializeComponent();
        }

        private Boolean validateInputs()
        {
            if (firstName.Length > 50 ||
                firstName.Length == 0)
            {
                errorMessage = "Error with first name";
                return false;
            }
            
            if (lastName.Length > 50 ||
                lastName.Length == 0)
            {
                errorMessage = "Error with last name";
                return false;
            }

            if (DateTime.Now - dob < TimeSpan.Zero)
            {
                errorMessage = "Error with date of birth";
                return false;
            }

            if (gender == null ||
                gender.Length == 0)
            {
                errorMessage = "Error with gender";
                return false;
            }

            if (!Int32.TryParse(houseNumberString, out houseNumber))
            {
                errorMessage = "Error with house number";
                return false;
            }

            if (street.Length > 50 ||
                street.Length == 0)
            {
                errorMessage = "Error with street";
                return false;
            }

            if (city.Length > 50 ||
                city.Length == 0)
            {
                errorMessage = "Error with city";
                return false;
            }

            if (postalCode.Length > 6 ||
                postalCode.Length == 0)
            {
                errorMessage = "Error with postal code";
                return false;
            }

            if (province == null ||
                province.Length == 0)
            {
                errorMessage = "Error with province";
                return false;
            }

            return true;
        }

        private void buttonSubmitPatient_Click(object sender, EventArgs e)
        {
            firstName = textFirstName.Text;
            lastName = textLastName.Text;
            dob = PatientDob.Value;
            gender = genderPickerPatient.Text;
            houseNumberString = textHouseNumber.Text;
            street = textStreet.Text;
            city = textCity.Text;
            postalCode = textPostalCode.Text.Replace(" ", "");
            province = provincePicker.Text;

            if (!validateInputs())
            {
                MessageBox.Show(errorMessage);
                return;
            }

            MessageBox.Show("Successfully submitted patient");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
