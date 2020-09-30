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
                dayofbirth.Value = String.Format("{0:yyyy-MM-dd}", employee.DateOfBirth);
                phonenumber.Value = phonenumber_edit.Value = employee.PhoneNumber;
                position.Value = employee.Position;
                dayofbirth_edit.Value = String.Format("{0:yyyy-MM-dd}", employee.DateOfBirth);
                ID_user_edit.InnerText = Convert.ToInt32(employee.ID).ToString();
            }
        }
        //protected void btn_Done(object sender, EventArgs e)
        //{
        //    if (modalProfileForm.Visible == false)
        //    {
        //        modalProfileForm.Visible = true;
        //    }
            
        //    //Entity.Employee employee1 = EmployeeBLL.GetEmployeeByID(Convert.ToInt32(ID_user_edit.InnerText).ToString());
        //    //Entity.Employee employee = new Entity.Employee();
        //    //ID_user_edit.InnerText = employee1.Position.ToString();
        //    //employee.ID = Convert.ToInt32(ID_user_edit.InnerText);
        //    //employee.Name = username_edit.Name;
        //    //employee.DateOfBirth = Convert.ToDateTime(dayofbirth_edit.Value.ToString());
        //    //employee.Position = employee1.Position;
        //    //employee.Email = email_edit.Value;
        //    //employee.PhoneNumber = phonenumber_edit.Value;
        //    //if(old_password.Equals("")&& new_password.Equals("")&&confirm_password.Equals(""))
        //    //{
        //    //    EmployeeBLL.updateEmp(employee);
        //    //    Page_Load(sender, e);
        //    //}
        //    //else
        //    //{
        //    //    if (!old_password.Value.Equals("") && !EasyEncryption.MD5.ComputeMD5Hash(old_password.Value).Equals(employee.PassWord))
        //    //    {
        //    //        old_password_error.InnerText = "Passwords incorrect !!!";
        //    //        old_password.Value = "";
        //    //        modalEditProfileForm.Visible = true;
        //    //    }
        //    //    else
        //    //    {
        //    //        if (!new_password.Equals("") && !new_password.Value.Equals(confirm_password.Value))
        //    //        {
        //    //            confirm_password_error.InnerText = "Passwords do not match !!!";
        //    //            confirm_password.Value = "";
        //    //            modalEditProfileForm.Visible = true;
        //    //        }
        //    //        else
        //    //        {
        //    //            if (!old_password.Equals(""))
        //    //            {
        //    //                confirm_password_error.InnerText = "Passwords do not match !!!";
        //    //                confirm_password.Value = "";
        //    //                modalEditProfileForm.Visible = true;
        //    //            }
        //    //            else
        //    //            {
        //    //                EmployeeBLL.updatePass(employee);
        //    //                Page_Load(sender, e);
        //    //            }
        //    //        }
        //    //    }
        //    //}

        //}
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
        protected void btn_Done(object sender, EventArgs e)
        {
            Entity.Employee employee1 = EmployeeBLL.GetEmployeeByID(Convert.ToInt32(ID_user_edit.InnerText).ToString());
            Entity.Employee employee = new Entity.Employee();
            ID_user_edit.InnerText = employee1.Position.ToString();
            employee.ID = Convert.ToInt32(ID_user_edit.InnerText);
            employee.Name = username_edit.Value;
            employee.DateOfBirth = Convert.ToDateTime(dayofbirth_edit.Value.ToString());
            employee.Position = employee1.Position;
            employee.Email = email_edit.Value;
            employee.PhoneNumber = phonenumber_edit.Value;
            if (username_edit.Value.Equals("") || dayofbirth_edit.Value.Equals("") ||email_edit.Value.Equals("") || phonenumber_edit.Value.Equals("") )
            {
                modalEditProfileForm.Visible = true;
            }
            else
            {
                if (old_password.Equals("") || new_password.Equals("") || confirm_password.Equals(""))
                {
                    EmployeeBLL.updateEmp(employee);
                    Page_Load(sender, e);
                }
                else
                {
                    if (!old_password.Value.Equals("") && !EasyEncryption.MD5.ComputeMD5Hash(old_password.Value).Equals(employee.PassWord))
                    {
                        old_password_error.InnerText = "Passwords incorrect !!!";
                        old_password.Value = "";
                        modalEditProfileForm.Visible = true;
                    }
                    else
                    {
                        if (!new_password.Equals("") && !new_password.Value.Equals(confirm_password.Value))
                        {
                            confirm_password_error.InnerText = "Passwords do not match !!!";
                            confirm_password.Value = "";
                            modalEditProfileForm.Visible = true;
                        }
                        else
                        {
                            if (!old_password.Equals(""))
                            {
                                confirm_password_error.InnerText = "Passwords do not match !!!";
                                confirm_password.Value = "";
                                modalEditProfileForm.Visible = true;
                            }
                            else
                            {
                                EmployeeBLL.updatePass(employee);
                                Page_Load(sender, e);
                            }
                        }
                    }
                }
            }
            if (old_password.Equals("") || new_password.Equals("") || confirm_password.Equals(""))
            {
                EmployeeBLL.updateEmp(employee);
                Page_Load(sender, e);
            }
            else
            {
                if (!old_password.Value.Equals("") && !EasyEncryption.MD5.ComputeMD5Hash(old_password.Value).Equals(employee.PassWord))
                {
                    old_password_error.InnerText = "Passwords incorrect !!!";
                    old_password.Value = "";
                    modalEditProfileForm.Visible = true;
                }
                else
                {
                    if (!new_password.Equals("") && !new_password.Value.Equals(confirm_password.Value))
                    {
                        confirm_password_error.InnerText = "Passwords do not match !!!";
                        confirm_password.Value = "";
                        modalEditProfileForm.Visible = true;
                    }
                    else
                    {
                        if (!old_password.Equals(""))
                        {
                            confirm_password_error.InnerText = "Passwords do not match !!!";
                            confirm_password.Value = "";
                            modalEditProfileForm.Visible = true;
                        }
                        else
                        {
                            EmployeeBLL.updatePass(employee);
                            Page_Load(sender, e);
                        }
                    }
                }
            }
        }

        protected void edit_ServerClick(object sender, EventArgs e)
        {
            if(modalEditProfileForm.Visible == false)
            {
                modalEditProfileForm.Visible = true;
            }
        }

        protected void close_edit_ServerClick(object sender, EventArgs e)
        {
            if (modalEditProfileForm.Visible == true)
            {
                modalEditProfileForm.Visible = false;
            }
        }

        protected void logout_ServerClick1(object sender, EventArgs e)
        {
            Object obj = (Object)Session["Email"];
            if (obj != null)
            {
                Session.Remove("Email");
                Session.Remove("Password");
                Response.Redirect("login.aspx");
            }
            Response.Redirect("login.aspx");
        }
    }
}