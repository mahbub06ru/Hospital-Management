using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementApplication.DAL;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.BLL
{
    class DoctorManager
    {
        public bool Save(Doctor doctor)
        {
            DoctorGateway doctorGateway=new DoctorGateway();
            return doctorGateway.Save(doctor);
        }

        public List<Doctor> GetDoctorList()
        {
           DoctorGateway doctorGateway=new DoctorGateway();
            return doctorGateway.GetDoctorList();
        }

        public List<DoctorDepartment> GetDoctorListWithDepartments()
        {
            DoctorGateway doctorGateway=new DoctorGateway();
            return doctorGateway.GetDoctorListWithDepartments();
        }

        public Doctor GetDoctorById(int doctorId)
        {
            DAL.DoctorGateway gateway=new DoctorGateway();
            return gateway.GetDoctorById(doctorId);
        }

        public bool Update(Doctor doctor)
        {
            DAL.DoctorGateway gateway = new DoctorGateway();
            return gateway.Update(doctor);
        }

        public bool DeleteDoctorById(int doctorId)
        {
            DoctorGateway doctorGateway=new DoctorGateway();
            return doctorGateway.DeleteDoctorById(doctorId);
        }

        public List<DoctorDepartment> SearchDoctorByNameWithDepartment(string search)
        {
            DoctorGateway doctorGateway = new DoctorGateway();
            return doctorGateway.SearchDoctorByNameWithDepartment(search);
        }
    }
}
