namespace WindowsFormsApplication1
{
    partial class PatientWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textPostalCode = new System.Windows.Forms.TextBox();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.PatientDob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genderPickerPatient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.provincePicker = new System.Windows.Forms.ComboBox();
            this.buttonSubmitPatient = new System.Windows.Forms.Button();
            this.buttonCancelPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(9, 35);
            this.textLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(300, 31);
            this.textLastName.TabIndex = 0;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(313, 35);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(300, 31);
            this.textFirstName.TabIndex = 1;
            // 
            // textPostalCode
            // 
            this.textPostalCode.Location = new System.Drawing.Point(223, 320);
            this.textPostalCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPostalCode.Name = "textPostalCode";
            this.textPostalCode.Size = new System.Drawing.Size(174, 31);
            this.textPostalCode.TabIndex = 2;
            // 
            // textStreet
            // 
            this.textStreet.Location = new System.Drawing.Point(228, 233);
            this.textStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textStreet.Name = "textStreet";
            this.textStreet.Size = new System.Drawing.Size(385, 31);
            this.textStreet.TabIndex = 3;
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Location = new System.Drawing.Point(9, 234);
            this.textHouseNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.Size = new System.Drawing.Size(76, 31);
            this.textHouseNumber.TabIndex = 5;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(9, 320);
            this.textCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(210, 31);
            this.textCity.TabIndex = 6;
            // 
            // PatientDob
            // 
            this.PatientDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PatientDob.Location = new System.Drawing.Point(9, 130);
            this.PatientDob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatientDob.Name = "PatientDob";
            this.PatientDob.Size = new System.Drawing.Size(259, 31);
            this.PatientDob.TabIndex = 7;
            this.PatientDob.Value = new System.DateTime(2019, 3, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date of Birth";
            // 
            // genderPickerPatient
            // 
            this.genderPickerPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderPickerPatient.FormattingEnabled = true;
            this.genderPickerPatient.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.genderPickerPatient.Location = new System.Drawing.Point(313, 132);
            this.genderPickerPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderPickerPatient.Name = "genderPickerPatient";
            this.genderPickerPatient.Size = new System.Drawing.Size(128, 33);
            this.genderPickerPatient.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "House Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Street";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Province";
            // 
            // provincePicker
            // 
            this.provincePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provincePicker.FormattingEnabled = true;
            this.provincePicker.Items.AddRange(new object[] {
            "AB",
            "BC",
            "SK",
            "MB",
            "NB",
            "NL",
            "NS",
            "ON",
            "PE",
            "QC",
            "NT",
            "NU",
            "YT"});
            this.provincePicker.Location = new System.Drawing.Point(401, 320);
            this.provincePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.provincePicker.Name = "provincePicker";
            this.provincePicker.Size = new System.Drawing.Size(166, 33);
            this.provincePicker.TabIndex = 18;
            // 
            // buttonSubmitPatient
            // 
            this.buttonSubmitPatient.Location = new System.Drawing.Point(299, 387);
            this.buttonSubmitPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmitPatient.Name = "buttonSubmitPatient";
            this.buttonSubmitPatient.Size = new System.Drawing.Size(157, 60);
            this.buttonSubmitPatient.TabIndex = 19;
            this.buttonSubmitPatient.Text = "Submit";
            this.buttonSubmitPatient.UseVisualStyleBackColor = true;
            this.buttonSubmitPatient.Click += new System.EventHandler(this.buttonSubmitPatient_Click);
            // 
            // buttonCancelPatient
            // 
            this.buttonCancelPatient.Location = new System.Drawing.Point(461, 387);
            this.buttonCancelPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelPatient.Name = "buttonCancelPatient";
            this.buttonCancelPatient.Size = new System.Drawing.Size(152, 60);
            this.buttonCancelPatient.TabIndex = 20;
            this.buttonCancelPatient.Text = "Cancel";
            this.buttonCancelPatient.UseVisualStyleBackColor = true;
            // 
            // PatientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 460);
            this.Controls.Add(this.buttonCancelPatient);
            this.Controls.Add(this.buttonSubmitPatient);
            this.Controls.Add(this.provincePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genderPickerPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientDob);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textHouseNumber);
            this.Controls.Add(this.textStreet);
            this.Controls.Add(this.textPostalCode);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textLastName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PatientWindow";
            this.Text = "Patient Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textPostalCode;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.DateTimePicker PatientDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderPickerPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox provincePicker;
        private System.Windows.Forms.Button buttonSubmitPatient;
        private System.Windows.Forms.Button buttonCancelPatient;
    }
}