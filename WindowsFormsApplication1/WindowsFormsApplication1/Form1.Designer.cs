namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonRemovePatient = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabWards = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.buttonRegSubmit = new System.Windows.Forms.Button();
            this.buttonRegClear = new System.Windows.Forms.Button();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabWards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPatients);
            this.tabControl1.Controls.Add(this.tabDoctors);
            this.tabControl1.Controls.Add(this.tabWards);
            this.tabControl1.Controls.Add(this.tabRegistration);
            this.tabControl1.Location = new System.Drawing.Point(13, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1504, 901);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.buttonEditPatient);
            this.tabPatients.Controls.Add(this.buttonRemovePatient);
            this.tabPatients.Controls.Add(this.buttonAddPatient);
            this.tabPatients.Controls.Add(this.dataGridView1);
            this.tabPatients.Location = new System.Drawing.Point(10, 48);
            this.tabPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPatients.Size = new System.Drawing.Size(1484, 843);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(1251, 777);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(227, 61);
            this.buttonEditPatient.TabIndex = 3;
            this.buttonEditPatient.Text = "Edit Patient";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePatient
            // 
            this.buttonRemovePatient.Location = new System.Drawing.Point(1251, 718);
            this.buttonRemovePatient.Name = "buttonRemovePatient";
            this.buttonRemovePatient.Size = new System.Drawing.Size(227, 53);
            this.buttonRemovePatient.TabIndex = 2;
            this.buttonRemovePatient.Text = "Remove Patient";
            this.buttonRemovePatient.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(1251, 659);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(227, 53);
            this.buttonAddPatient.TabIndex = 1;
            this.buttonAddPatient.Text = "Add Patient";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnLastName,
            this.columnFirstName,
            this.columnDOB,
            this.columnGender,
            this.columnPostalCode,
            this.columnCity,
            this.columnProvince,
            this.columnHouseNumber,
            this.columnStreet});
            this.dataGridView1.Location = new System.Drawing.Point(6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 833);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabDoctors
            // 
            this.tabDoctors.Controls.Add(this.dataGridView2);
            this.tabDoctors.Location = new System.Drawing.Point(10, 48);
            this.tabDoctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoctors.Size = new System.Drawing.Size(1484, 843);
            this.tabDoctors.TabIndex = 1;
            this.tabDoctors.Text = "Doctors";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(211, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(608, 440);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabWards
            // 
            this.tabWards.Controls.Add(this.dataGridView3);
            this.tabWards.Location = new System.Drawing.Point(10, 48);
            this.tabWards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWards.Name = "tabWards";
            this.tabWards.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWards.Size = new System.Drawing.Size(1484, 843);
            this.tabWards.TabIndex = 2;
            this.tabWards.Text = "Wards";
            this.tabWards.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(213, 141);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabRegistration
            // 
            this.tabRegistration.Controls.Add(this.dataGridView4);
            this.tabRegistration.Controls.Add(this.buttonRegSubmit);
            this.tabRegistration.Controls.Add(this.buttonRegClear);
            this.tabRegistration.Location = new System.Drawing.Point(10, 48);
            this.tabRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRegistration.Size = new System.Drawing.Size(1484, 843);
            this.tabRegistration.TabIndex = 3;
            this.tabRegistration.Text = "Registration";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(211, 136);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 40;
            this.dataGridView4.Size = new System.Drawing.Size(512, 321);
            this.dataGridView4.TabIndex = 2;
            // 
            // buttonRegSubmit
            // 
            this.buttonRegSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegSubmit.Location = new System.Drawing.Point(1072, 764);
            this.buttonRegSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegSubmit.Name = "buttonRegSubmit";
            this.buttonRegSubmit.Size = new System.Drawing.Size(200, 74);
            this.buttonRegSubmit.TabIndex = 1;
            this.buttonRegSubmit.Text = "Submit";
            this.buttonRegSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonRegClear
            // 
            this.buttonRegClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegClear.Location = new System.Drawing.Point(1277, 764);
            this.buttonRegClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegClear.Name = "buttonRegClear";
            this.buttonRegClear.Size = new System.Drawing.Size(200, 74);
            this.buttonRegClear.TabIndex = 0;
            this.buttonRegClear.Text = "Clear";
            this.buttonRegClear.UseVisualStyleBackColor = true;
            // 
            // columnID
            // 
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.Width = 10;
            // 
            // columnLastName
            // 
            this.columnLastName.HeaderText = "Last Name";
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.ReadOnly = true;
            // 
            // columnFirstName
            // 
            this.columnFirstName.HeaderText = "First Name";
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.ReadOnly = true;
            // 
            // columnDOB
            // 
            this.columnDOB.HeaderText = "Date of Birth";
            this.columnDOB.Name = "columnDOB";
            this.columnDOB.ReadOnly = true;
            // 
            // columnGender
            // 
            this.columnGender.HeaderText = "Gender";
            this.columnGender.Name = "columnGender";
            this.columnGender.ReadOnly = true;
            // 
            // columnPostalCode
            // 
            this.columnPostalCode.HeaderText = "Postal Code";
            this.columnPostalCode.Name = "columnPostalCode";
            this.columnPostalCode.ReadOnly = true;
            // 
            // columnCity
            // 
            this.columnCity.HeaderText = "City";
            this.columnCity.Name = "columnCity";
            this.columnCity.ReadOnly = true;
            // 
            // columnProvince
            // 
            this.columnProvince.HeaderText = "Province";
            this.columnProvince.Name = "columnProvince";
            this.columnProvince.ReadOnly = true;
            // 
            // columnHouseNumber
            // 
            this.columnHouseNumber.HeaderText = "House Number";
            this.columnHouseNumber.Name = "columnHouseNumber";
            this.columnHouseNumber.ReadOnly = true;
            // 
            // columnStreet
            // 
            this.columnStreet.HeaderText = "Street";
            this.columnStreet.Name = "columnStreet";
            this.columnStreet.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 921);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Hospital App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabWards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.Button buttonRegSubmit;
        private System.Windows.Forms.Button buttonRegClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabWards;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonRemovePatient;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStreet;
    }
}

