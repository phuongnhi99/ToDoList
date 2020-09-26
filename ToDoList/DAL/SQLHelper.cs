using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ToDoList.DAL
{
    public class SQLHelper
    {
        public static SqlConnection db;
        public static void DbConnection()
        {
            db = new SqlConnection(@"server=.; database=ToDoList; integrated security = true;");
            db.Open();
        }
    }
}