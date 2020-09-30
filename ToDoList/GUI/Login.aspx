<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ToDoList.GUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập-to do list</title>
    <link href="../css/addons/datatables2.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css">
    <!-- Google Fonts Roboto -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap">
    <!-- Bootstrap core CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
    <!-- Material Design Bootstrap -->
    <link rel="stylesheet" href="../css/mdb.min.css">
    <!-- Your custom styles (optional) -->
    <link rel="stylesheet" href="../css/Main.css">
</head>
<body style="font-family: 'Sitka Heading'" >
   <form runat="server" id="form_login" method="post">
        <div class="bg-login">
            <p class="login-title text-dark">To do list</p>
            <p class="login-sign">SIGN IN</p>
            <p class="label-mail">Email:</p>
            <asp:TextBox ID="txtEmail" runat="server"
                         CssClass="tb-email" placeholder="Nhập email...">
            </asp:TextBox>
            <p class="label-pass">Password:</p>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" 
                CssClass="tb-pass" placeholder="Nhập password...">
            </asp:TextBox>
            <asp:TextBox ID="lblmessage" runat="server" ForeColor="#CC0000"
                CssClass="lb-message" Enabled="False" ReadOnly="True" ></asp:TextBox>
            <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="Đăng nhập"
                CssClass="btn-sign btn-dark"
            />
        </div>
    </form>
    <%--End Form--%>
    <div class="bg-img"></div>
    </body>
</html>
