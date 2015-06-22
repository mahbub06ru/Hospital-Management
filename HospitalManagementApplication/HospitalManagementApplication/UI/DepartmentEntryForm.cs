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
using HospitalManagementApplication.DAL;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.UI
{
    public partial class DepartmentEntryForm : Form
    {
        public DepartmentEntryForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Department department=new Department();
            department.Name = departmentsNameTextBox.Text;
            DepartmentManager departmentManager=new DepartmentManager();
            if (departmentManager.Save(department))
            {
                Close();
                MessageBox.Show("Department Successfully Added");
            }
            else
            {
                Close();
                MessageBox.Show("An error occured");
            }
        }

        private void departmentsNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
