namespace WindowsFormsApplication1
{
    partial class DoctorWindow
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
            this.docFirstNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.docLastNameText = new System.Windows.Forms.TextBox();
            this.docDob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelDoctor = new System.Windows.Forms.Button();
            this.buttonSubmitDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // docFirstNameText
            // 
            this.docFirstNameText.Location = new System.Drawing.Point(314, 37);
            this.docFirstNameText.Name = "docFirstNameText";
            this.docFirstNameText.Size = new System.Drawing.Size(300, 31);
            this.docFirstNameText.TabIndex = 0;
            this.docFirstNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // docLastNameText
            // 
            this.docLastNameText.Location = new System.Drawing.Point(9, 37);
            this.docLastNameText.Name = "docLastNameText";
            this.docLastNameText.Size = new System.Drawing.Size(300, 31);
            this.docLastNameText.TabIndex = 3;
            // 
            // docDob
            // 
            this.docDob.Location = new System.Drawing.Point(9, 140);
            this.docDob.Name = "docDob";
            this.docDob.Size = new System.Drawing.Size(259, 31);
            this.docDob.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Birth";
            // 
            // buttonCancelDoctor
            // 
            this.buttonCancelDoctor.Location = new System.Drawing.Point(462, 193);
            this.buttonCancelDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelDoctor.Name = "buttonCancelDoctor";
            this.buttonCancelDoctor.Size = new System.Drawing.Size(152, 60);
            this.buttonCancelDoctor.TabIndex = 22;
            this.buttonCancelDoctor.Text = "Cancel";
            this.buttonCancelDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitDoctor
            // 
            this.buttonSubmitDoctor.Location = new System.Drawing.Point(301, 193);
            this.buttonSubmitDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmitDoctor.Name = "buttonSubmitDoctor";
            this.buttonSubmitDoctor.Size = new System.Drawing.Size(157, 60);
            this.buttonSubmitDoctor.TabIndex = 21;
            this.buttonSubmitDoctor.Text = "Submit";
            this.buttonSubmitDoctor.UseVisualStyleBackColor = true;
            // 
            // DoctorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 264);
            this.Controls.Add(this.buttonCancelDoctor);
            this.Controls.Add(this.buttonSubmitDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docDob);
            this.Controls.Add(this.docLastNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docFirstNameText);
            this.Name = "DoctorWindow";
            this.Text = "Doctor Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox docFirstNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox docLastNameText;
        private System.Windows.Forms.DateTimePicker docDob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelDoctor;
        private System.Windows.Forms.Button buttonSubmitDoctor;
    }
}