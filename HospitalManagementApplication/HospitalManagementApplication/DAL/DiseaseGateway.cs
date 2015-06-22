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
    class DiseaseGateway
    {
        public bool Save(Disease disease)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO DiseaseTable (Name) VALUES('" + disease.Name + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (row == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Disease> GetDiseaseList()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DiseaseTable";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Disease> diseaseList = new List<Disease>();
            while (sqlDataReader.Read())
            {
                Disease disease = new Disease();
                disease.Id = int.Parse(sqlDataReader["Id"].ToString());
                disease.Name = sqlDataReader["Name"].ToString();
                diseaseList.Add(disease);
            }
            return diseaseList;
        }

        public List<Disease> GetDiseasesBypatientId(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM PatientDiseaseView WHERE Id='" + id + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Disease> diseaseList = new List<Disease>();
            while (sqlDataReader.Read())
            {
                Disease disease = new Disease();
                disease.Id = int.Parse(sqlDataReader["DiseaseId"].ToString());
                disease.Name = sqlDataReader["DiseaseName"].ToString();
                diseaseList.Add(disease);
            }
            return diseaseList;
        }
    }
}
