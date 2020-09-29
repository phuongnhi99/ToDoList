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
            abc.InnerHtml = "";
            List<Entity.Employee> emp = EmployeeBLL.GetAll();
            tblEmployee.DataSource = emp.ToList();
            tblEmployee.DataBind();
            foreach (Entity.Employee a in emp)
                abc.InnerHtml = abc.InnerHtml + "<tr>" +
                                "<td>" + a.ID + "</td>" +
                                "<td>" + a.Email + "</td>" +
                                "<td>" + a.Name + "</td>" +
                                "<td>" + a.PhoneNumber + "</td>" +
                                "<td>" + a.DateOfBirth.ToString("dd/MM/yyyy") + "</td>" +
                                "<td>" + a.Position + "</td>" +
                                "<td><button id="+a.ID+" onserverclick=\"btnAdd_Click1\"><i class=\"fas fa-eye\"></i></button>" +
                                "</tr>";
            //if (Session["Email"] == null)
            //{
            //    Response.Redirect("login.aspx");
            //}
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var md5 = new MD5CryptoServiceProvider();
            Entity.Employee employee = new Entity.Employee()
            {
                ID = txtID.Text,
                Email = txtEmail.Text,
                PassWord = EasyEncryption.MD5.ComputeMD5Hash(txtPassWord.Text),
                Name = txtName.Text,
                DateOfBirth = (Convert.ToDateTime(txtDateOfBirth.Text)).Date,
                PhoneNumber = txtPhoneNumber.Text,
                Position = txtPosition.Text,
                Level = txtLevel.Text
            };
            EmployeeBLL.GetEmployeeByID(btnAdd.AccessKey);
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
                DateOfBirth = (Convert.ToDateTime(txtDateOfBirth.Text)).Date,
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