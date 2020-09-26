using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ToDoList.DAL
{
    public class EmployeeDAL
    {

        public List<Entity.Employee> GetEmployees()
        {
            List<Entity.Employee> data = new List<Entity.Employee>();
            string query = "select * from employee";
            DAL.SQLHelper.DbConnection();
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    Entity.Employee em = new Entity.Employee();
                    em.id = reader.GetString(0);
                    em.Name = reader.GetString(1);
                    em.Email = reader.GetString(2);
                    em.PhoneNumber = reader.GetString(3);
                    data.Add(em);
                }
                reader.NextResult();

            }
            return data;
        }

        public void create_employee()
        {

        }
        public int checklogin(string Email,string Password)
        {
            string query = "select * from employee where Email=@Email and Password=@Password";
            DAL.SQLHelper.DbConnection();
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 100));
            cmd.Parameters["@Email"].Value = Email;
            cmd.Parameters["@Password"].Value = Password;
            if (cmd.ExecuteReader().HasRows)
                return 1;
            else
                return 0;
        }
    }
}