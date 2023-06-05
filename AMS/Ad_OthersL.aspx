<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ad_OthersL.aspx.cs" Inherits="AMS.Ad_Others" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="icon" href="images/ams.jpg" type="image/icon type" />
    <link rel="stylesheet" href="Css/style.css" />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
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
          <center>
          <select style="width:50%;border-color:lightgray;font-size:17px" id="Select1" name="SelectRole">
            <option value="Select a Role">Select a Role</option>
            <option value="Administration">Administration</option>
            <option value="Police">Police</option>
            <option value="RDA">RDA</option>
            <option value="Insurance">Insurance</option>
        </select><br /><br /><br />
         </center>
            <div class="input_field">
             <asp:TextBox ID="txtuname" runat="server" placeholder="Enter The Email"></asp:TextBox><asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email Should Not Be Empty" ControlToValidate="txtuname" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>


           <div class="input_field">
            <asp:TextBox ID="pass" runat="server" placeholder="Enter The Password" TextMode="Password"></asp:TextBox> <asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Should Not Be Empty" ForeColor="Red" ControlToValidate="pass"></asp:RequiredFieldValidator>
           </div>
            
          <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
        
      </div>
    </div>
  </div>
</div>
</form>
</body>
</html>
