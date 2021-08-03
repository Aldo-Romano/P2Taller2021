<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebPresentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Taller 2021</title>

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
            <a class="nav-link" href="RegistroClientes.aspx">Registro Clientes</a>
            </li>
            </ul>
            </div>
            </nav>
        </div>

         <!--Carrusel-->
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
        <div class="carousel-item active">
        <img class="d-block w-100" src="IMG/1.jpg" alt="First slide">
        </div>
        <div class="carousel-item">
        <img class="d-block w-100" src="IMG/2.jpg" alt="Second slide">
        </div>
        <div class="carousel-item">
        <img class="d-block w-100" src="IMG/3.jpg" alt="Third slide">
        </div>
        </div>
       <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
       <span class="carousel-control-prev-icon" aria-hidden="true"></span>
       <span class="sr-only">Previous</span>
       </a>
       <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
       <span class="carousel-control-next-icon" aria-hidden="true"></span>
       <span class="sr-only">Next</span>
       </a>
       </div>
    </form>
</body>
</html>
