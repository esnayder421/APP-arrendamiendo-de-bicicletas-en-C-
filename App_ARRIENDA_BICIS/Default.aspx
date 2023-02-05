<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App_ARRIENDA_BICIS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified" style="width: 66%; height: 185px">
    <tr>
        <td style="width: 338px">ID DE CLIENTE </td>
        <td>
            <asp:TextBox ID="TxtIDcliente" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 338px">NOMBRE COMPLETO</td>
        <td>
            <asp:TextBox ID="TxtNomCliente" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 338px">TELEFONO</td>
        <td>
            <asp:TextBox ID="TxtTelefClieente" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 338px">CORREO</td>
        <td>
            <asp:TextBox ID="TxtCorreoCliente" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 338px">DIRECCION</td>
        <td>
            <asp:TextBox ID="TxtDirecCliente" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="BtnInsertar" runat="server" OnClick="BtnInsertar_Click" Text="INSERTAR" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnActualizas" runat="server" Text="ACTUALIZAR" OnClick="BtnActualizas_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnConsultar" runat="server" OnClick="BtnConsultar_Click" Text="CONSULTAR" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEliminar" runat="server" Text="ELIMINAR" OnClick="BtnEliminar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnListar" runat="server" OnClick="BtnListar_Click" Text="LISTAR" />
&nbsp;&nbsp;
            <asp:Label ID="Lblmensaje" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GVDatos" runat="server" style="margin-left: 0px" Width="717px">
            </asp:GridView>
        </td>
    </tr>
</table>

</asp:Content>
