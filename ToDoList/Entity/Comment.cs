using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Entity
{
    public class Comment
    {
        public int ID { get; set; }
        public int IdTask { get; set; }
        public int IdEmployee { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}