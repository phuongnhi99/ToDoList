<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskTest.aspx.cs" Inherits="ToDoList.GUI.TaskTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 394px;
        }
    </style>
</head>
<body style="height: 387px">
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Button ID="edit" runat="server" OnClick="edit_Click" Text="id1" />
            <asp:Button ID="sua" runat="server" OnClick="sua_Click" Text="Button" />
        </asp:Panel>
       
        
        <asp:Label ID="ID" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="OwnerId"></asp:Label>
        <asp:TextBox ID="txtOwnerId" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="StartDay"></asp:Label>
        <asp:TextBox ID="txtStartDay" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Deadline"></asp:Label>
        <asp:TextBox ID="txtDeadline" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Visibility"></asp:Label>
        <asp:TextBox ID="txtVisibility" runat="server"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Attachment"></asp:Label>
        <asp:TextBox ID="txtAttachment" runat="server"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Comment"></asp:Label>
        <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="Partner"></asp:Label>
        <asp:TextBox ID="txtPartner" runat="server"></asp:TextBox>
           
    </form>
</body>
</html>
