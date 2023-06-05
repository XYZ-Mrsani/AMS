<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="AMS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SignUp</title>
    <link rel="stylesheet" href="Css/style.css"/>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</head>
<body>
    <div class="form_wrapper">
  <div class="form_container">
    <div class="title_container">
      <h2>SignUp for Free</h2>
    </div>
    <div class="row clearfix">
      <div class="">
        <form runat="server">

              <div class="input_field">
               <asp:TextBox ID="txtname" runat="server" placeholder="First Name"></asp:TextBox><asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Should Not Be Empty" ControlToValidate="txtname" ForeColor="Red"></asp:RequiredFieldValidator>
              </div>

              <div class="input_field">
               <asp:TextBox ID="txtlname" runat="server" placeholder="Last Name"></asp:TextBox><asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Name Should Not Be Empty" ControlToValidate="txtlname" ForeColor="Red"></asp:RequiredFieldValidator>
              </div>

            <div class="input_field">
            <asp:TextBox ID="txtadd" runat="server" placeholder="Enter Your Home Address"></asp:TextBox><asp:Label ID="Label10" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Address Should Not Be Empty" ControlToValidate="txtlname" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>

          <div class="input_field">
            <asp:TextBox ID="email" runat="server" placeholder="Enter Your Email Address" required></asp:TextBox><asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email" ControlToValidate="email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
          </div>

            <div class="input_field">
            <asp:TextBox ID="txtVNum" runat="server" placeholder="Enter Your Vehicle Number"></asp:TextBox><asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Vehicle Number Should Not Be Empty" ControlToValidate="txtVNum" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>

            <div class="input_field">
                <asp:TextBox ID="txtVType" runat="server" placeholder="Enter Your Vehicle Type"></asp:TextBox><asp:Label ID="Label7" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Vehicle Type Should Not Be Empty" ControlToValidate="txtVType" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>

            <div class="input_field">
            <asp:TextBox ID="txtIN" runat="server" placeholder="Enter Your Insurance Name" ToolTip="EX (cooperative insurance - Full Option)"></asp:TextBox><asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Insurance Name Should Not Be Empty" ControlToValidate="txtIN" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>

            <div class="input_field">
            <asp:TextBox ID="txtINum" runat="server" placeholder="Enter Your Insurance Number"></asp:TextBox><asp:Label ID="Label9" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Insurance Number Should Not Be Empty" ControlToValidate="txtINum" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>

          <div class="input_field">
            <asp:TextBox ID="pass" runat="server" placeholder="Password" TextMode="Password" required></asp:TextBox><asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Minimum 8 characters atleast 1 Alphabet, 1 Number and 1 Special Character" ControlToValidate="pass" ForeColor="Red" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&amp;amp;])[A-Za-z\d$@$!%*#?&amp;amp;]{8,}$"></asp:RegularExpressionValidator>
          </div>
          <div class="input_field">
            <asp:TextBox ID="conpass" runat="server" placeholder="Confrim Password" TextMode="Password" required></asp:TextBox><asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
              <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password doesn't match" ControlToCompare="pass" ControlToValidate="conpass" ForeColor="Red"></asp:CompareValidator>
          </div>
            
          <asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click1"/>
            <a href="Login.aspx" style="text-decoration:none;color:black">Already have Account</a>
        </form>
      </div>
    </div>
  </div>
</div>
</body>
</html>

