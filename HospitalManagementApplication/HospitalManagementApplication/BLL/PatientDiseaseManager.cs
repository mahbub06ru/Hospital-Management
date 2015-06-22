using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementApplication.DAL;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.BLL
{
    class PatientDiseaseManager
    {
        public void Save(PatientDisease patientDisease)
        {
            PatientDiseaseGateway patientDiseaseGateway=new PatientDiseaseGateway();
            patientDiseaseGateway.Save(patientDisease);
        }
    }
}
