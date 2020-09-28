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
                    Task task = new Task();
                    task.ID = reader.GetString(0);
                    task.Name = reader.GetString(1);
                    task.OwnerId = reader.GetString(2);
                    task.StartDay = reader.GetDateTime(3);
                    task.Deadline = reader.GetDateTime(4);
                    task.Description = reader.GetString(5);
                    task.Status = reader.GetString(6);
                    task.Visability = reader.GetString(7);
                    //task.Attachment = reader.GetString(8);
                    //task.Comment = reader.GetString(9);
                    //task.Partner = reader.GetString(10);
                    data.Add(task);
                }
                reader.NextResult();
            }
            return data;
        }

        public Task GetTask(string ID)
        {
            Task task = new Task();
            DAL.SQLHelper.DbConnection();
            string sql = "SELECT * FROM TASK WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(sql, DAL.SQLHelper.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                task.ID = reader["ID"].ToString();
                task.Name = reader["Name"].ToString();
                task.OwnerId = reader["OwnerId"].ToString();
                task.StartDay = Convert.ToDateTime(reader["StartDay"].ToString());
                task.Deadline = Convert.ToDateTime(reader["Deadline"].ToString());
                task.Description = reader["Description"].ToString();
                task.Status = reader["Status"].ToString();
                task.Visability = reader["Visability"].ToString();
                //task.Attachment = reader["Attachment"].ToString();
                //task.Comment = reader["Comment"].ToString();
                //task.Partner = reader["Partner"].ToString();
            }
            return task;
        }

        public void AddTask(Task task)
        {
            DAL.SQLHelper.DbConnection();
            string sql = "INSERT INTO TASK (ID, Name, OwnerId, StartDay, Deadline, Description, Status, Visability, Attachment, Comment, Partner) " +
                "VALUES (@ID, @Name, @OwnerId, @StartDay, @Deadline, @Description, @Status, @Visability, @Attachment, @Comment, @Partner)";
            SqlCommand cmd = new SqlCommand(sql, SQLHelper.db);
            cmd.Parameters.AddWithValue("@ID", task.ID);
            cmd.Parameters.AddWithValue("@Name", task.Name);
            cmd.Parameters.AddWithValue("@OwnerId", task.OwnerId);
            cmd.Parameters.AddWithValue("@StartDay", task.StartDay);
            cmd.Parameters.AddWithValue("@Deadline", task.Deadline);
            cmd.Parameters.AddWithValue("@Description", task.Description);
            cmd.Parameters.AddWithValue("@Status", task.Status);
            cmd.Parameters.AddWithValue("@Visability", task.Visability);
            cmd.Parameters.AddWithValue("@Attachment", task.Attachment);
            cmd.Parameters.AddWithValue("@Comment", task.Comment);
            cmd.Parameters.AddWithValue("@Partner", task.Partner);
            cmd.ExecuteNonQuery();
        }

        public void EditTask(Task task)
        {
            DAL.SQLHelper.DbConnection();
            string sql = "UPDATE TASK SET " +
                "Name = @Name, OwnerId = @OwnerId, StartDay = @StartDay, Deadline = @Deadline, Description = @Description, Status = @Status, Visability = @Visability, Attachment = @Attachment, Comment = @Comment, Partner = @Partner " +
                " WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(sql, SQLHelper.db);
            cmd.Parameters.AddWithValue("@Name", task.Name);
            cmd.Parameters.AddWithValue("@OwnerId", task.OwnerId);
            cmd.Parameters.AddWithValue("@StartDay", task.StartDay);
            cmd.Parameters.AddWithValue("@Deadline", task.Deadline);
            cmd.Parameters.AddWithValue("@Description", task.Description);
            cmd.Parameters.AddWithValue("@Status", task.Status);
            cmd.Parameters.AddWithValue("@Visability", task.Visability);
            cmd.Parameters.AddWithValue("@Attachment", task.Attachment);
            cmd.Parameters.AddWithValue("@Comment", task.Comment);
            cmd.Parameters.AddWithValue("@Partner", task.Partner);
            cmd.Parameters.AddWithValue("@ID", task.ID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteTask(Task task)
        {
            SQLHelper.DbConnection();
            string sql = "DELETE TASK " +
                "WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(sql, SQLHelper.db);
            cmd.Parameters.AddWithValue("@ID", task.ID);
            cmd.ExecuteNonQuery();
        }
    }
}