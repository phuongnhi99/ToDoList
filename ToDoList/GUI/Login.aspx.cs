﻿using NUnit.Framework.Internal;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ToDoList.BLL;

namespace ToDoList.GUI
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            int i;
            if (txtEmail.Text == "" || txtPassword.Text == "")
                lblmessage.Text = "Vui lòng nhập Email và Password";
            else
            {
                i = EmployeeBLL.checklogin(txtEmail.Text, txtPassword.Text);
                if (i == 0)
                    lblmessage.Text = "Tài khoản không tồn tại!!";
                else
                    Response.Redirect("employeeview.aspx");
            }
        }













        //protected void btn_login_Click(object sender, EventArgs e)
        //{
        //    int i;
        //    //var value = ((HtmlInputText)Test.FindControl("txtEmail")).Value.ToString();
        //    if (txtEmail.Text == "" || txtPassword.Text == "")
        //        lblmessage.text = "bạn phải nhập vào username và password !";
        //    else
        //            {
        //                i = employeebll.checklogin(txtemail.text, txtemail.text);
        //                if (i == 0)
        //            lblmessage.text = "username và password không hợp lệ. vui lòng nhập lại!";
        //        else
        //                            response.redirect("employeeview.aspx");
        //            }
        //    //ctrl k +c ---> ctrl k +u
        //}
    }
}