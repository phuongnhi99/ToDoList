using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToDoList.GUI
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_task_Click(object sender, EventArgs e)
        {

        }

        protected void btn_employee_Click(object sender, EventArgs e)
        {

        }

        protected void btn_user_Click(object sender, ImageClickEventArgs e)
        {
            pn_user.Visible = true;
        }
    }
}