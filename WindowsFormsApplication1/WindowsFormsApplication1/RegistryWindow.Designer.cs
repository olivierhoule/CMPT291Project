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
            this.label4 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // patientIdText
            // 
            this.patientIdText.Location = new System.Drawing.Point(12, 51);
            this.patientIdText.Margin = new System.Windows.Forms.Padding(4);
            this.patientIdText.Name = "patientIdText";
            this.patientIdText.Size = new System.Drawing.Size(169, 38);
            this.patientIdText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor ID";
            // 
            // docIdText
            // 
            this.docIdText.Location = new System.Drawing.Point(236, 51);
            this.docIdText.Margin = new System.Windows.Forms.Padding(4);
            this.docIdText.Name = "docIdText";
            this.docIdText.Size = new System.Drawing.Size(169, 38);
            this.docIdText.TabIndex = 3;
            // 
            // buttonCancelRegistry
            // 
            this.buttonCancelRegistry.Location = new System.Drawing.Point(423, 733);
            this.buttonCancelRegistry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelRegistry.Name = "buttonCancelRegistry";
            this.buttonCancelRegistry.Size = new System.Drawing.Size(203, 74);
            this.buttonCancelRegistry.TabIndex = 22;
            this.buttonCancelRegistry.Text = "Cancel";
            this.buttonCancelRegistry.UseVisualStyleBackColor = true;
            this.buttonCancelRegistry.Click += new System.EventHandler(this.buttonCancelRegistry_Click);
            // 
            // buttonSubmitRegistry
            // 
            this.buttonSubmitRegistry.Location = new System.Drawing.Point(208, 733);
            this.buttonSubmitRegistry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmitRegistry.Name = "buttonSubmitRegistry";
            this.buttonSubmitRegistry.Size = new System.Drawing.Size(209, 74);
            this.buttonSubmitRegistry.TabIndex = 21;
            this.buttonSubmitRegistry.Text = "Submit";
            this.buttonSubmitRegistry.UseVisualStyleBackColor = true;
            this.buttonSubmitRegistry.Click += new System.EventHandler(this.buttonSubmitRegistry_Click);
            // 
            // wardIdText
            // 
            this.wardIdText.Location = new System.Drawing.Point(457, 51);
            this.wardIdText.Margin = new System.Windows.Forms.Padding(4);
            this.wardIdText.Name = "wardIdText";
            this.wardIdText.Size = new System.Drawing.Size(169, 38);
            this.wardIdText.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ward ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Doctor Notes";
            // 
            // docNotesText
            // 
            this.docNotesText.Location = new System.Drawing.Point(12, 253);
            this.docNotesText.Margin = new System.Windows.Forms.Padding(4);
            this.docNotesText.Name = "docNotesText";
            this.docNotesText.Size = new System.Drawing.Size(615, 475);
            this.docNotesText.TabIndex = 29;
            this.docNotesText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Status";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(12, 137);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(173, 38);
            this.textStatus.TabIndex = 31;
            // 
            // RegistryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 818);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textStatus;
    }
}