namespace Dental
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
            this.patientRecord1 = new Dental.PatientRecord();
            this.SuspendLayout();
            // 
            // patientRecord1
            // 
            this.patientRecord1.Location = new System.Drawing.Point(-4, 1);
            this.patientRecord1.Name = "patientRecord1";
            this.patientRecord1.Size = new System.Drawing.Size(1482, 1106);
            this.patientRecord1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 1050);
            this.Controls.Add(this.patientRecord1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental";
            this.ResumeLayout(false);

        }

        #endregion

        private PatientRecord patientRecord1;
    }
}

