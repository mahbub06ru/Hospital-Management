using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementApplication.DAL;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.BLL
{
    class DepartmentManager
    {
        public bool Save(Department department)
        {
            DepartmentGateway departmentGateway=new DepartmentGateway();
            return departmentGateway.Save(department);
        }

        public List<Department> GetDepartments()
        {
            return DepartmentGateway.GetDepartments();
        }
    }
}
