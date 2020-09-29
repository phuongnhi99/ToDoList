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
            abc.InnerHtml = "";
            List<Entity.Employee> emp = EmployeeBLL.GetAll();
            foreach (Entity.Employee a in emp)
                abc.InnerHtml = abc.InnerHtml + "<tr>" +
                                "<td>" + a.ID + "</td>" +
                                "<td>" + a.Email + "</td>" +
                                "<td>" + a.Name + "</td>" +
                                "<td>" + a.PhoneNumber + "</td>" +
                                "<td>" + a.DateOfBirth.ToString("dd/MM/yyyy") + "</td>" +
                                "<td>" + a.Position + "</td>" +
                                "<td>" +
                                "<button class=\"btnmennu btn-cyan\"><i class=\"fa fa-eye\"></i></button>" +
                                "<button class=\"btnmennu btn-light\"><i class=\"fa fa-edit\"></i></button>" +
                                "<button class=\"btnmennu btn-dark\"><i class=\"fa fa-trash\"></i></button>" +
                                "</td>" +
                                "</tr>";

            //if (Session["Email"] == null)
            //{
            //    Response.Redirect("login.aspx");
            //}
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
            if (form_edit.Visible == false)
            {
                form_edit.Visible = true;
            }
        }

        protected void btn_close_detail_ServerClick(object sender, EventArgs e)
        {
            if (detail.Visible == false)
            {
                detail.Visible = true;
            }
        }
    }
}