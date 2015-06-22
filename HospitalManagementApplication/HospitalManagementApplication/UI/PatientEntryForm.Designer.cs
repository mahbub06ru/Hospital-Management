namespace HospitalManagementApplication.UI
{
    partial class PatientEntryForm
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
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.patientsNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.diseaseCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(122, 81);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(137, 21);
            this.doctorComboBox.TabIndex = 9;
            // 
            // patientsNameTextBox
            // 
            this.patientsNameTextBox.Location = new System.Drawing.Point(122, 36);
            this.patientsNameTextBox.Name = "patientsNameTextBox";
            this.patientsNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.patientsNameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patients\'s Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(184, 233);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // diseaseCheckedListBox
            // 
            this.diseaseCheckedListBox.CheckOnClick = true;
            this.diseaseCheckedListBox.FormattingEnabled = true;
            this.diseaseCheckedListBox.Location = new System.Drawing.Point(122, 123);
            this.diseaseCheckedListBox.Name = "diseaseCheckedListBox";
            this.diseaseCheckedListBox.Size = new System.Drawing.Size(137, 94);
            this.diseaseCheckedListBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Disease";
            // 
            // PatientEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diseaseCheckedListBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientsNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "PatientEntryForm";
            this.Text = "Add New Patient UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.TextBox patientsNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckedListBox diseaseCheckedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}