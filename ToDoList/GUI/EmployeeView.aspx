<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="ToDoList.Employee"  MasterPageFile="~/GUI/Site.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="content-cover">
    <div class="container">
            <h1>EMPLOYEE</h1>
            <div>
                <button type="button" class="btn btn-elegant" id="btn_Add" runat="server" onserverclick="btn_Add_ServerClick">
                    <i class="fas fa-plus"></i> Add New
                </button>
            </div>
            <asp:Panel ID="Panel1" runat="server" Width="100%">
            <table id="paginationSimpleNumbers" class="table" width="100%">
                        <thead>
                            <tr>
                                <th class="th-sm">
                                    ID
                                </th>
                                <th class="th-sm">
                                    Name
                                </th>
                                <th class="th-sm">
                                    Mail
                                </th>
                                <th class="th-sm">
                                    Phone Number
                                </th>
                                <th class="th-sm">
                                    Birthday
                                </th>
                                <th class="th-sm">
                                    Position
                                </th>
                                <th class="th-lg">
                                </th>
                            </tr>
                        </thead>
                        <tbody id="abc" runat="server">
                        </tbody>
                    </table>
                </asp:Panel>
    </div>
</div>

    <%-------------Add new-------------%>
<div id="form_add" runat="server" visible="false">
    <div class="edit-cover" >
        <form>
            <div class="edit-content card" runat="server">
                <div class="card-header">
                <button class="close" runat="server" id="btn_close" onserverclick="btn_close_ServerClick"><i class="fas fa-times"></i></button>
                <h4>ADD NEW EMPLOYEE</h4>
            </div>
            <div class="card-body" style="overflow:auto">
            <div class="form-row ">
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Name</label>
                    <input type="text" class="form-control" id="username" placeholder="Full name">
                    <label class="valid-feedback"></label>
                </div>
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Email</label>
                    <input type="email" class="form-control" id="inputEmail4" placeholder="Email">
                    <label class="valid-feedback"></label>
                </div>
            </div>
            <div class="form row">
                <div class="form-group col-md-6">
                    <label for="password">Password</label>
                    <input class="form-control" type="password" id="password">
                    <label class="valid-feedback"></label>
                </div>
                <div class="form-group col-md-6">
                    <label for="example-date-input">Confirm Password</label>
                    <input class="form-control" type="password" id="confirm_password">
                    <label class="valid-feedback"></label>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    <label for="phonenumber" class="col-form-label">Phone Number</label>
                    <input class="form-control" type="text" id="phone_number">
                    <label class="valid-feedback"></label>
                </div>
                <div class="col-4">
                    <label for="example-date-input" class="col-form-label">Birthday</label>
                    <input class="form-control" type="date" id="birthday">
                </div>
                <div class="col-4">
                    <label for="position" class="col-form-label">Position</label>
                    <input class="form-control" type="text" id="position">
                </div>
            </div>
                <button type="reset" class="btn btn-light">Cancel</button>
                <button type="submit" class="btn btn-black">Add</button>
        </div>
            </div>
        </form>
    </div>   
</div>
    <%-----------End Add new-----------%>

    <%-----------Form Edit-----------%>
<div id="form_edit" runat="server" visible="false">
    <div class="edit-cover" >
        <form>
            <div class="edit-content card" runat="server">
                <div class="card-header">
                <button class="close" runat="server" id="close_edit" onserverclick="close_edit_ServerClick"><i class="fas fa-times"></i></button>
                <h4>EDIT EMPLOYEE</h4>
            </div>
            <div class="card-body" style="overflow:auto">
            <div class="form-row ">
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Name</label>
                    <input type="text" class="form-control" id="username_edit">
                    <label class="valid-feedback"></label>
                </div>
                <div class="form-group col-md-6">
                    <label for="inputEmail4">Email</label>
                    <input type="email" class="form-control" id="email_edit">
                    <label class="valid-feedback"></label>
                </div>
            </div>
            <div class="form-group row">
                <div class="col-4">
                    <label for="phonenumber" class="col-form-label">Phone Number</label>
                    <input class="form-control" type="text" id="phone_number_edit">
                    <label class="valid-feedback"></label>
                </div>
                <div class="col-4">
                    <label for="example-date-input" class="col-form-label">Birthday</label>
                    <input class="form-control" type="date" id="birthday_edit">
                </div>
                <div class="col-4">
                    <label for="position" class="col-form-label">Position</label>
                    <input class="form-control" type="text" id="position_edit">
                </div>
            </div>
                <button type="reset" class="btn btn-light">Cancel</button>
                <button type="submit" class="btn btn-black">Change</button>
        </div>
            </div>
        </form>
    </div>
</div>
    <%-----------End Form edit-----------%>

    <%-----------Detail-----------%>
<div id="detail" runat="server" visible="false">
    <div class="edit-cover" >
        <form>
            <div class="edit-content card" runat="server">
                <div class="card-header">
                    <button class="close" runat="server" id="btn_close_detail" onserverclick="btn_close_detail_ServerClick"><i class="fas fa-times"></i></button>
                    <h4>INFORMATION</h4>
                </div>
                <div class="card-body" style="overflow:auto">
                    <div class="form-row ">
                        <div class="form-group col-md-6">
                            <label for="inputEmail4">Name</label>
                            <input type="text" class="form-control" id="username_detail" disabled>
                            <label class="valid-feedback"></label>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="inputEmail4">Email</label>
                            <input type="email" class="form-control" id="email_detail" disabled>
                            <label class="valid-feedback"></label>
                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="col-4">
                            <label for="phonenumber" class="col-form-label">Phone Number</label>
                            <input class="form-control" type="text" id="phone_number_detail" disabled>
                            <label class="valid-feedback"></label>
                        </div>
                        <div class="col-4">
                            <label for="example-date-input" class="col-form-label">Birthday</label>
                            <input class="form-control" type="date" id="birthday_detail" disabled>
                        </div>
                        <div class="col-4">
                            <label for="position" class="col-form-label">Position</label>
                            <input class="form-control" type="text" id="position_detail" disabled>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>
    <%-----------Detail-----------%>
    
 <!-- Central Modal Medium Success-->
    </asp:Content>