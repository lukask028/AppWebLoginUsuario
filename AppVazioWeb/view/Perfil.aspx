<%@ Page Title="" Language="C#" MasterPageFile="~/control/Page.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AppVazioWeb.view.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h1 style="color: white;"> Exibição das Informações

    Bem vindo - <asp:Label ID="lblBemvindo" runat="server" ></asp:Label>
       </h1>
    <table style="color: white;">
        <tr>
            <td>ID Aluno:</td>
            <td>
                <asp:Label runat="server" ID="lblId" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td>
                <asp:Label runat="server" ID="lblEmail" Text=""></asp:Label>
            </td>
        </tr>

    </table>

      <asp:Button ID="btnCadastrados" class="registerbtn" Text="Cadastrados" runat="server" OnClick="btnCadastrados_Click"  />
    <br />
    <br />

      <asp:Button ID="btnLogout" class="registerbtn" Text="Logout" runat="server" OnClick="btnLogout_Click" BackColor="#CC0000"  />
</asp:Content>
