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

        public static List<Task> GetTaskProgress()
        {
            return obj.GetTaskProgress();
        }

        public static List<Task> GetTaskDone()
        {
            return obj.GetTaskDone();
        }

        public static List<Task> GetTaskLate()
        {
            return obj.GetTaskLate();
        }

        //public static Task GetTask(string ID)
        //{
        //    return obj.GetTask();
        //}


        public static void AddTask(Task task)
        {
            obj.AddTask(task);
        }

        public static void EditTask(Task task)
        {
            obj.EditTask(task);
        }

        public static void DeleteTask(Task task)
        {
            obj.DeleteTask(task);
        }
    }
}