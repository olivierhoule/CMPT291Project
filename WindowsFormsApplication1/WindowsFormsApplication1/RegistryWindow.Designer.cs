namespace WindowsFormsApplication1
{
    partial class RegistryWindow
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
            this.patientIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.docIdText = new System.Windows.Forms.TextBox();
            this.buttonCancelRegistry = new System.Windows.Forms.Button();
            this.buttonSubmitRegistry = new System.Windows.Forms.Button();
            this.wardIdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.docNotesText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientIdText
            // 
            this.patientIdText.Location = new System.Drawing.Point(9, 41);
            this.patientIdText.Name = "patientIdText";
            this.patientIdText.Size = new System.Drawing.Size(128, 31);
            this.patientIdText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor ID";
            // 
            // docIdText
            // 
            this.docIdText.Location = new System.Drawing.Point(177, 41);
            this.docIdText.Name = "docIdText";
            this.docIdText.Size = new System.Drawing.Size(128, 31);
            this.docIdText.TabIndex = 3;
            // 
            // buttonCancelRegistry
            // 
            this.buttonCancelRegistry.Location = new System.Drawing.Point(319, 470);
            this.buttonCancelRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelRegistry.Name = "buttonCancelRegistry";
            this.buttonCancelRegistry.Size = new System.Drawing.Size(152, 60);
            this.buttonCancelRegistry.TabIndex = 22;
            this.buttonCancelRegistry.Text = "Cancel";
            this.buttonCancelRegistry.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitRegistry
            // 
            this.buttonSubmitRegistry.Location = new System.Drawing.Point(157, 470);
            this.buttonSubmitRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmitRegistry.Name = "buttonSubmitRegistry";
            this.buttonSubmitRegistry.Size = new System.Drawing.Size(157, 60);
            this.buttonSubmitRegistry.TabIndex = 21;
            this.buttonSubmitRegistry.Text = "Submit";
            this.buttonSubmitRegistry.UseVisualStyleBackColor = true;
            // 
            // wardIdText
            // 
            this.wardIdText.Location = new System.Drawing.Point(343, 41);
            this.wardIdText.Name = "wardIdText";
            this.wardIdText.Size = new System.Drawing.Size(128, 31);
            this.wardIdText.TabIndex = 24;
            this.wardIdText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ward ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Doctor Notes";
            // 
            // docNotesText
            // 
            this.docNotesText.Location = new System.Drawing.Point(9, 132);
            this.docNotesText.Name = "docNotesText";
            this.docNotesText.Size = new System.Drawing.Size(462, 316);
            this.docNotesText.TabIndex = 29;
            this.docNotesText.Text = "";
            // 
            // RegistryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 539);
            this.Controls.Add(this.docNotesText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wardIdText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelRegistry);
            this.Controls.Add(this.buttonSubmitRegistry);
            this.Controls.Add(this.docIdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientIdText);
            this.Controls.Add(this.label1);
            this.Name = "RegistryWindow";
            this.Text = "Registry Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox docIdText;
        private System.Windows.Forms.Button buttonCancelRegistry;
        private System.Windows.Forms.Button buttonSubmitRegistry;
        private System.Windows.Forms.TextBox wardIdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox docNotesText;
    }
}