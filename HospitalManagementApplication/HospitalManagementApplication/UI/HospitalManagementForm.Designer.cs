namespace HospitalManagementApplication
{
    partial class HospitalManagementForm
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
            this.addNewDoctorButton = new System.Windows.Forms.Button();
            this.addNewPatientButton = new System.Windows.Forms.Button();
            this.addNewDiseaseButton = new System.Windows.Forms.Button();
            this.showAllDoctorsButton = new System.Windows.Forms.Button();
            this.showAllPatientsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewDoctorButton
            // 
            this.addNewDoctorButton.Location = new System.Drawing.Point(57, 59);
            this.addNewDoctorButton.Name = "addNewDoctorButton";
            this.addNewDoctorButton.Size = new System.Drawing.Size(122, 92);
            this.addNewDoctorButton.TabIndex = 0;
            this.addNewDoctorButton.Text = "Add New Doctor";
            this.addNewDoctorButton.UseVisualStyleBackColor = true;
            this.addNewDoctorButton.Click += new System.EventHandler(this.addNewDoctorButton_Click);
            // 
            // addNewPatientButton
            // 
            this.addNewPatientButton.Location = new System.Drawing.Point(234, 59);
            this.addNewPatientButton.Name = "addNewPatientButton";
            this.addNewPatientButton.Size = new System.Drawing.Size(122, 92);
            this.addNewPatientButton.TabIndex = 1;
            this.addNewPatientButton.Text = "Add New Patient";
            this.addNewPatientButton.UseVisualStyleBackColor = true;
            this.addNewPatientButton.Click += new System.EventHandler(this.addNewPatientButton_Click);
            // 
            // addNewDiseaseButton
            // 
            this.addNewDiseaseButton.Location = new System.Drawing.Point(405, 59);
            this.addNewDiseaseButton.Name = "addNewDiseaseButton";
            this.addNewDiseaseButton.Size = new System.Drawing.Size(122, 92);
            this.addNewDiseaseButton.TabIndex = 2;
            this.addNewDiseaseButton.Text = "Add New Disease";
            this.addNewDiseaseButton.UseVisualStyleBackColor = true;
            this.addNewDiseaseButton.Click += new System.EventHandler(this.addNewDiseaseButton_Click);
            // 
            // showAllDoctorsButton
            // 
            this.showAllDoctorsButton.Location = new System.Drawing.Point(145, 191);
            this.showAllDoctorsButton.Name = "showAllDoctorsButton";
            this.showAllDoctorsButton.Size = new System.Drawing.Size(122, 92);
            this.showAllDoctorsButton.TabIndex = 3;
            this.showAllDoctorsButton.Text = "Show All Doctors";
            this.showAllDoctorsButton.UseVisualStyleBackColor = true;
            this.showAllDoctorsButton.Click += new System.EventHandler(this.showAllDoctorsButton_Click);
            // 
            // showAllPatientsButton
            // 
            this.showAllPatientsButton.Location = new System.Drawing.Point(342, 191);
            this.showAllPatientsButton.Name = "showAllPatientsButton";
            this.showAllPatientsButton.Size = new System.Drawing.Size(122, 92);
            this.showAllPatientsButton.TabIndex = 4;
            this.showAllPatientsButton.Text = "Show All Patients";
            this.showAllPatientsButton.UseVisualStyleBackColor = true;
            this.showAllPatientsButton.Click += new System.EventHandler(this.showAllPatientsButton_Click);
            // 
            // HospitalManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 329);
            this.Controls.Add(this.showAllPatientsButton);
            this.Controls.Add(this.showAllDoctorsButton);
            this.Controls.Add(this.addNewDiseaseButton);
            this.Controls.Add(this.addNewPatientButton);
            this.Controls.Add(this.addNewDoctorButton);
            this.Name = "HospitalManagementForm";
            this.Text = "Hospital Management UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewDoctorButton;
        private System.Windows.Forms.Button addNewPatientButton;
        private System.Windows.Forms.Button addNewDiseaseButton;
        private System.Windows.Forms.Button showAllDoctorsButton;
        private System.Windows.Forms.Button showAllPatientsButton;
    }
}

