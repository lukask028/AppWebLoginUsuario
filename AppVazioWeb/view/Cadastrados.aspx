<%@ Page Title="" Language="C#" MasterPageFile="~/control/Page.Master" AutoEventWireup="true" CodeBehind="Cadastrados.aspx.cs" Inherits="AppVazioWeb.view.Cadastrados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="gdvExibir" runat="server" CellPadding="4" GridLines="Horizontal" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" Height="114px" Width="63px" >
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
      
   
    
    <h5>Insira um id:<asp:TextBox ID="txtIdDeletar" placeholder="Digite um Id" runat="server"/></h5>
   
   <h3><asp:Label ID="lblMensagem" runat="server" Text="Resposta" ForeColor="White"></asp:Label></h3>
   
    
      <asp:Button ID="btnDelete" class="registerbtn" Text="Deletar" runat="server" OnClick="btnDeleteId_Click" Width="146px" BackColor="#CC0000"  /> 
      
    
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
    
      <br />

      <asp:Button ID="btnLogout" class="registerbtn" Text="Logout" runat="server" OnClick="btnLogout_Click" BackColor="#CC0000"  />
 
</asp:Content>
