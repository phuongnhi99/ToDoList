using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
            progress.InnerHtml = "";
            done.InnerHtml = "";
            late.InnerHtml = "";
            List<Entity.Task> taskProgress = TaskBLL.GetTaskProgress();
            List<Entity.Task> taskDone = TaskBLL.GetTaskDone();
            List<Entity.Task> taskLate = TaskBLL.GetTaskLate();
            DataSource = taskProgress.ToList();
            DataSource = taskDone.ToList();
            DataSource = taskLate.ToList();
            DataBind();
            foreach (Entity.Task task_progress in taskProgress)
                progress.InnerHtml = progress.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body input-group\">" +
                             "<div class=\"form-control bd\">" +
                                task_progress.Name +
                             "</div>" +
                                "<div class=\"input-group-append\">" +
                                    "<button runat='server' onserverclick='hello' ID=" + task_progress.ID +" class=\"btn btn-change-status-inprogress\" type=\"submit\"><i class=\"fa fa-arrow-right\"></i></button>" +
                                "</div>" +
                            "</div>" +
                        "</li>" +
                    "</ul>";

            foreach (Entity.Task task_done in taskDone)
                done.InnerHtml = done.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body input-group\">" +
                                "<div class=\"input-group-append\">" +
                                    "<button class=\"btn btn-change-status-done\" type=\"button\"><i class=\"fa fa-arrow-left\"></i></button>" +
                                "</div>" +
                                "<div class=\"form-control bd\">" +
                                    task_done.Name +
                                "</div>" +
                            "</div>" +
                        "</li>" +
                    "</ul>";


            foreach (Entity.Task task_late in taskLate)
                late.InnerHtml = late.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body p-1\">" +
                                "<div class=\"card-title m-0\">" +
                                    task_late.Name +
                                "</div>" +
                            "</div>" +
                        "</li>" +
                    "</ul>";
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }
        protected void btnClose_Clicks(object sender, EventArgs e)
        {
            if(edit_cover.Visible == true)
            edit_cover.Visible = false;
        }

        //protected void hello(object sender, EventArgs e)
        //{
        //    html.InnerHtml = "byebye";
        //    //HtmlButton button = (HtmlButton)sender;
        //    //TaskBLL.ChangeStatusToDone(button.ID);
        //}
    }
}