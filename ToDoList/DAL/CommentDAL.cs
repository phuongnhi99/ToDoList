using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ToDoList.Entity;

namespace ToDoList.DAL
{
    public class CommentDAL
    {
        public List<Entity.Comment> GetAll()
        {
            List<Entity.Comment> data = new List<Entity.Comment>();
            string query = "select * from comment inner join employee on comment.IdEmployee = employee.ID";
            SQLHelper.DbConnection();
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    Entity.Comment cmt = new Entity.Comment();
                    Entity.Employee emp = new Entity.Employee();
                    cmt.ID = Convert.ToInt32(reader["ID"].ToString());
                    cmt.IdTask = Convert.ToInt32(reader["IdTask"].ToString());
                    cmt.IdEmployee = Convert.ToInt32(reader["IdEmployee"].ToString());
                    cmt.Description = reader["Description"].ToString();
                    cmt.Name = reader["Name"].ToString();
                    data.Add(cmt);
                }
                reader.NextResult();
            }
            return data;
        }
        public void AddComment(Comment comment)
        {
            SQLHelper.DbConnection();
            string query = "insert into Comment ( IdTask, IdEmployee, Description) values (@IdTask, @IdEmployee, @Description)";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@IdTask", comment.IdTask);
            cmd.Parameters.AddWithValue("@IdEmployee", comment.IdEmployee);
            cmd.Parameters.AddWithValue("@Description", comment.Description);
            cmd.ExecuteNonQuery();
        }
        public void Delete(Comment comment)
        {
            SQLHelper.DbConnection();
            string query = "delete from Comment where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@ID", comment.ID);
            cmd.ExecuteNonQuery();
        }
        public void updateComment(Comment comment)
        {
            SQLHelper.DbConnection();
            string query = "update Comment set Description =@Description  where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@Description", comment.Description);
            cmd.Parameters.AddWithValue("@ID", comment.ID);
            cmd.ExecuteNonQuery();
        }
    }
}