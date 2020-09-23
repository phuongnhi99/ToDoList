using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.DAL;

namespace ToDoList.BLL
{
    public static class EmployeeBLL
    {
        private static EmployeeDAL obj = new EmployeeDAL();
        public static int checklogin(string email,string pass)
        {
            return obj.checklogin(email, pass);
        }
    }
}