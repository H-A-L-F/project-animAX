<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebApp_animAX.Blocs.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView id="gvCart" runat="server"></asp:GridView>
    <asp:Label ID="lbError" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button runat="server" Text="Subscribe" ID="buyBtn" OnClick="buyBtn_Click" />
</asp:Content>
