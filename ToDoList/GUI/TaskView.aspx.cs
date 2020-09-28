using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoList.BLL;
using ToDoList.Entity;

namespace ToDoList.GUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Task> DataSource { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //progress.InnerHtml = "";
            //List<Entity.Task> task = TaskBLL.GetTaskProgress();

            //DataSource = task.ToList();
            //DataBind();
            //foreach (Entity.Task ta in task)
            //    progress.InnerHtml = progress.InnerHtml +
            //        "<ul>" +
            //            "<li>" +
            //                "<div>" +
            //                    "<div>" +
            //                        ta.Name +
            //                    "</div>" +
            //                "</div>" +
            //            "</li>" +
            //        "</ul>";
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }


        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}