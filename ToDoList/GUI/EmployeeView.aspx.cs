using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoList.BLL;

namespace ToDoList
{
    public partial class Employee : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            List<Entity.Employee> emp = EmployeeBLL.GetAll();
            tblEmployee.DataSource = emp.ToList();
            tblEmployee.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Entity.Employee employee = new Entity.Employee()
            {
                ID = txtID.Text,
                Email = txtEmail.Text,
                PassWord = txtPassWord.Text,
                Name = txtName.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                PhoneNumber = txtPhoneNumber.Text,
                Position = txtPosition.Text,
                Level = txtLevel.Text
            };
            EmployeeBLL.AddEmp(employee);
            Page_Load(sender, e);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Entity.Employee employee = new Entity.Employee()
            {
                ID = txtID.Text,
                Email = txtEmail.Text,
                PassWord = txtPassWord.Text,
                Name = txtName.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                PhoneNumber = txtPhoneNumber.Text,
                Position = txtPosition.Text,
                Level = txtLevel.Text
            };
            EmployeeBLL.updateEmp(employee);
            Page_Load(sender, e);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Entity.Employee employee = new Entity.Employee()
            {
                ID = txtID.Text,               
            };
            EmployeeBLL.delete(employee);
            Page_Load(sender, e);
        }
    }
}