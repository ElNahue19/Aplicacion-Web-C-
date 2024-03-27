<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP_2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;
            <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido:&nbsp;
            <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
            <br />
            <br />
            Ciudad:&nbsp;
            <asp:DropDownList ID="ddlCiudad" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Temas:&nbsp;&nbsp;&nbsp;
            <asp:CheckBoxList ID="cblTemas" runat="server">
            </asp:CheckBoxList>
            <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="Ver Resumen" Width="96px" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
