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
            // String connectString = ConfigurationManager.ConnectionStrings["server=.; database=ToDoList; integrated security = true;"].ConnectionString;
            // db = new SqlConnection(connectString);
            // db = new SqlConnection("server=.; database=ToDoList; integrated security = true;");
            // db.Open();

            //DESKTOP-NIVOU6F\SQLEXPRESS

            //DESKTOP-R826P0H\MSSQLSERVER1
              db = new SqlConnection(@"server=DESKTOP-R826P0H\MSSQLSERVER1; database=ToDoList; integrated security = true;");
            db.Open();
        }
    }
}