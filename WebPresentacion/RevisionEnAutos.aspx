<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RevisionEnAutos.aspx.cs" Inherits="WebPresentacion.RevisionEnAutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

     <!--Bootstrap-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js""></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"></script>

    <!--SweetAlert-->
    <link href="css/sweetalert2.min.css" rel="stylesheet" />
    <script src="js/sweetalert2.all.min.js"></script>
    <script src="js/JavaScript.js"></script>


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
          <a class="nav-link active" href="BuscarAutoHistorial.aspx">Historial</a>
          </li>
          <li class="nav-item">
          <a class="nav-link active" href="ReparacionAutos.aspx">Reparaciones</a>
          </li>
          <li class="nav-item">
          <a class="nav-link active" href="RevisionEnAutos.aspx">Revisiones</a>
          </li>
          </ul>
          </div>
         </div>
        </nav>
          <!--Formularios-->
        <div class="form-group" style="width:700px; margin-left:400px; margin-top:50px;">
        <asp:Label ID="Label2" runat="server" Text="Entrada:"></asp:Label>
       <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Label ID="Label3" runat="server" Text="Falla:"></asp:Label>
        <asp:TextBox ID="txtFalla" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Diagnostico:"></asp:Label>
        <asp:TextBox ID="txtDiag" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Autorización:"></asp:Label>
        <asp:DropDownList ID="dlAutori" runat="server" style="width:700px; height:35px;">
            <asp:ListItem Value="1">Autorizado</asp:ListItem>
            <asp:ListItem Value="0">NO Autorizado</asp:ListItem>
            </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Auto:"></asp:Label>
        <asp:DropDownList ID="AutosId" runat="server" style="width:700px; height:35px;"></asp:DropDownList>
        <asp:Label ID="Label6" runat="server" Text="Mecánico:"></asp:Label>
        <asp:DropDownList ID="MecanicosId" runat="server" style="width:700px; height:35px;"></asp:DropDownList>
        </div>
        <br />
           <div style="margin-left:400px;">
       <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" class="btn btn-primary" OnClick="btnRegistrar_Click"/> 
        </div>
    </form>
</body>
</html>
