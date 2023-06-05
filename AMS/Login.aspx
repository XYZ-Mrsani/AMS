<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AMS.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="icon" href="images/ams.jpg" type="image/icon type" />
    <link rel="stylesheet" href="Css/style.css" />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form runat="server">

 <div class="form_wrapper">
  <div class="form_container">
    <div class="title_container">
      <h2>Login</h2>
    </div>
    <div class="row clearfix">
      <div class="">
       

            <div class="input_field">
             <asp:TextBox ID="txtuname" runat="server" placeholder="Enter The Email"></asp:TextBox><asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email Should Not Be Empty" ControlToValidate="txtuname" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>


           <div class="input_field">
            <asp:TextBox ID="pass" runat="server" placeholder="Enter The Password" TextMode="Password"></asp:TextBox> <asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Should Not Be Empty" ForeColor="Red" ControlToValidate="pass"></asp:RequiredFieldValidator>
           </div>
            
          <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <a href="Signup.aspx" style="color:black; text-decoration:none;">Signup</a>

      </div>
    </div>
  </div>
</div>
          </form>
</body>
</html>
