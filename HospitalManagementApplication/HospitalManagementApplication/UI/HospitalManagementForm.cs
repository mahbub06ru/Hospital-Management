using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementApplication.UI;

namespace HospitalManagementApplication
{
    public partial class HospitalManagementForm : Form
    {
        public HospitalManagementForm()
        {
            InitializeComponent();
        }

        private void addNewDoctorButton_Click(object sender, EventArgs e)
        {
            DoctorEntryForm doctorEntryForm=new DoctorEntryForm(null,0);
            doctorEntryForm.Show();
        }

        private void addNewPatientButton_Click(object sender, EventArgs e)
        {
            PatientEntryForm patientEntryForm=new PatientEntryForm(null,0);
            patientEntryForm.Show();
        }

        private void addNewDiseaseButton_Click(object sender, EventArgs e)
        {
            DiseaseEntryForm diseaseEntryForm=new DiseaseEntryForm();
            diseaseEntryForm.Show();
        }

        private void showAllDoctorsButton_Click(object sender, EventArgs e)
        {
            DoctorInformationForm doctorInformationForm=new DoctorInformationForm();
            doctorInformationForm.Show();
        }

        private void showAllPatientsButton_Click(object sender, EventArgs e)
        {
            PatientsInformationForm patientsInformationForm=new PatientsInformationForm();
            patientsInformationForm.Show();
        }
    }
}
