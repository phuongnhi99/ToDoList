using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtEmail.Text == "" || txtPassWord.Text == "" || txtPosition.Text == "" || txtLevel.Text == "" || txtDateOfBirth.Text == "")
            {
                Response.Redirect("employeeview.aspx");
            }
            else
            {
                var md5 = new MD5CryptoServiceProvider();
            Entity.Employee employee = new Entity.Employee()
            {
                ID = txtID.Text,
                Email = txtEmail.Text,
                PassWord = EasyEncryption.MD5.ComputeMD5Hash(txtPassWord.Text),
                Name = txtName.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                PhoneNumber = txtPhoneNumber.Text,
                Position = txtPosition.Text,
                Level = txtLevel.Text
            };
            EmployeeBLL.AddEmp(employee);
            Page_Load(sender, e);
        }
            
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            abc.InnerHtml = "<tr><td> Tiger Nixon </td> <td> System Architect </td><td> Edinburgh </td><td> 61 </td><td> 2011 / 04 / 25 </td><td>$320,800 </td></tr>";
        }
    }
}