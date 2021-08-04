<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarAuto.aspx.cs" Inherits="WebPresentacion.MuestraAutoDelCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mostrar Auto del Cliente</title>

        <!--Bootstrap-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js""></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"></script>


</head>
<body>
    <form id="form1" runat="server">
        <!--Nav-->
        <div>
            <nav class="navbar navbar-light" style="background-color: #e3f2fd;">
            <a class="navbar-brand" href="#">
            <img src="IMG/icono.png" width="30" height="30" class="d-inline-block align-top" alt=""/>
             Taller2021</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
            <li class="nav-item">
            <a class="nav-link" href="Inicio.aspx">Inicio</a>
            </li>
            <li class="nav-item">
            <a class="nav-link" href="RegistroClientes.aspx">Registro Clientes</a>
            </li>
            <li class="nav-item">
            <a class="nav-link" href="RegistroAutos.aspx">Registro Autos</a>
            </li>
            <li class="nav-item">
            <a class="nav-link" href="MuestraClientes.aspx">Muestra Clientes</a>
            </li>
             <li class="nav-item">
            <a class="nav-link" href="MuestraAutos.aspx">Muestra Autos</a>
            </li>
            <li class="nav-item">
            <a class="nav-link" href="BuscarAuto.aspx">Buscar Auto</a>
            </li>
            </ul>
            </div>
            </nav>
        </div>

          <!--Formularios-->
        <div class="form-group" style="width:700px; margin-left:400px; margin-top:50px;">
        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Apellido paterno:"></asp:Label>
        <asp:TextBox ID="txtApp" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Apellido materno:"></asp:Label>
        <asp:TextBox ID="txtApm" runat="server" class="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Buscar Auto" OnClick="Button2_Click"/>
        </div>

        <br />
        <br />
        <center><div>
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
