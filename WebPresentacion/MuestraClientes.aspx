<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MuestraClientes.aspx.cs" Inherits="WebPresentacion.MuestraClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mostrar Clientes</title>

      <!--Bootstrap-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js""></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
         <!--Nav-->

       <nav class="navbar navbar-expand-lg navbar-light bg-light" style="background-color: #e3f2fd;">
          <div class="container-fluid">
          <img src="IMG/icono.png" width="30" height="30" class="d-inline-block align-top" alt=""/>
          <a class="navbar-brand" href="Inicio.aspx">Taller2021</a>
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse">
          <ul class="navbar-nav">
          <li class="nav-item">
          <a class="nav-link active" href="Inicio.aspx">Inicio</a>
          </li>
          <li class="nav-item">
          <a class="nav-link active" href="RegistroClientes.aspx">Registrar Cliente</a>
          </li>
          <li class="nav-item">
          <a class="nav-link active" href="MuestraClientes.aspx">Mostrar Clientes</a>
          </li>
          </ul>
          </div>
         </div>
        </nav>

        <br />
      

        <center><asp:Label ID="Label1" runat="server" Text="Mostar todos los clientes registrados en el Taller 2021." Font-Bold="True" Font-Italic="True" Font-Names="Arial Narrow" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="True" ForeColor="#0066CC"></asp:Label></center>
        
        <br />

        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Mostrar Clientes" OnClick="Button2_Click"/>

         <br />
        <br />

        <center><div>
            <asp:Label ID="Label2" runat="server" Text="Registro Clientes." Font-Bold="True" Font-Italic="True" Font-Names="Bahnschrift SemiBold SemiConden" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Font-Underline="True" ForeColor="#0099FF"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </div></center>


    </form>
</body>
</html>
