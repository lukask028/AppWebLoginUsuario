<%@ Page Title="" Language="C#" MasterPageFile="~/control/Page.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppVazioWeb.view.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 36px;
        }
        .auto-style2 {
            padding: 16px;
            background-color: white;
            height: 806px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Inicio do Código Content2 -->
<!-- Fim do Código Content2 -->
      <div class="auto-style2">
  <h1>Login - <asp:Label ID="lblMensagem" runat="server" Text="Resposta"></asp:Label></h1>
  <p>Digite Suas Informações.</p>
  <hr>

  <label for="email"><b>Email</b></label>    
      <asp:TextBox ID="txbEmail" placeholder="Digite seu e-mail" runat="server" CssClass="auto-style1" />

  <label for="psw"><b>Senha</b></label>    
      <asp:TextBox ID="txbSenha" placeholder="Digite sua Senha" runat="server" type="password" />

      <asp:Button ID="btnLogin" class="registerbtn" Text="Entrar" runat="server" OnClick="btnLogin_Click"  />
</div>
</asp:Content>
