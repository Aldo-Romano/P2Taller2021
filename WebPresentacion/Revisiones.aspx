<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Revisiones.aspx.cs" Inherits="WebPresentacion.Revisiones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Revisiones</title>

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
            <a class="nav-link" href="Revisiones.aspx">Revisiones</a>
            </li>
            </ul>
            </div>
            </nav>
        </div>

          <!--Formularios-->
        <div class="form-group" style="width:700px; margin-left:400px; margin-top:50px;">
        <asp:Label ID="Label2" runat="server" Text="Entrada:"></asp:Label>
       <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Label ID="Label3" runat="server" Text="Falla:"></asp:Label>
        <asp:TextBox ID="txtFalla" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Diagnostico:"></asp:Label>
        <asp:TextBox ID="txtDiag" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Autorización:"></asp:Label>
        <asp:TextBox ID="txtAutori" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
        <div style="margin-left:400px;">
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Registrar"/>
        </div>


    </form>
</body>
</html>
