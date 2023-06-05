<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="AMS.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
<link rel="icon" href="images/ams.jpg" type="image/icon type" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <style>
            body {
    background: rgb(99, 39, 120)
}

.form-control:focus {
    box-shadow: none;
    border-color: #BA68C8
}

.profile-button {
    background: rgb(99, 39, 120);
    box-shadow: none;
    border: none
}

.profile-button:hover {
    background: #682773
}

.profile-button:focus {
    background: #682773;
    box-shadow: none
}

.profile-button:active {
    background: #682773;
    box-shadow: none
}

.back:hover {
    color: #682773;
    cursor: pointer
}

.labels {
    font-size: 11px
}

.add-details:hover {
    background: #BA68C8;
    color: #fff;
    cursor: pointer;
    border: solid 1px #BA68C8
}
    </style>
    <script>
        function click() {
            swal({
                title: "Are you sure?",
                text: "Once deleted, you will not be able to recover this imaginary file!",
                icon: "warning",
                buttons: true,
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete) {
                        swal("Poof! Your imaginary file has been deleted!", {
                            icon: "success",
                        });
                    }
                    }
                });
        }
    </script>
</head>
<body>
    <form runat="server">
<nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">

    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavDropdown">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="LoginHome.aspx">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="InsertFrom.aspx">Report Accident</a>
        </li>
          </ul>
        <ul class="navbar-nav">
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
          </a>
          <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
            <li><asp:LinkButton ID="LinkButton1" runat="server" CssClass="dropdown-item" OnClick="LinkButton1_Click1">View Profile</asp:LinkButton></li>
            <li><asp:LinkButton ID="LinkButton2" runat="server" CssClass="dropdown-item" OnClick="LinkButton2_Click">LogOut</asp:LinkButton></li>
          </ul>
        </li>
      </ul>
    </div>
      </div>
</nav>
        
<div class="container rounded bg-white mt-5 mb-5">
    <div class="row">
        <div class="col-md-3 border-right">
            <div class="d-flex flex-column align-items-center text-center p-3 py-5"><img class="rounded-circle mt-5" width="150px" src="https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg"/> <asp:Label ID="Label1" runat="server"></asp:Label><span class="font-weight-bold"></span><span class="text-black-50"></span><span> <asp:Label ID="Label2" runat="server"></asp:Label></span></div>
        </div>
        <div class="col-md-5 border-right">
            <div class="p-3 py-5">
                <div class="d-flex justify-content-between align-items-center mb-3">
                    <h4 class="text-right">Profile Settings</h4>
                </div>
                <div class="row mt-2">
                    <div class="col-md-6"><label class="labels">First Name</label><asp:Label ID="lblname" runat="server" CssClass="form-control"></asp:Label> </div>
                    <div class="col-md-6">
                        <asp:Label runat="server" class="labels" Visible="False" ID="lname">Edit First Name</asp:Label><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Visible="False"></asp:TextBox> </div>
                    <div class="col-md-6"><label class="labels">Last Name</label><asp:Label ID="lbllname" runat="server" CssClass="form-control"></asp:Label> </div>
                    <div class="col-md-6">
                        <asp:Label runat="server" class="labels" Visible="False" ID="llname">Edit Last Name</asp:Label><asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Visible="False"></asp:TextBox> </div>
                </div>
                <div class="row mt-3">
                    <div class="col-md-12"><label class="labels">Address</label><asp:Label ID="lbladd" runat="server" CssClass="form-control"></asp:Label> </div>
                    <div class="col-md-12">
                        <asp:Label runat="server" class="labels" Visible="False" ID="ladd">Edit Address</asp:Label><asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Visible="False"></asp:TextBox> </div>
                    <div class="col-md-12"><label class="labels">Mail</label><asp:Label ID="lblmail" runat="server" CssClass="form-control"></asp:Label> </div>
                    
                </div><br /><br /><br />
                <div class="mt-5 text-center"><asp:Button ID="Button1" runat="server" Text="Edit" CssClass="btn btn-primary profile-button" OnClick="Button1_Click" Width="100px"/>&emsp;<asp:Button ID="Button2" runat="server" Text="Update" CssClass="btn btn-primary btn-success " OnClick="Button2_Click" Width="100px"/>&emsp;<asp:Button ID="Button3" runat="server" Text="Back" CssClass="btn btn-primary profile-button" OnClick="Button3_Click" Width="100px"/>&emsp;<button type="button" class="btn btn-danger" data-bs-toggle="modal" data-bs-target="#exampleModal" style="width:100px;">Delete</button></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="p-3 py-5">
                <div class="d-flex justify-content-between align-items-center details"><span>Edit Vehicle Details</span><span class="border px-3 p-1 add-details"><i class="fa fa-plus"></i>&nbsp;Vehicle Details</span></div><br/>
                <div class="col-md-12"><label class="labels">Vehicle Type </label><asp:Label ID="lblvtype" runat="server" CssClass="form-control"></asp:Label> </div>
                 <div class="col-md-12">
                        <asp:Label runat="server" class="labels" Visible="False" ID="ltype">Edit Vehicle Type</asp:Label><asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" Visible="False"></asp:TextBox> </div><br />
                <div class="col-md-12"><label class="labels">Vehicle Number</label><asp:Label ID="lblvnum" runat="server" CssClass="form-control"></asp:Label> </div>
                 <div class="col-md-12">
                        <asp:Label runat="server" class="labels" Visible="False" ID="lnumber">Edit Vehicle Number</asp:Label><asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" Visible="False"></asp:TextBox> </div><br /><br />

                <div class="d-flex justify-content-between align-items-center details"><span>Edit Insurance Details</span><span class="border px-3 p-1 add-details"><i class="fa fa-plus"></i>&nbsp;Insurance Details</span></div><br/>
                <div class="col-md-12"><label class="labels">Insurance Name</label><asp:Label ID="lblin" runat="server" CssClass="form-control"></asp:Label> </div>
                 <div class="col-md-12">
                        <asp:Label runat="server" class="labels" Visible="False" ID="linsurancen">Edit Insurance Name</asp:Label><asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" Visible="False"></asp:TextBox> </div>
                    <div class="col-md-12"><label class="labels">Insurance Number</label><asp:Label ID="lblinum" runat="server" CssClass="form-control"></asp:Label> </div>
                 <div class="col-md-12">
                        <asp:Label runat="server" class="labels" Visible="False" ID="linsurancenum">Edit Insurance Number</asp:Label><asp:TextBox ID="TextBox8" runat="server" CssClass="form-control" Visible="False"></asp:TextBox> </div>
            </div>
        </div>
        
                    
                </div>
            </div>

<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Are You Sure Want Delete!</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <asp:Button ID="Button4" runat="server" Text="Delete" CssClass="btn btn-primary btn-danger" Width="100px" OnClick="Button4_Click" />
      </div>
    </div>
  </div>
</div>

    </form>
</body>
</html>
