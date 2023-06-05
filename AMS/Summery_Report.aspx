<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summery_Report.aspx.cs" Inherits="AMS.Summery_Report" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summary Report</title>
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
          <a class="nav-link active" aria-current="page" href="Ad_U_L_Home.aspx">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Accident Summery</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">All Accidents</a>
        </li>
          </ul>
        <ul class="navbar-nav">
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
          </a>
          <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
            <li>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CssClass="dropdown-item">LogOut</asp:LinkButton></li>
          </ul>
        </li>
      </ul>
    </div>
      </div>
</nav>
        <div style="margin-left:150px;">
            <div>
        <asp:Chart runat="server" ID="Chart1" Height="355px" Width="400px">
            <series>
                <asp:Series Name="Series1" ChartType="Pie" IsValueShownAsLabel="true"></asp:Series>
            </series>
            <Legends>
                <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="false" Name="Default" LegendStyle="Row" />
            </Legends>
            <chartareas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </chartareas>
        </asp:Chart>
                &ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;
        <asp:Chart ID="Chart2" runat="server" Height="355px" Width="400px">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
            </div>


    </form>
</body>
</html>
