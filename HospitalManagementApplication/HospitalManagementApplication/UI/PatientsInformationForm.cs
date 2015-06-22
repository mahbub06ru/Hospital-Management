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
    public partial class PatientsInformationForm : Form
    {
        public PatientsInformationForm()
        {
            InitializeComponent();
            GetPatientListWithDoctor();
        }

        private void GetPatientListWithDoctor()
        {
            PatientManager patientManager=new PatientManager();
            List<PatientDoctor> patientDoctorList = patientManager.GetPatientDoctor();
            foreach (var index in patientDoctorList)
            {
                ListViewItem listViewItem = new ListViewItem(index.PatientName);
                listViewItem.SubItems.Add(index.DoctorName);
                List<Disease> diseaseList = new List<Disease>();
                DiseaseManager diseaseManager = new DiseaseManager();
                diseaseList = diseaseManager.GetDiseasesBypatientId(index.Id);
                string diseaseString = "";
                foreach (var diseaseIndex in diseaseList)
                {
                    diseaseString += diseaseIndex.Name + "  ";
                }
                listViewItem.SubItems.Add(diseaseString);
                listViewItem.Tag = index.Id;
                patientsListView.Items.Add(listViewItem);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int patientId = int.Parse(patientsListView.SelectedItems[0].Tag.ToString());
            PatientEntryForm patientEntryForm=new PatientEntryForm("Update",patientId);
            patientEntryForm.Show();
        }
    }
}
