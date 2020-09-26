using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Entity
{
    public class Task
    {
        public string TaskId { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime Deadline { get; set; }
        public string  Description { get; set; }
        public string Status { get; set; }
        public string Visibility { get; set; }
        public string Attachment { get; set; }
        public string Comment { get; set; }
        public string Partner { get; set; }
    }
}