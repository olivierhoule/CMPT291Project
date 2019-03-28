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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabWards = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.buttonRegSubmit = new System.Windows.Forms.Button();
            this.buttonRegClear = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 727);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.dataGridView1);
            this.tabPatients.Location = new System.Drawing.Point(8, 39);
            this.tabPatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPatients.Size = new System.Drawing.Size(1112, 680);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnLastName,
            this.columnFirstName});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(623, 672);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnID
            // 
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
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
            // tabDoctors
            // 
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
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(623, 672);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabWards
            // 
            this.tabWards.Controls.Add(this.dataGridView3);
            this.tabWards.Location = new System.Drawing.Point(8, 39);
            this.tabWards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabWards.Name = "tabWards";
            this.tabWards.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabWards.Size = new System.Drawing.Size(1112, 680);
            this.tabWards.TabIndex = 2;
            this.tabWards.Text = "Wards";
            this.tabWards.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(4, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(623, 672);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            this.dataGridView4.Size = new System.Drawing.Size(623, 672);
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
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabWards;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

