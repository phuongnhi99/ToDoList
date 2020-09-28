using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using ToDoList.DAL;
using ToDoList.Entity;

namespace ToDoList.BLL
{
    public static class TaskBLL
    {
        private static TaskDAL obj = new TaskDAL();
        public static List<Task> GetAllTask()
        {
            return obj.GetAllTask();
        }

        public static Task GetTask(string TaskId)
        {
            return obj.GetTask(TaskId);
        }

        public static void AddTask(Task ta)
        {
            obj.AddTask(ta);
        }

        public static void EditTask(Task ta)
        {
            obj.EditTask(ta);
        }

        public static void DeleteTask(Task ta)
        {
            obj.DeleteTask(ta);
        }
    }
}