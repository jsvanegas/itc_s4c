﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="Tienda.productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body>

    <form id="form1" runat="server">
    <div class="contenedor panel">
        <div class="col-md-4">
            <h2>Gestion de Productos</h2>
            <div class="form-group">
                <label for="cmbCategorias">Categorias:</label>
                <asp:DropDownList runat="server" 
                    ID="cmbCategorias" 
                    CssClass="form-control"
                    AutoPostBack="true"
                    OnSelectedIndexChanged="cmbCategorias_SelectedIndexChanged"
                >
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <div class="input-group">
                    <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control" placeholder="Buscar..." aria-describedby="basic-addon1"/>
                    <span class="input-group-addon" id="basic-addon1">
                        <i class="glyphicon glyphicon-search"></i>
                    </span>
                </div>
            </div>
            <div class="form-group">
                <asp:ListBox runat="server" 
                    ID="lstProductos" 
                    CssClass="form-control"
                    AutoPostBack="true"
                    OnSelectedIndexChanged="lstProductos_SelectedIndexChanged"
                    >
                </asp:ListBox>
            </div>
        </div>
        <div class="col-md-8">
            <h1>Producto Seleccionado</h1>
            <div class="form-group">
                <label for="txtNombreProducto">Nombre Producto:</label>
                <asp:TextBox runat="server" ID="txtNombreProducto" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtDescripcion">Descripcion:</label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtPrecio">Precio:</label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
            </div>
            <div class="text-right">
                <asp:Button Text="Guardar" runat="server" CssClass="btn btn-success" ID="btnGuardar" OnClick="btnGuardar_Click" />
                <asp:Button Text="Eliminar" runat="server" CssClass="btn btn-danger" />
            </div>
        </div>
    </div>


    
        
    </form>
</body>
</html>
