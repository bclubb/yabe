<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" CodeBehind="~/CodeBehind/Post/Create.aspx.cs" Inherits="YABE.Web.CodeBehind.Post.Create" %>
<asp:content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="sidebar" runat="server">
</asp:content>
<asp:content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <h2>New Post</h2>
    <% using (Html.BeginForm()) %>
    <% { %>
        <label for="post.Title">Title:</label>
        <%= Html.TextBox("post.Title", null, new {id="post-title"}) %>
        <br />
        <label for="post.Slug">Slug:</label>
        <%= Html.TextBox("post.Slug", null, new { id="post-slug" })%>
        <br />
        <label for="post.Text">Text:</label>
        <%= Html.TextArea("post.Title", new { id="post-text"} )%>
        <p>
            <%= Html.SubmitButton("Save", "Save") %>
        </p>
    <% } %>
</asp:content>
<asp:content ID="Content4" ContentPlaceHolderID="footer" runat="server">
</asp:content>
