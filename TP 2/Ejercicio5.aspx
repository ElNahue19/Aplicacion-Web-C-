<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP_2.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Elija su configuración</p>
        <p>
            &nbsp;</p>
        <p>
            Seleccione la cantidad de memoria:</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="ddlMemoria" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Seleccione los accesorios:<asp:CheckBoxList ID="cblAccesorios" runat="server">
            </asp:CheckBoxList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnPrecio" runat="server" OnClick="btnPrecio_Click" Text="Calcular Precio" />
        </p>
        <p>
            <asp:Label ID="lblFinal" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
