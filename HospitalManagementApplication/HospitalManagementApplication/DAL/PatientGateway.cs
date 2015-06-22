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
    class PatientGateway
    {
        public int Save(Patient patient)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO PatientTable (Name,DoctorId) OUTPUT INSERTED.ID VALUES('" + patient.Name + "','" + patient.DoctorId + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row =  (int) sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (row > 0)
            {
                return row;
            }
            else
            {
                return 0;
            }
        }

        public List<Patient> GetPatientsByDoctorId(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DoctorPatientView WHERE Id='"+id+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Patient> patientList = new List<Patient>();
            while (sqlDataReader.Read())
            {
                Patient patient = new Patient();
                patient.Id = int.Parse(sqlDataReader["Id"].ToString());
                patient.Name = sqlDataReader["PatientName"].ToString();
                patientList.Add(patient);
            }
            return patientList;
        }

        public List<PatientDoctor> GetPatientDoctor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM PatientDoctorView";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<PatientDoctor> patientDoctorList = new List<PatientDoctor>();
            while (sqlDataReader.Read())
            {
                PatientDoctor patientDoctor = new PatientDoctor();
                patientDoctor.Id = int.Parse(sqlDataReader["Id"].ToString());
                patientDoctor.PatientName = sqlDataReader["PatientName"].ToString();
                patientDoctor.DoctorName = sqlDataReader["DoctorName"].ToString();
                patientDoctorList.Add(patientDoctor);
            }
            return patientDoctorList;
        }

        public Patient GetPatientById(int patientId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM PatientTable WHERE Id='" + patientId + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Patient patient = new Patient();
            while (sqlDataReader.Read())
            {
                
                patient.Id = int.Parse(sqlDataReader["Id"].ToString());
                patient.Name = sqlDataReader["PatientName"].ToString();
            }
            return patient;
        }

        public Doctor GetDoctorByPatientId(int patientId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM PatientDoctorView WHERE Id='" + patientId + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Doctor doctor=new Doctor();
            while (sqlDataReader.Read())
            {
                doctor.Id = int.Parse(sqlDataReader["DoctorId"].ToString());
                doctor.Name = sqlDataReader["DoctorName"].ToString();
            }
            return doctor;
        }
    }
}
