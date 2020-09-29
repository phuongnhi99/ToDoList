﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="TaskView.aspx.cs" Inherits="ToDoList.GUI.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-cover">
        <div class="container">
            <div class="row d-flex justify-content-end m-1">
                <button type="button" class="btn btn-dark p-2 cal-btn"><i class="fa fa-calendar"></i>TODAY</button>
                <button type="button" class="btn btn-dark p-2 cal-btn"><i class="fa fa-calendar"></i>THIS WEEK</button>
            </div>

            <div class="row">
                <div class="col card inprogress ">
                    <div class="card-header">
                        <h5 class="card-title">IN PROGRESS</h5>
                    </div>
                    <div id="progress" runat="server" class="card-body">                        
                    </div>
                    <div class="card-footer">
                        <button class="btn add-btn"><i class="fa fa-plus"></i>ADD NEW TASK</button>
                    </div>
                </div>

                <div class="col card done ">
                    <div class="card-header">
                        <h5 class="card-title">DONE</h5>
                    </div>
                    <div id="done" runat="server" class="card-body">
                    </div>
                    <div class="card-footer">
                    </div>
                </div>

                <div class="col card late ">
                    <div class="card-header">
                        <h5 class="card-title">LATE</h5>
                    </div>
                    <div id="late" runat="server" class="card-body">
                    </div>
                    <div class="card-footer">
                    </div>
                </div>
            </div>

        </div>
    </div>


    <div id="edit_cover" runat="server" >
    <div class="edit-cover" >
         <form>
        <div class="edit-content card" runat="server">
                <div class="card-header">
                  <button class="close" runat="server" onserverclick="btnClose_Clicks"><i class="fas fa-times"></i></button>
                  <h4>TASK</h4>
                </div>
                <div class="card-body" style="overflow:auto">
                 <div class="form-row ">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">Name</label>
                        <input type="email" class="form-control" id="inputEmail4" placeholder="Email">
                    </div>
                      <div class="form-group col-md-6">
                        <label for="inputEmail4">Description</label>
                        <input type="email" class="form-control" id="inputEmail4" placeholder="Email">
                    </div>
                 </div>
                <div class="form-group row">
                    
                    <div class="col-6">
                        <label for="example-date-input" class="col-4 col-form-label">Start Day</label>
                        <input class="form-control" type="date" value="2011-08-19" id="example-date-input">
                    </div>
                    <div class="col-6">
                        <label for="example-date-input" class="col-4 col-form-label">Đeadline</label>
                        <input class="form-control" type="date" value="2011-08-19" id="example-date-input">
                    </div>
                </div>
     
        <div class="form-row ">
                   
                </div>
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <label for="inputCity">Partner</label>
                        <select id="inputState" class="form-control" multiple>
                            <option selected>Choose...</option>
                            <option>...</option>
                        </select>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="inputState">Status</label>
                        <select id="inputState" class="form-control">
                            <option selected>Choose...</option>
                            <option>...</option>
                        </select>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="inputZip">Visability</label>
                        <select id="inputState" class="form-control">
                            <option selected>Choose...</option>
                            <option>...</option>
                        </select>
                    </div>
                </div>
                <div class="form-group">
                    <label for="exampleInputFile">File input</label>
                    <input type="file" class="form-control-file" id="exampleInputFile" aria-describedby="fileHelp">
                    <small id="fileHelp" class="form-text text-muted">This is some placeholder block-level help text for the above input. It's a bit lighter and easily wraps to a new line.</small>
                </div>


            </div>
      
        <div class="card-footer">hello</div>
             </div>
             </form>
         
        </div>
                

         <div class="blur-bg"</div>
    </div>
</asp:Content>
