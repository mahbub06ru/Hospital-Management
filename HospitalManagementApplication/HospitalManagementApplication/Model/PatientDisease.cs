using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementApplication.Model
{
    class PatientDisease
    {
        public int Id { set; get; }
        public int PatientId { set; get; }
        public int DiseaseId { set; get; }
    }
}
