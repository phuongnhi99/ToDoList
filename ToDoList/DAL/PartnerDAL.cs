using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ToDoList.Entity;

namespace ToDoList.DAL
{
    public class PartnerDAL
    {
        public void AddPartner(Partner partner)
        {
            SQLHelper.DbConnection();
            string query = "insert into Partner ( IdTask, IdEmployee) value (@IdTask, @IdEmployee)";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("IdTask", partner.IdTask);
            cmd.Parameters.AddWithValue("IdEmployee", partner.IdEmployee);
            cmd.ExecuteNonQuery();
        }
        public void Delete(Partner partner)
        {
            SQLHelper.DbConnection();
            string query = "delete from Partner where IdTask = @IdTask and IdEmployee=@IdEmployee";
            SqlCommand cmd = new SqlCommand(query, SQLHelper.db);
            cmd.Parameters.AddWithValue("@IdTask", partner.IdTask);
            cmd.Parameters.AddWithValue("@IdEmployee", partner.IdEmployee);
            cmd.ExecuteNonQuery();
        }
        
    }
}