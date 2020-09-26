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

        public List<Entity.Employee> GetAll()
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
                    em.ID = reader["ID"].ToString();
                    em.Email = reader["Email"].ToString();
                    em.PassWord = reader["PassWord"].ToString();
                    em.Name = reader["Name"].ToString();
                    em.DateOfBirth = Convert.ToDateTime( reader["DateOfBirth"].ToString());
                    em.PhoneNumber = reader["PhoneNumber"].ToString();
                    em.Position = reader["Position"].ToString();
                    em.Level = reader["Level"].ToString();
                    data.Add(em);
                }
                reader.NextResult();
            }
            return data;
        }

        public Entity.Employee GetEmployeeByID(string ID)
        {
            SQLHelper.DbConnection();
            string query = "Select * from EMPLOYEE where ID=@ID";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Entity.Employee()
                        {
                            ID = dr["ID"].ToString(),
                            Email = dr["Email"].ToString(),
                            PassWord = dr["Password"].ToString(),
                            Name = dr["Name"].ToString(),
                            DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"].ToString()),
                            PhoneNumber = dr["PhoneNumber"].ToString(),
                            Position = dr["Position"].ToString(),
                            Level = dr["Level"].ToString()
                        };
                    }
                }
                return null;
            }
        }
        public void AddEmp(Entity.Employee employee)
        {
            SQLHelper.DbConnection();
            string query = "insert into EMPLOYEE (ID, Email, Password, Name, DateOfBirth, PhoneNumber, Position,  Level) values (@ID, @Email, @Password, @Name, @DateOfBirth, @PhoneNumber, @Position, @Level)";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("ID", employee.ID);
            cmd.Parameters.AddWithValue("Email", employee.Email);
            cmd.Parameters.AddWithValue("Password", employee.PassWord);
            cmd.Parameters.AddWithValue("Name", employee.Name);
            cmd.Parameters.AddWithValue("DateOfBirth", employee.DateOfBirth);
            cmd.Parameters.AddWithValue("PhoneNumber", employee.PhoneNumber);
            cmd.Parameters.AddWithValue("Position", employee.Position);
            cmd.Parameters.AddWithValue("Level", employee.Level);
            cmd.ExecuteNonQuery();
        }
        public void updateEmp(Entity.Employee employee)
        {
            SQLHelper.DbConnection();
            string query = "update EMPLOYEE set Email =@Email, Password= @Password, Name =@Name, DateOfBirth = @DateOfBirth, PhoneNumber =@PhoneNumber, Position =@Position, Level= @Level where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("Email", employee.Email);
            cmd.Parameters.AddWithValue("Password", employee.PassWord);
            cmd.Parameters.AddWithValue("Name", employee.Name);
            cmd.Parameters.AddWithValue("DateOfBirth", employee.DateOfBirth);
            cmd.Parameters.AddWithValue("PhoneNumber", employee.PhoneNumber);
            cmd.Parameters.AddWithValue("Position", employee.Position);
            cmd.Parameters.AddWithValue("Level", employee.Level);
            cmd.Parameters.AddWithValue("ID", employee.ID);
            cmd.ExecuteNonQuery();
        }
        public void Delete(Entity.Employee employee)
        {
            SQLHelper.DbConnection();
            string query = "delete from EMPLOYEE where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@ID",employee.ID);
            cmd.ExecuteNonQuery();
        }
        public int checklogin(string Email, string Password)

        {
            string query = "select * from employee where Email=@Email and Password=@Password";
            SQLHelper.DbConnection();
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