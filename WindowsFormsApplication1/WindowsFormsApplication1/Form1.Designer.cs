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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.tabWards = new System.Windows.Forms.TabPage();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.buttonRegSubmit = new System.Windows.Forms.Button();
            this.buttonRegClear = new System.Windows.Forms.Button();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmpt_291_ProjectDataSet = new WindowsFormsApplication1.Cmpt_291_ProjectDataSet();
            this.cmpt291ProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmpt_291_ProjectDataSet1 = new WindowsFormsApplication1.Cmpt_291_ProjectDataSet1();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new WindowsFormsApplication1.Cmpt_291_ProjectDataSet1TableAdapters.PatientsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmpt_291_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpt291ProjectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpt_291_ProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabConfiguration);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 727);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPatients
            // 
            this.tabPatients.Location = new System.Drawing.Point(8, 39);
            this.tabPatients.Margin = new System.Windows.Forms.Padding(2);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(2);
            this.tabPatients.Size = new System.Drawing.Size(1112, 680);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // tabDoctors
            // 
            this.tabDoctors.Location = new System.Drawing.Point(8, 39);
            this.tabDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Padding = new System.Windows.Forms.Padding(2);
            this.tabDoctors.Size = new System.Drawing.Size(1112, 680);
            this.tabDoctors.TabIndex = 1;
            this.tabDoctors.Text = "Doctors";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // tabWards
            // 
            this.tabWards.Location = new System.Drawing.Point(8, 39);
            this.tabWards.Margin = new System.Windows.Forms.Padding(2);
            this.tabWards.Name = "tabWards";
            this.tabWards.Padding = new System.Windows.Forms.Padding(2);
            this.tabWards.Size = new System.Drawing.Size(1112, 680);
            this.tabWards.TabIndex = 2;
            this.tabWards.Text = "Wards";
            this.tabWards.UseVisualStyleBackColor = true;
            // 
            // tabRegistration
            // 
            this.tabRegistration.Controls.Add(this.comboBox1);
            this.tabRegistration.Controls.Add(this.buttonRegSubmit);
            this.tabRegistration.Controls.Add(this.buttonRegClear);
            this.tabRegistration.Location = new System.Drawing.Point(8, 39);
            this.tabRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(2);
            this.tabRegistration.Size = new System.Drawing.Size(1112, 680);
            this.tabRegistration.TabIndex = 3;
            this.tabRegistration.Text = "Registration";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // buttonRegSubmit
            // 
            this.buttonRegSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegSubmit.Location = new System.Drawing.Point(804, 616);
            this.buttonRegSubmit.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonRegClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegClear.Name = "buttonRegClear";
            this.buttonRegClear.Size = new System.Drawing.Size(150, 60);
            this.buttonRegClear.TabIndex = 0;
            this.buttonRegClear.Text = "Clear";
            this.buttonRegClear.UseVisualStyleBackColor = true;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Location = new System.Drawing.Point(8, 39);
            this.tabConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(2);
            this.tabConfiguration.Size = new System.Drawing.Size(1112, 680);
            this.tabConfiguration.TabIndex = 4;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.patientsBindingSource;
            this.comboBox1.DisplayMember = "firstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(448, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(619, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "PID";
            // 
            // cmpt_291_ProjectDataSet
            // 
            this.cmpt_291_ProjectDataSet.DataSetName = "Cmpt_291_ProjectDataSet";
            this.cmpt_291_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmpt291ProjectDataSetBindingSource
            // 
            this.cmpt291ProjectDataSetBindingSource.DataSource = this.cmpt_291_ProjectDataSet;
            this.cmpt291ProjectDataSetBindingSource.Position = 0;
            // 
            // cmpt_291_ProjectDataSet1
            // 
            this.cmpt_291_ProjectDataSet1.DataSetName = "Cmpt_291_ProjectDataSet1";
            this.cmpt_291_ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.cmpt_291_ProjectDataSet1;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 743);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hospital App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmpt_291_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpt291ProjectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpt_291_ProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.TabPage tabWards;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.Button buttonRegSubmit;
        private System.Windows.Forms.Button buttonRegClear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cmpt291ProjectDataSetBindingSource;
        private Cmpt_291_ProjectDataSet cmpt_291_ProjectDataSet;
        private Cmpt_291_ProjectDataSet1 cmpt_291_ProjectDataSet1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Cmpt_291_ProjectDataSet1TableAdapters.PatientsTableAdapter patientsTableAdapter;
    }
}

