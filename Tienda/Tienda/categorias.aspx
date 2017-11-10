<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categorias.aspx.cs" Inherits="Tienda.categorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div>
        <h1>Gestion de Categorias</h1>
    </div>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:TextBox runat="server" ID="txtBuscar" />
                <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
            </div>
            <asp:ListBox runat="server" ID="lstCategorias">   
            </asp:ListBox>
        </div>
        <div>
            <div>
                <label for="txtNombreCategoria">Nombre Categoria:</label>
                <asp:TextBox runat="server" ID="txtNombreCategoria" />
            </div>
            <div>
                <label for="txtImagen">URL Imagen:</label>
                <asp:TextBox runat="server" ID="txtImagen" />
            </div>
            <div>
                <asp:Button Text="Guardar" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" />
                <asp:Button Text="Eliminar" ID="btnEliminar" runat="server" />
            </div>

        </div>
    </form>
</body>
</html>
