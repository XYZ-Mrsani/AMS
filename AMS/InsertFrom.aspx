<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertFrom.aspx.cs" Inherits="AMS.InsertFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Accident</title>
    <link rel="icon" href="images/ams.jpg" type="image/icon type" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">

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
                                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                <li>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="dropdown-item" OnClick="LinkButton1_Click">View Profile</asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="dropdown-item" OnClick="LinkButton2_Click">LogOut</asp:LinkButton></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <div class="mb-5"></div>
        <div class="container">
            <div class="col-lg-5 mx-auto card shadow p-3 mb-5 bg-body rounded">
                <div class="card-body">
                    <table class="table">
                        <tbody>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Location"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Accident Type"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="dropdownList" runat="server">
                                        <asp:ListItem Value="0">Please Select</asp:ListItem>
                                        <asp:ListItem>Car Accidents</asp:ListItem>
                                        <asp:ListItem>Natural Disasters</asp:ListItem>
                                        <asp:ListItem>Robbery</asp:ListItem>
                                        <asp:ListItem>Terrorist</asp:ListItem>
                                        <asp:ListItem>Others</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Image"></asp:Label>
                                </td>
                                <td>
                                    <asp:FileUpload ID="uploadImage" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="btnUpload" runat="server" Text="Upload" class="btn btn-success" OnClick="btnUpload_Click1" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <asp:Label ID="lblErrorMzg" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </form>




    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
</body>
</html>
