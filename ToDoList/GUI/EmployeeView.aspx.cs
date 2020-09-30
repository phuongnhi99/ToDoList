using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ToDoList.BLL;

namespace ToDoList
{
    public partial class Employee : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (Request.Form["btnView"] != null)
                {
                    string id = Request.Form["btnView"];
                    detail.Visible = true;
                    Entity.Employee employee = EmployeeBLL.GetEmployeeByID(id);
                    username_detail.Value = employee.Name;
                    email_detail.Value = employee.Email;
                    phone_number_detail.Value = employee.PhoneNumber;
                    birthday_detail.Value = String.Format("{0:yyyy-MM-dd}", employee.DateOfBirth);
                    position_detail.Value = employee.Position;
                }
                if (Request.Form["btnEdit"] != null)
                {
                    string id = Request.Form["btnEdit"];
                    form_edit.Visible = true;
                    Entity.Employee employee = EmployeeBLL.GetEmployeeByID(id);
                    ID_edit.InnerText = id;
                    username_edit.Value = employee.Name;
                    email_edit.Value = employee.Email;
                    phone_number_edit.Value = employee.PhoneNumber;
                    birthday_edit.Value = String.Format("{0:yyyy-MM-dd}", employee.DateOfBirth);
                    position_edit.Value = employee.Position;
                }
            }
            abc.InnerHtml = "";
            List<Entity.Employee> emp = EmployeeBLL.GetAll();
            foreach (Entity.Employee a in emp)
                abc.InnerHtml = abc.InnerHtml + "<tr>" +
                                "<td>" + a.ID + "</td>" +
                                "<td>" + a.Email + "</td>" +
                                "<td>" + a.Name + "</td>" +
                                "<td>" + a.PhoneNumber + "</td>" +
                                "<td>" + String.Format("{0:yyyy-MM-dd}", a.DateOfBirth) + "</td>" +
                                "<td>" + a.Position + "</td>" +
                                "<td>" +
                                "<button name='btnView' type='submit' value=" + a.ID + " class=\"btnmennu btn-cyan\"><i class=\"fa fa-eye\"></i></button>" +
                                "<button name='btnEdit' type='submit' value=" + a.ID + " class=\"btnmennu btn-light\"><i class=\"fa fa-edit\"></i></button>" +                                
                                "</td>" +
                                "</tr>";

            //if (Session["Email"] == null)
            //{
            //    Response.Redirect("login.aspx");
            //}
        }
        protected void btn_Add_New(object sender, EventArgs e)
        {
            Entity.Employee employee = new Entity.Employee();           
            if(username.Value.Equals("") || inputEmail4.Value.Equals("") || birthday.Value.Equals("")|| position.Value.Equals("") || level.Value.Equals("") || phone_number.Value.Equals(""))
            {
                form_add.Visible = true;
            }
            else
            {
                employee.Name = username.Value;
                employee.Email = inputEmail4.Value;
                employee.DateOfBirth = Convert.ToDateTime(birthday.Value);
                employee.Position = position.Value;
                employee.Level = level.Value;
                employee.PhoneNumber = phone_number.Value;
                if (!password.Value.Equals(confirm_password.Value))
                {
                    confirm_error.InnerText = "Passwords do not match !!!";
                    confirm_error.Visible = true;
                    confirm_password.Value = "";
                }
                else
                {
                    employee.PassWord = password.Value;
                    EmployeeBLL.AddEmp(employee);
                    form_add.Visible = false;
                    Page_Load(sender, e);
                }
            }
        }
        protected void btn_Change(object sender, EventArgs e)
        {
            if(username_edit.Value.Equals("")|| email_edit.Value.Equals("") || phone_number_edit.Value.Equals("") || birthday_edit.Equals("") || position_edit.Value.Equals(""))
            {
                Entity.Employee employee = new Entity.Employee();
                employee.Name = username_edit.Value;
                employee.Email = email_edit.Value;
                employee.PhoneNumber = phone_number_edit.Value;
                employee.DateOfBirth = Convert.ToDateTime(birthday_edit.Value);
                employee.Position = position_edit.Value;
                employee.ID = Convert.ToInt32(ID_edit.InnerText);
                EmployeeBLL.updateEmp(employee);
                form_edit.Visible = false;
                Page_Load(sender, e);
            }
        }

        protected void btn_close_ServerClick(object sender, EventArgs e)
        {
            if(form_add.Visible == true)
            {
                form_add.Visible = false;
            }
        }

        protected void btn_Add_ServerClick(object sender, EventArgs e)
        {
            if (form_add.Visible == false)
            {
                form_add.Visible = true;
            }
        }

        protected void close_edit_ServerClick(object sender, EventArgs e)
        {
            if (form_edit.Visible == true)
            {
                form_edit.Visible = false;
            }
        }

        protected void btn_close_detail_ServerClick(object sender, EventArgs e)
        {
            if (detail.Visible == true)
            {
                detail.Visible = false;
            }
        }
    }
}