<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="WebApp_animAX.Blocs.ManageUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="userGv" runat="server"></asp:GridView>
    Manage User
       
    <br />
    Update User
       
    <br />
    <asp:Label ID="lbUpdateUid" runat="server" Text="User ID"></asp:Label>
    <asp:TextBox ID="tbUpdateUid" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbUpdateUname" runat="server" Text="User Name"></asp:Label>
    <asp:TextBox ID="tbUpdateUname" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbUpdatePassword" runat="server" Text="User Password"></asp:Label>
    <asp:TextBox ID="tbUpdatePassword" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbUpdateRole" runat="server" Text="User Role"></asp:Label>
    <asp:TextBox ID="tbUpdateRole" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnUpdate" OnClick="btnUpdate_Click" runat="server" Text="Update" />
    <asp:Label ID="lbUpdateError" runat="server" Text=""></asp:Label>

    <br />
    Remove User
       
    <br />
    <asp:Label ID="lbDeleteUid" runat="server" Text="User ID"></asp:Label>
    <asp:TextBox ID="tbDeleteUid" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnDelete" OnClick="btnDelete_Click" runat="server" Text="Remove" />
    <asp:Label ID="lbDeleteError" runat="server" Text=""></asp:Label>
</asp:Content>
