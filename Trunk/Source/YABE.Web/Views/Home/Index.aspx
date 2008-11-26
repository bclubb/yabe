<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" CodeBehind="~/CodeBehind/Home/Index.aspx.cs" Inherits="YABE.Web.CodeBehind.Home.Index" %>
<asp:content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <h2>Home</h2>
    TODO: Show some Posts
</asp:content>
<asp:content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:content>
<asp:content id="sidbar" contentplaceholderid="sidebar" runat="server">
    <% Html.RenderPartial("~/Views/Shared/SideBar.ascx", ViewData); %>
</asp:content>
