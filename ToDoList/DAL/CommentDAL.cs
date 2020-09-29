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
        public void AddComment(Comment comment)
        {
            SQLHelper.DbConnection();
            string query = "insert into Comment ( IdTask, IdEmployee, Description) value (@IdTask, @IdEmployee, @Description)";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("IdTask", comment.IdTask);
            cmd.Parameters.AddWithValue("IdEmployee", comment.IdEmployee);
            cmd.Parameters.AddWithValue("Description", comment.Description);
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
            cmd.Parameters.AddWithValue("Description", comment.Description);
            cmd.Parameters.AddWithValue("ID", comment.ID);
            cmd.ExecuteNonQuery();
        }
    }
}