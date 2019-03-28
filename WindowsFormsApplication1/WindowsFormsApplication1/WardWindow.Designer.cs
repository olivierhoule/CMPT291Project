namespace WindowsFormsApplication1
{
    partial class WardWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.WardTypeTextBox = new System.Windows.Forms.TextBox();
            this.WardCapacityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WardDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ward Type ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WardTypeTextBox
            // 
            this.WardTypeTextBox.Location = new System.Drawing.Point(18, 54);
            this.WardTypeTextBox.Name = "WardTypeTextBox";
            this.WardTypeTextBox.Size = new System.Drawing.Size(196, 31);
            this.WardTypeTextBox.TabIndex = 1;
            this.WardTypeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WardCapacityTextBox
            // 
            this.WardCapacityTextBox.Location = new System.Drawing.Point(277, 53);
            this.WardCapacityTextBox.Name = "WardCapacityTextBox";
            this.WardCapacityTextBox.Size = new System.Drawing.Size(144, 31);
            this.WardCapacityTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Capacity ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // WardDate
            // 
            this.WardDate.Location = new System.Drawing.Point(18, 147);
            this.WardDate.Name = "WardDate";
            this.WardDate.Size = new System.Drawing.Size(267, 31);
            this.WardDate.TabIndex = 6;
            this.WardDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // WardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 209);
            this.Controls.Add(this.WardDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WardCapacityTextBox);
            this.Controls.Add(this.WardTypeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "WardWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.WardWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WardTypeTextBox;
        private System.Windows.Forms.TextBox WardCapacityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker WardDate;
    }
}