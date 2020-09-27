<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Site.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="TaskView.aspx.cs" Inherits="ToDoList.GUI.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id ="content-cover">
<div class="container">

  <div class="row">

        <div class="col card">
                     <div class="card-body">
                 <h5 class="card-title">Title</h5>
                     <ul class="list-group list-group-flush">
                        <li class="card">Cras justo odio</li>
                        <li class="card">Dapibus ac facilisis in</li>
                        <li class="card ">Vestibulum at eros</li>
                      </ul>
                     <a href="#" class="btn btn-primary">Go somewhere</a>
                     </div>
           
        </div>

        <div class="col">
          One of three columns
        </div>

        <div class="col">
          One of three columns
        </div>
   </div>
  
</div>
</div>
</asp:Content>
