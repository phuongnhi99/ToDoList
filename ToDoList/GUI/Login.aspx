<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ToDoList.GUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập-to do list</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body style="background-color: #EADFD8; font-family: 'Sitka Heading'">
    <%--Form login--%>
   <form runat="server" id="form_login">
        <div style="background-color: #FFFFFF; position: absolute; width: 30%; height: 80%; top: 10%; left: 20%; box-shadow:0 6px 20px 0 rgba(0, 0, 0, 0.19);">
            <p style="color: #EA4C89; font-size: 30px; text-align: center; top: 3%; position: absolute; width: 100%;">To do list</p>
            <p style="font-size: 20px; text-align: center; top: 20%; position: absolute; width: 100%;">WELCOME</p>
            <%--Email--%>
            <p style="font-size: 18px; position: absolute; left: 8%; top: 35%;">Email:</p>
            <input id="email"
                    style="font-size: 15px; position: absolute; left: 9%; top: 42%; width: 80%; height: 5%" placeholder="Nhập email..."/>
            <%--Password--%>
            <p style="font-size: 18px; position: absolute; left: 8%; top: 50%;">Password:</p>
            <input id="password" type="password"
                    style="font-size: 15px; position: absolute; left: 9%; top: 57%; width: 80%; height: 5%" placeholder="Nhập password..."/>
            <button id="btn_login"
                    style=" border-style: none; padding: 10px; font-size: 18px; text-align: center; position: absolute; top: 71%; width: 30%; left: 35%; background-color: #008CBA; cursor: pointer; color: #FFFFFF; border-radius: 8px">
                Đăng nhập
            </button>
        </div>
    </form>
    <%--End Form--%>
    <div style="background-image: url('../Image/photo-1564703821142-e88574e6cfa8.jpg'); position: absolute; width: 30%; height: 80%; top: 10%; right: 20%; box-shadow:0 6px 20px 0 rgba(0, 0, 0, 0.19);"></div>
</body>
</html>
