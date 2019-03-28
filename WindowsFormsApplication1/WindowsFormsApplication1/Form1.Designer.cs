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
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabWards = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.buttonRegSubmit = new System.Windows.Forms.Button();
            this.buttonRegClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(10, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 727);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.buttonEditPatient);
            this.tabPatients.Controls.Add(this.buttonRemovePatient);
            this.tabPatients.Controls.Add(this.buttonAddPatient);
            this.tabPatients.Controls.Add(this.dataGridView1);
            this.tabPatients.Location = new System.Drawing.Point(8, 39);
            this.tabPatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPatients.Size = new System.Drawing.Size(1112, 680);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            this.tabPatients.Click += new System.EventHandler(this.tabPatients_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(928, 627);
            this.buttonEditPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(180, 49);
            this.buttonEditPatient.TabIndex = 3;
            this.buttonEditPatient.Text = "Edit Patient";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePatient
            // 
            this.buttonRemovePatient.Location = new System.Drawing.Point(928, 579);
            this.buttonRemovePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemovePatient.Name = "buttonRemovePatient";
            this.buttonRemovePatient.Size = new System.Drawing.Size(180, 43);
            this.buttonRemovePatient.TabIndex = 2;
            this.buttonRemovePatient.Text = "Remove Patient";
            this.buttonRemovePatient.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(928, 531);
            this.buttonAddPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(180, 43);
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
            this.columnPostalCode,
            this.columnCity,
            this.columnProvince});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(844, 672);
            this.dataGridView1.TabIndex = 0;
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
            // tabDoctors
            // 
            this.tabDoctors.Controls.Add(this.button1);
            this.tabDoctors.Controls.Add(this.button2);
            this.tabDoctors.Controls.Add(this.button3);
            this.tabDoctors.Controls.Add(this.dataGridView2);
            this.tabDoctors.Location = new System.Drawing.Point(8, 39);
            this.tabDoctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDoctors.Size = new System.Drawing.Size(1112, 680);
            this.tabDoctors.TabIndex = 1;
            this.tabDoctors.Text = "Doctors";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(844, 672);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabWards
            // 
            this.tabWards.Controls.Add(this.button4);
            this.tabWards.Controls.Add(this.button5);
            this.tabWards.Controls.Add(this.button6);
            this.tabWards.Controls.Add(this.dataGridView3);
            this.tabWards.Location = new System.Drawing.Point(8, 39);
            this.tabWards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabWards.Name = "tabWards";
            this.tabWards.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabWards.Size = new System.Drawing.Size(1112, 680);
            this.tabWards.TabIndex = 2;
            this.tabWards.Text = "Wards";
            this.tabWards.UseVisualStyleBackColor = true;
            this.tabWards.Click += new System.EventHandler(this.tabWards_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(4, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(844, 672);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabRegistration
            // 
            this.tabRegistration.Controls.Add(this.dataGridView4);
            this.tabRegistration.Controls.Add(this.buttonRegSubmit);
            this.tabRegistration.Controls.Add(this.buttonRegClear);
            this.tabRegistration.Location = new System.Drawing.Point(8, 39);
            this.tabRegistration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistration.Size = new System.Drawing.Size(1112, 680);
            this.tabRegistration.TabIndex = 3;
            this.tabRegistration.Text = "Registration";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(4, 4);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 40;
            this.dataGridView4.Size = new System.Drawing.Size(1104, 548);
            this.dataGridView4.TabIndex = 2;
            // 
            // buttonRegSubmit
            // 
            this.buttonRegSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegSubmit.Location = new System.Drawing.Point(804, 616);
            this.buttonRegSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegSubmit.Name = "buttonRegSubmit";
            this.buttonRegSubmit.Size = new System.Drawing.Size(150, 60);
            this.buttonRegSubmit.TabIndex = 1;
            this.buttonRegSubmit.Text = "Submit";
            this.buttonRegSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonRegClear
            // 
            this.buttonRegClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegClear.Location = new System.Drawing.Point(958, 616);
            this.buttonRegClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegClear.Name = "buttonRegClear";
            this.buttonRegClear.Size = new System.Drawing.Size(150, 60);
            this.buttonRegClear.TabIndex = 0;
            this.buttonRegClear.Text = "Clear";
            this.buttonRegClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(928, 627);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit Doctor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(928, 579);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove Doctor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(928, 531);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Doctor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(928, 627);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "Edit Ward";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(928, 580);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "Remove Ward";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(928, 533);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 43);
            this.button6.TabIndex = 4;
            this.button6.Text = "Add Ward";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 743);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProvince;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

