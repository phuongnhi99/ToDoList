﻿using System;
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
            SQLHelper.DbConnection();
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    Entity.Employee em = new Entity.Employee();
                    em.ID = Convert.ToInt32(reader["ID"].ToString());
                    em.Email = reader["Email"].ToString();
                    em.PassWord = reader["PassWord"].ToString();
                    em.Name = reader["Name"].ToString();
                    em.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"].ToString());
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
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Entity.Employee()
                        {
                            ID = Convert.ToInt32(dr["ID"].ToString()),
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

        public Entity.Employee GetEmployeeByEmail(string Email)
        {
            SQLHelper.DbConnection();
            string query = "Select * from EMPLOYEE where Email=@Email";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@Email", Email);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Entity.Employee()
                        {
                            Email = dr["Email"].ToString(),
                            ID = Convert.ToInt32(dr["ID"].ToString()),
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
        public Entity.Employee GetIDbyEmail(string Email)
        {
            SQLHelper.DbConnection();
            string query = "Select ID from EMPLOYEE where Email=@Email";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@Email", Email);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Entity.Employee()
                        {
                            ID = Convert.ToInt32(dr["ID"].ToString()),                         
                        };
                    }
                }
                return null;
            }
        }
        public void AddEmp(Entity.Employee employee)
        {
            
                SQLHelper.DbConnection();
                string query = "insert into EMPLOYEE (Email, Password, Name, DateOfBirth, PhoneNumber, Position,  Level) values ( @Email, @Password, @Name, @DateOfBirth, @PhoneNumber, @Position, @Level)";
                SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
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
            string query = "update EMPLOYEE set Email =@Email, Name =@Name, DateOfBirth = @DateOfBirth, PhoneNumber =@PhoneNumber, Position =@Position where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("Email", employee.Email);
            cmd.Parameters.AddWithValue("Name", employee.Name);
            cmd.Parameters.AddWithValue("DateOfBirth", employee.DateOfBirth);
            cmd.Parameters.AddWithValue("PhoneNumber", employee.PhoneNumber);
            cmd.Parameters.AddWithValue("Position", employee.Position);
            cmd.Parameters.AddWithValue("ID", employee.ID);
            cmd.ExecuteNonQuery();
        }
        public void updatePass(Entity.Employee employee)
        {
            SQLHelper.DbConnection();
            string query = "update EMPLOYEE set Password =@Password where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("Password", employee.PassWord);
            cmd.ExecuteNonQuery();
        }
        public void Delete(string ID)
        {
            SQLHelper.DbConnection();
            string query = "delete from EMPLOYEE where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@ID",ID);
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
        public int checkduplicate(string Email)

        {
            string query = "Select Count(*) from employee where Email=@Email  ";
            SQLHelper.DbConnection();
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100));
            cmd.Parameters["@Email"].Value = Email;
            int dem = (int)cmd.ExecuteScalar();
            if (dem > 0)
            {
                return 1;
            }
            return 0;
        }
        public int checkduplicatephone(string PhoneNumber)

        {
            string query = "Select Count(*) from employee where PhoneNumber=@PhoneNumber  ";
            SQLHelper.DbConnection();
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 100));
            cmd.Parameters["@PhoneNumber"].Value = PhoneNumber;
            int dem = (int)cmd.ExecuteScalar();
            if (dem > 0)
            {
                return 1;
            }
            return 0;
        }
       
    }
}