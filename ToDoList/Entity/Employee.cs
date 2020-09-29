using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Entity
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public string Level { get; set; }


    }
}