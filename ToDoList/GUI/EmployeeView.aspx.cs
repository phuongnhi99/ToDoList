﻿using System;
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
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var md5 = new MD5CryptoServiceProvider();
            if (EmployeeBLL.checkduplicate(txtEmail.Text) ==0 || EmployeeBLL.checkduplicatephone(txtPhoneNumber.Text) == 0)
            {

                Response.Redirect("employeeview.aspx");
                Page_Load(sender, e);
            }
            else {
                Entity.Employee employee = new Entity.Employee()
                {

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
                ID = Convert.ToInt32(txtID.Text),
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
            txtID.Text = "aaaaa";
        }
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            txtID.Text = "bbbbbb";
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