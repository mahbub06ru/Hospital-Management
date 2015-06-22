
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementApplication.DAL;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.BLL
{
    class DiseaseManager
    {
        public bool Save(Disease disease)
        {
            DiseaseGateway diseaseGateway=new DiseaseGateway();
            return diseaseGateway.Save(disease);
        }

        public List<Disease> GetDiseaseList()
        {
            DiseaseGateway diseaseGateway=new DiseaseGateway();
            return diseaseGateway.GetDiseaseList();
        }

        public List<Disease> GetDiseasesBypatientId(int id)
        {
            DiseaseGateway diseaseGateway=new DiseaseGateway();
            return diseaseGateway.GetDiseasesBypatientId(id);
        }
    }
}
