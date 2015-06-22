using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementApplication.Model;

namespace HospitalManagementApplication.DAL
{
    class PatientDiseaseGateway
    {
        public void Save(PatientDisease patientDisease)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO PatientDiseaseTable (PatientId,DiseaseId) VALUES('" + patientDisease.PatientId + "','"+patientDisease.DiseaseId+"')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
