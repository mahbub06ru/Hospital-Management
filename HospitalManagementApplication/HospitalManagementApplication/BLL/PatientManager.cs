using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementApplication.DAL;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.BLL
{
    class PatientManager
    {
        public int Save(Patient patient)
        {
            PatientGateway patientGateway=new PatientGateway();
            return patientGateway.Save(patient);
        }

        public List<Patient> GetPatientsByDoctorId(int id)
        {
            PatientGateway patientGateway=new PatientGateway();
            return patientGateway.GetPatientsByDoctorId(id);
        }

        public List<PatientDoctor> GetPatientDoctor()
        {
            PatientGateway patientGateway=new PatientGateway();
            return patientGateway.GetPatientDoctor();
        }

        public Patient GetPatientById(int patientId)
        {
            PatientGateway patientGateway=new PatientGateway();
            return patientGateway.GetPatientById(patientId);
        }

        public Doctor GetDoctorByPatientId(int patientId)
        {
            PatientGateway patientGateway=new PatientGateway();
            return patientGateway.GetDoctorByPatientId(patientId);
        }
    }
}
