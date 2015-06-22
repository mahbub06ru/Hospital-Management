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
    public partial class DoctorEntryForm : Form
    {
        private int idforSearch = 0;
        public DoctorEntryForm(string mode,int doctorId)
        {
            InitializeComponent();
            if (mode == "Update")
            {
                //MessageBox.Show(doctorId.ToString());
                Doctor aDoctor=new Doctor();
                BLL.DoctorManager manager=new DoctorManager();
                aDoctor = manager.GetDoctorById(doctorId);

                idforSearch = aDoctor.Id;

                nameTextBox.Text = aDoctor.Name;
                GetDepartmentsInComboBox();
                departmentComboBox.SelectedValue=aDoctor.DepartmentId;
                saveButton.Text = "Update";

            }
            else
            {
                GetDepartmentsInComboBox();
            }
        }

        private void GetDepartmentsInComboBox()
        {
            List<Department> departmentList=new List<Department>();
            DepartmentManager departmentManager = new DepartmentManager();
            departmentList = departmentManager.GetDepartments();
            departmentComboBox.ValueMember = "Id";
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.DataSource = null;
            departmentComboBox.DataSource = departmentList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewDepartmentButton_Click(object sender, EventArgs e)
        {
            Close();
            DepartmentEntryForm departmentEntryForm=new DepartmentEntryForm();
            departmentEntryForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Doctor doctor=new Doctor();
            doctor.Name = nameTextBox.Text;
            doctor.DepartmentId = int.Parse(departmentComboBox.SelectedValue.ToString());
            doctor.Id = idforSearch;
            DoctorManager doctorManager=new DoctorManager();
            if (saveButton.Text == "Update")
            {
                bool status = doctorManager.Update(doctor);
                if (status)
                {
                    Close();
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Not updated");
                }
            }
            else if (doctorManager.Save(doctor))
            {
                Close();
                MessageBox.Show("Doctor Successfully Added");
            }
            else
            {
                Close();
                MessageBox.Show("An error occured");
            }
        }
    }
}
