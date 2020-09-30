<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="TaskView.aspx.cs" Inherits="ToDoList.GUI.WebForm1" %>

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
                        <h5 id="test" runat="server" class="card-title">IN PROGRESS</h5>
                    </div>
                    <div id="progress" runat="server" class="card-body">
                        <ul class="list-group list-group-flush">
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="form-control bd">jjj</div>

                                    <div class="input-group-append">
                                        <button name='btnInprogress' runat='server' value="" class="btn btn-change-status-inprogress" type="submit">
                                            <i class="fa fa-arrow-right"></i>
                                        </button>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="card-footer">
                        <button runat="server" id="newtask" onserverclick="newtask_ServerClick" class="btn add-btn"><i class="fa fa-plus"></i>ADD NEW TASK</button>
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


    <div id="edit_cover" runat="server" visible="false">
        <div class="edit-cover">
            <form>
                <div class="edit-content card" runat="server">
                    <div class="card-header">
                        <button class="close" runat="server" onserverclick="btnClose_Clicks"><i class="fas fa-times"></i></button>
                        <h4>TASK</h4>
                        <input runat="server" id="id_task" style="visibility:hidden">
                    </div>
                    <div class="card-body" style="overflow: auto">
                        <div class="row">
                            <div class="col">
                                <div class="form-row ">
                                    
         
                                    <div class="form-group col-md-6">
                                        <label for="inputName">Name</label>
                                        <input type="text" runat="server" class="form-control" id="inputName" placeholder="Name task">
                                    </div>
                                    <div class="form-group col-md-6">
                                        <label for="inputDescription">Description</label>
                                        <input type="text" runat="server" class="form-control" id="inputDescription" placeholder="Description">
                                    </div>
                                </div>
                                <div class="form-group row">

                                    <div class="col-6">
                                        <label for="start_date" class="col-6 col-form-label">Start Day</label>
                                       <input class="form-control" runat="server" type="date" value="2011-08-19" id="start_date">
                                    </div>
                                    <div class="col-6">
                                        <label for="deadline" class="col-6 col-form-label">Deadline</label>
                                        <input class="form-control" runat="server" type="date" value="2011-08-19" id="deadline">
                                    </div>
                                </div>

                                <div class="form-row ">
                                </div>
                                <div class="form-row">
                                    <div class="col-md-4">
                                        <div class="form-group ">
                                        <label for="Partner">Partner</label>
                                        <select runat="server" id="Partner" class="selectpicker form-control" multiple>
                                            <option selected>...</option>
                                            <option>...</option>
                                            <option>...</option>
                                        </select>
                                        </div>
                                    </div>

                                    <div class="form-group col-md-4">
                                         <div class="form-group ">
                                        <label for="Status">Status</label>
                                        <select runat="server" id="Status" class="selectpicker form-control">
                                            <option>In Progress</option>
                                            <option>Done</option>
                                        </select>
                                        </div>
                                    </div>

                                    <div class="form-group col-md-4">
                                         <div class="form-group ">
                                        <label for="Visability">Visability</label>
                                        <select runat="server" id="Visability" class="selectpicker form-control">
                                            <option>Public</option>
                                            <option>Private</option>
                                        </select>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="form-group">
                                    <label for="fileHelp">File input</label>
                                     <asp:FileUpload ID="FileUpload1" runat="server" Width="348px" Height="27px" />

                                    </div>
                                 </div>
                                <button type="submit" id="btnsave" runat="server" onserverclick="Unnamed_ServerClick" class="btn btn-primary">edit</button>
                                <button type="submit" id="backtask" runat="server" onserverclick="backtask_ServerClick" class="btn btn-primary">back</button>
                            </div>





                            <div class="col">
                                <div class="detailBox">
                                    <div class="titleBox">
                                        <label>Comment Box</label>
                                        <button type="button" class="close" aria-hidden="true">&times;</button>
                                    </div>
                                   
                                    <div class="actionBox">
                                        <ul runat="server" id="cmtbox" class="commentList">
                                            
                                        </ul>
                                        <form class="form-group" role="form">
                                                
                                                <div class="input-group mb-6">
                                                <input type="text" id="valuedescription" runat="server" class="form-control" placeholder="Recipient's username" aria-label="Recipient's username" aria-describedby="basic-addon2">

                                                <div class="input-group-append">
                                                   
                                                    <button id="addcomment" runat="server" onserverclick="addcomment_ServerClick"  class="btn sent btn-dark" type="button">Button</button>
                                            </div>
                                                    </div>
                                        </form>
                                    </div>
                                </div>
                            </div>


                        </div>
                    </div>

                  <%--  <div class="card-footer">hello</div>--%>
                </div>
            </form>

        </div>
                

         <div class="blur-bg"</div>
    </div>
</asp:Content>
