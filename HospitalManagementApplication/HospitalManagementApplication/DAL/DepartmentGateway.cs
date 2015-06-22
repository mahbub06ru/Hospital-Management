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
    class DepartmentGateway
    {
        public bool Save(Department department)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO DepartmentTable (Name) VALUES('" + department.Name + "')";
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

        public static List<Department> GetDepartments()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DepartmentTable";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Department> departmentList = new List<Department>();
            while (sqlDataReader.Read())
            {
                Department department = new Department();
                department.Id = int.Parse(sqlDataReader["Id"].ToString());
                department.Name = sqlDataReader["Name"].ToString();
                departmentList.Add(department);
            }
            return departmentList;
        }
    }
}
