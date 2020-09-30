using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.DAL;
using ToDoList.Entity;

namespace ToDoList.BLL
{
    public static class CommentBLL
    {
        private static CommentDAL obj = new CommentDAL();

        public static List<Entity.Comment> GetAll()
        {
            return obj.GetAll();
        }

        public static void AddComment(Comment comment)
        {
            obj.AddComment(comment);
        }

        public static void updateComment(Comment comment)
        {
            obj.updateComment(comment);
        }
        public static void delete(Comment comment)
        {
            obj.Delete(comment);
        }
    }
}