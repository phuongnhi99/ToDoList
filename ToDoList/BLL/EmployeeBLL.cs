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
        public static List<Entity.Employee> GetEmployees()
        {
            return obj.GetEmployees();
        }

        public static int checklogin(string email,string pass)
        {
            return obj.checklogin(email, pass);
        }
        public static List<Entity.Employee> GetAll()
        {
            return obj.GetAll();
        }
        public static Entity.Employee GetEmployeeByID(string ID)
        {
            return obj.GetEmployeeByID(ID);
        }

        public static void AddEmp(Entity.Employee employee)
        {
            obj.AddEmp(employee);
        }

        public static void updateEmp(Entity.Employee employee)
        {
            obj.updateEmp(employee);
        }
        public static void delete(Entity.Employee employee)
        {
            obj.Delete(employee);
        }
    }
}