<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bicicleta.aspx.cs" Inherits="App_ARRIENDA_BICIS.Bicicleta1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="width: 66%; height: 185px">
        <tr>
            <td style="width: 338px">CODIGO DE BICICLETA :</td>
            <td>
                <asp:TextBox ID="TxtCodbici" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">MARCA :</td>
            <td>
                <asp:TextBox ID="TxtMarca" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">VALOR HORA:</td>
            <td>
                <asp:TextBox ID="TxtValor" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">CANTIDAD : </td>
            <td>
                <asp:TextBox ID="TxtCantidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 338px">TIPO :</td>
            <td>
                <asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox>
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
