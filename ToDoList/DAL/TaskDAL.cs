using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using ToDoList.Entity;

namespace ToDoList.DAL
{
    public class TaskDAL
    {
        public List<Task> GetAllTask()
        {
            List<Task> data = new List<Task>();
            string query = "SELECT * FROM TASK";
            DAL.SQLHelper.DbConnection();
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    Task ta = new Task();
                    ta.TaskId = reader.GetString(0);
                    ta.Name = reader.GetString(1);
                    data.Add(ta);
                }
                reader.NextResult();
            }
            return data;
        }

        public Task GetTask(int TaskId)
        {
            Task ta = new Task();
            DAL.SQLHelper.DbConnection();
            string sql = "SELECT * FROM TASK WHERE ID = @TaskId";
            SqlCommand cmd = new SqlCommand(sql, DAL.SQLHelper.db);
            cmd.Parameters.AddWithValue("@TaskId", TaskId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ta.TaskId = reader["ID"].ToString();
                ta.Name = reader["Name"].ToString();
            }
            return ta;
        }

        public void AddTask(Task ta)
        {
            DAL.SQLHelper.DbConnection();
            string sql = "INSERT INTO TASK (ID, Name) " +
                "VALUES (@TaskId, @Name)";
            SqlCommand cmd = new SqlCommand(sql, DAL.SQLHelper.db);
            cmd.Parameters.AddWithValue("@TaskId", ta.TaskId);
            cmd.Parameters.AddWithValue("@Name", ta.Name);
            cmd.ExecuteNonQuery();
        }

        public void EditTask(Task ta)
        {
            DAL.SQLHelper.DbConnection();
            string sql = "UPDATE TASK SET " +
                "Name = @Name" +
                "WHERE ID = @TaskId";
            SqlCommand cmd = new SqlCommand(sql, DAL.SQLHelper.db);
            cmd.Parameters.AddWithValue("@Name", ta.Name);
            cmd.Parameters.AddWithValue("@TaskId", ta.TaskId);
            cmd.ExecuteNonQuery();
        }

        public void DeleteTask(Task ta)
        {
            DAL.SQLHelper.DbConnection();
            string sql = "DELETE TASK " +
                "WHERE ID = @TaskId";
            SqlCommand cmd = new SqlCommand(sql, DAL.SQLHelper.db);
            cmd.Parameters.AddWithValue("@TaskId", ta.TaskId);
            cmd.ExecuteNonQuery();
        }
    }
}