using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementApplication.BLL;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.UI
{
    public partial class PatientEntryForm : Form
    {
        public PatientEntryForm(string mode,int patientId)
        {
            InitializeComponent();
            if (mode == "Update")
            {
                PatientManager patientManager = new PatientManager();
                Doctor doctor=patientManager.GetDoctorByPatientId(patientId);
                GetDoctorsListInComboBox();
                doctorComboBox.Text = doctor.Name;           
                List<Disease> diseaseList=new List<Disease>();
                DiseaseManager diseaseManager=new DiseaseManager();
                diseaseList=diseaseManager.GetDiseasesBypatientId(patientId);
                foreach (var index in diseaseList)
                {
                    diseaseCheckedListBox.SetItemChecked(1,true);
                    diseaseCheckedListBox.DataSource = null;
                    diseaseCheckedListBox.DataSource = diseaseList;
                    diseaseCheckedListBox.ValueMember = "Id";
                    diseaseCheckedListBox.DisplayMember = "Name";
                }
            }
            else
            {
                GetDoctorsListInComboBox();
                GetDiseaseListInDiseaseCheckedListBox();
            }
        }

        private void GetDiseaseListInDiseaseCheckedListBox()
        {
            DiseaseManager diseaseManager=new DiseaseManager();
            List<Disease> diseaseList=new List<Disease>();
            diseaseList = diseaseManager.GetDiseaseList();
            //foreach (var index in diseaseList)
            //{
            //    diseaseCheckedListBox.Items.Add(index.Name);
            //    diseaseCheckedListBox.Tag = index.Id;
            //}
            diseaseCheckedListBox.DataSource = null;
            diseaseCheckedListBox.DataSource = diseaseList;
            diseaseCheckedListBox.ValueMember = "Id";
            diseaseCheckedListBox.DisplayMember = "Name";
        }

        private void GetDoctorsListInComboBox()
        {
            DoctorManager doctorManager=new DoctorManager();
            List<Doctor> doctorList=new List<Doctor>();
            doctorList=doctorManager.GetDoctorList();
            doctorComboBox.DataSource = null;
            doctorComboBox.DataSource = doctorList;
            doctorComboBox.ValueMember = "Id";
            doctorComboBox.DisplayMember = "Name";            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PatientManager patientManager=new PatientManager();
            PatientDiseaseManager patientDiseaseManager=new PatientDiseaseManager();
            Patient patient=new Patient();
            patient.Name = patientsNameTextBox.Text;
            patient.DoctorId = int.Parse(doctorComboBox.SelectedValue.ToString());
            int patientId = patientManager.Save(patient);
            if (patientId > 0)
            {
                foreach (var index in diseaseCheckedListBox.CheckedItems)
                {
                    Disease disease = (Disease)index;
                    PatientDisease patientDisease = new PatientDisease();
                    patientDisease.PatientId = patientId;
                    patientDisease.DiseaseId = disease.Id;
                    patientDiseaseManager.Save(patientDisease);
                }
                MessageBox.Show("Patient Successfully Added");
            }
            else
            {
                MessageBox.Show("An Error Occured");
            }
        }
    }
}
