<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp_animAX.Blocs.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="animeGv" runat="server"></asp:GridView>

    <div id="cartView" runat="server">
        Add To Cart
               
        <br />
        <asp:Label ID="lbCartAnimeId" runat="server" Text="ID Anime"></asp:Label>
        <asp:TextBox ID="tbCartAnimeId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbCartAnimeQuantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="tbCartAnimeQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addCart" OnClick="addCart_Click" runat="server" Text="Add To Cart" />
        <br />
        <asp:Label ID="lbCartError" runat="server" Text=""></asp:Label>
        <br />
    </div>

    <div id="adminView" runat="server">
        Insert New Anime
       
        <br />
        <asp:Label ID="lbInsertAnimeTitle" runat="server" Text="Anime Title"></asp:Label>
        <asp:TextBox ID="tbInsertAnimeName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbInsertSubscriptionPrice" runat="server" Text="Subscription Price"></asp:Label>
        <asp:TextBox ID="tbInsertSubscriptionPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="createBtn" OnClick="createBtn_Click" runat="server" Text="Create" />
        <asp:Label ID="lbInsertError" runat="server" Text=""></asp:Label>

        <br />
        Update View
       
        <br />

        <asp:Label ID="lbUpdateAnimeId" runat="server" Text="Anime ID"></asp:Label>
        <asp:TextBox ID="tbAnimeUpdateId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbUpdateAnimeTitle" runat="server" Text="Anime Title"></asp:Label>
        <asp:TextBox ID="tbUpdateAnimeTitle" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbUpdateSubscriptionPrice" runat="server" Text="Subscription Price"></asp:Label>
        <asp:TextBox ID="tbUpdateSubscriptionPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="updateBtn" OnClick="updateBtn_Click" runat="server" Text="Update" />
        <asp:Label ID="lbUpdateError" runat="server" Text=""></asp:Label>

        <br />
        Delete Anime
       
        <br />
        <asp:Label ID="lbDeleteAnimeId" runat="server" Text="Anime ID"></asp:Label>
        <asp:TextBox ID="tbDeleteAnimeId" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="deleteBtn" OnClick="deleteBtn_Click" runat="server" Text="Delete" />
        <asp:Label ID="lbDeleteError" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
