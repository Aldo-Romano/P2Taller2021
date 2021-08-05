<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarAutoHistorial.aspx.cs" Inherits="WebPresentacion.BuscarAutoHistorial" %>

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
        <asp:Label ID="Label4" runat="server" Text="Placas:"></asp:Label>
        <asp:TextBox ID="txtPlacas" runat="server" class="form-control"></asp:TextBox>

        </div>
        <br />
           <div style="margin-left:400px;">
       <asp:Button ID="btnHistorial" runat="server" Text="Buscar Historial" class="btn btn-primary" OnClick="btnRegistrar_Click"/> 
        </div>

        <br />
        <br />

       <center><asp:GridView ID="gvHAut" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
           <EditRowStyle BackColor="#999999" />
           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#E9E7E2" />
           <SortedAscendingHeaderStyle BackColor="#506C8C" />
           <SortedDescendingCellStyle BackColor="#FFFDF8" />
           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
           </asp:GridView></center>

    </form>
</body>
</html>
