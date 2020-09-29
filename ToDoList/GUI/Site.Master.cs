using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoList.BLL;

namespace ToDoList.GUI
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {   Entity.Employee employee = EmployeeBLL.GetEmployeeByEmail(Session["Email"].ToString());
                username.Value = username_edit.Value = employee.Name;
                email.Value = email_edit.Value = employee.Email;
                dayofbirth.Value = employee.DateOfBirth.ToString("dd/MM/yyyy");
                phonenumber.Value = phonenumber_edit.Value = employee.PhoneNumber;
                position.Value = employee.Position;
                username_edit.Value = employee.DateOfBirth.ToString("dd/MM/yyyy");
            }
        }

        protected void btn_task_Click(object sender, EventArgs e)
        {

        }

        protected void btn_employee_Click(object sender, EventArgs e)
        {

        }

        

        protected void btn_info_Click(object sender, EventArgs e)
        {

        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
           
            if (Session["Email"] != null)
            {
                Session.Remove("Email");
                Session.Remove("Password");
                Response.Redirect("login.aspx");
            }
            Response.Redirect("login.aspx");
        }

        protected void logout_ServerClick(object sender, EventArgs e)
        {
            if (Session["Email"] != null)
            {
                Session.Remove("Email");
                Session.Remove("Password");
                Response.Redirect("login.aspx");
            }
            Response.Redirect("login.aspx");
        }
    }
}