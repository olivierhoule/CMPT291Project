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
            this.wardTypeText = new System.Windows.Forms.TextBox();
            this.wardCapacityText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wardDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelWard = new System.Windows.Forms.Button();
            this.buttonSubmitWard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ward Type ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wardTypeText
            // 
            this.wardTypeText.Location = new System.Drawing.Point(9, 54);
            this.wardTypeText.Name = "wardTypeText";
            this.wardTypeText.Size = new System.Drawing.Size(300, 31);
            this.wardTypeText.TabIndex = 1;
            this.wardTypeText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // wardCapacityText
            // 
            this.wardCapacityText.Location = new System.Drawing.Point(315, 54);
            this.wardCapacityText.Name = "wardCapacityText";
            this.wardCapacityText.Size = new System.Drawing.Size(144, 31);
            this.wardCapacityText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 26);
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
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // wardDate
            // 
            this.wardDate.Location = new System.Drawing.Point(9, 147);
            this.wardDate.Name = "wardDate";
            this.wardDate.Size = new System.Drawing.Size(259, 31);
            this.wardDate.TabIndex = 6;
            this.wardDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonCancelWard
            // 
            this.buttonCancelWard.Location = new System.Drawing.Point(307, 214);
            this.buttonCancelWard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelWard.Name = "buttonCancelWard";
            this.buttonCancelWard.Size = new System.Drawing.Size(152, 60);
            this.buttonCancelWard.TabIndex = 22;
            this.buttonCancelWard.Text = "Cancel";
            this.buttonCancelWard.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitWard
            // 
            this.buttonSubmitWard.Location = new System.Drawing.Point(145, 214);
            this.buttonSubmitWard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmitWard.Name = "buttonSubmitWard";
            this.buttonSubmitWard.Size = new System.Drawing.Size(157, 60);
            this.buttonSubmitWard.TabIndex = 21;
            this.buttonSubmitWard.Text = "Submit";
            this.buttonSubmitWard.UseVisualStyleBackColor = true;
            // 
            // WardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 285);
            this.Controls.Add(this.buttonCancelWard);
            this.Controls.Add(this.buttonSubmitWard);
            this.Controls.Add(this.wardDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wardCapacityText);
            this.Controls.Add(this.wardTypeText);
            this.Controls.Add(this.label1);
            this.Name = "WardWindow";
            this.Text = "Ward Window";
            this.Load += new System.EventHandler(this.WardWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wardTypeText;
        private System.Windows.Forms.TextBox wardCapacityText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker wardDate;
        private System.Windows.Forms.Button buttonCancelWard;
        private System.Windows.Forms.Button buttonSubmitWard;
    }
}