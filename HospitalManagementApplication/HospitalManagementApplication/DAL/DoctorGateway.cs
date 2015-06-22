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
    class DoctorGateway
    {
        public bool Save(Doctor doctor)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO DoctorTable (Name,DepartmentId) VALUES('" + doctor.Name + "','"+doctor.DepartmentId+"')";
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

        public List<Doctor> GetDoctorList()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DoctorTable";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Doctor> doctorList = new List<Doctor>();
            while (sqlDataReader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.Id = int.Parse(sqlDataReader["Id"].ToString());
                doctor.Name = sqlDataReader["Name"].ToString();
                doctorList.Add(doctor);
            }
            return doctorList;
        }

        public List<DoctorDepartment> GetDoctorListWithDepartments()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DoctorDepartmentView";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<DoctorDepartment> doctorDepartmentList = new List<DoctorDepartment>();
            while (sqlDataReader.Read())
            {
                DoctorDepartment doctorDepartment = new DoctorDepartment();
                doctorDepartment.Id = int.Parse(sqlDataReader["Id"].ToString());
                doctorDepartment.DoctorName = sqlDataReader["DoctorName"].ToString();
                doctorDepartment.DepartmentName = sqlDataReader["DepartmentName"].ToString();
                doctorDepartmentList.Add(doctorDepartment);
            }
            return doctorDepartmentList;
        }

        public Doctor GetDoctorById(int doctorId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DoctorTable WHERE Id='"+doctorId+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Model.Doctor aDoctor = new Doctor();
            
            while (sqlDataReader.Read())
            {
                aDoctor.Id = int.Parse(sqlDataReader["Id"].ToString());
                aDoctor.Name = sqlDataReader["Name"].ToString();
                aDoctor.DepartmentId = int.Parse(sqlDataReader["DepartmentId"].ToString());
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            return aDoctor;
        }

        public bool Update(Doctor doctor)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "UPDATE DoctorTable SET Name='" + doctor.Name + "',DepartmentId='" + doctor.DepartmentId + "' WHERE Id='"+doctor.Id+"' ";
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

        public bool DeleteDoctorById(int doctorId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "DELETE FROM DoctorTable Where Id='" + doctorId + "'";
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

        public List<DoctorDepartment> SearchDoctorByNameWithDepartment(string search)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DoctorDepartmentView WHERE DoctorName LIKE '%" + search +"%'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<DoctorDepartment> doctorDepartmentList = new List<DoctorDepartment>();
            while (sqlDataReader.Read())
            {
                DoctorDepartment doctorDepartment = new DoctorDepartment();
                doctorDepartment.Id = int.Parse(sqlDataReader["Id"].ToString());
                doctorDepartment.DoctorName = sqlDataReader["DoctorName"].ToString();
                doctorDepartment.DepartmentName = sqlDataReader["DepartmentName"].ToString();
                doctorDepartmentList.Add(doctorDepartment);
            }
            return doctorDepartmentList;
        }
    }
}
