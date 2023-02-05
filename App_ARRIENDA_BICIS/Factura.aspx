<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="App_ARRIENDA_BICIS.Factura1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="width: 66%; height: 185px">
        <tr>
            <td style="width: 338px">NUMERO DE FACTURA :</td>
            <td>
                <asp:TextBox ID="TxtFactura" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">FECHA :</td>
            <td>
                <asp:TextBox ID="TxtFecha" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">SUB TOTAL:</td>
            <td>
                <asp:TextBox ID="TxtSubT" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">TOTAL : </td>
            <td>
                <asp:TextBox ID="TxtTotal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">IVA:</td>
            <td>
                <asp:TextBox ID="TxtIva" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">ID DEL CLIENTE </td>
            <td>
                <asp:TextBox ID="TxtIdCli" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">ID DEL EMPLEADO</td>
            <td>
                <asp:TextBox ID="TxtIdEmp" runat="server"></asp:TextBox>
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
                <asp:GridView ID="GVDatos" runat="server" style="margin-left: 0px" Width="768px">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
