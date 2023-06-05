<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNew_User.aspx.cs" Inherits="AMS.AddNew_User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Users</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
<script href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.0.3/css/font-awesome.css">
<script type="text/javascript" href="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<style type="text/css">
body {
    color: #000;
    overflow-x: hidden;
    height: 100%;
    background-color:#ebecee;
    background-repeat: no-repeat;
    background-size: 100% 100%
}

.card {
    padding: 30px 40px;
    margin-top: 20px;
    margin-bottom: 60px;
    border: none !important;
    box-shadow: 0 6px 12px 0 rgba(0, 0, 0, 0.2)
}

.form-control-label {
    margin-bottom: 0
}

input,
textarea,
button {
    padding: 8px 15px;
    border-radius: 5px !important;
    margin: 5px 0px;
    box-sizing: border-box;
    border: 1px solid #ccc;
    font-size: 18px !important;
    font-weight: 300
}

</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid px-1 py-5 mx-auto">
    <div class="row d-flex justify-content-center">
        <div class="col-xl-7 col-lg-8 col-md-9 col-11 text-center">
            <div class="card">
                <h3 class="text-center mb-4">Add New User</h3>
                <asp:Label ID="sessionlbl" runat="server" Visible="false"></asp:Label>
                    <div class="row justify-content-between text-left">
                        <div class="form-group col-sm-6 flex-column d-flex"> <label class="form-control-label px-3">Username<span class="text-danger"> *</span></label> <asp:TextBox ID="txtuname" runat="server" placeholder="Enter Username" ></asp:TextBox>&emsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username should not be empty" ControlToValidate="txtuname" ForeColor="Red"></asp:RequiredFieldValidator></div>
          
                    </div>
                    <div class="row justify-content-between text-left">
                        <div class="form-group col-sm-6 flex-column d-flex" style="left: 0px; top: 0px"> <label class="form-control-label px-3">Password<span class="text-danger"> *</span></label> <asp:TextBox ID="txtpass" runat="server" placeholder="Enter The Password" TextMode="Password"></asp:TextBox>&emsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password should not be empty" ControlToValidate="txtuname" ForeColor="Red"></asp:RequiredFieldValidator></div>
                        <div class="form-group col-sm-6 flex-column d-flex"> <label class="form-control-label px-3">Confirm Password<span class="text-danger"> *</span></label> <asp:TextBox ID="txtconpass" runat="server" placeholder="Enter The Confirm Password" TextMode="Password"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password doesn't match" ControlToCompare="txtpass" ControlToValidate="txtconpass" ForeColor="Red"></asp:CompareValidator></div>
                    </div>
                   
                    <div class="row justify-content-end">
                    	<div class="form-group col-sm-6"> <asp:Button ID="Button1" runat="server" Text="Home" CssClass="btn-block btn-primary" OnClick="Button1_Click" CausesValidation="false" /></div>
                        <div class="form-group col-sm-6"> <asp:Button ID="Button2" runat="server" Text="Add" CssClass="btn-block btn-success" OnClick="Button2_Click" /></div>
                    </div>
            </div>
        </div>
    </div>
</div>
    </form>
</body>
</html>