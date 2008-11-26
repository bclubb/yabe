<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" CodeBehind="~/CodeBehind/Blog/Options.aspx.cs" Inherits="YABE.Web.CodeBehind.Blog.Options" %>
<%@ Import Namespace="YABE.Web.Extensions"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <h2>Blog Options</h2>
    <%= Html.CustomValidationSummary() %>
    <div class="success-message"><%= ViewData.Model.Message %></div>
    <% using (Html.BeginForm()) %>
    <% { %>
        <table>
            <tr>
                <td><label for="NumberOfPostsToShowOnHomePage">Number of Posts to Show on Home Page:</label></td>
                <td>
                    <%= Html.DropDownList("NumberOfPostsToShowOnHomePage", ViewData.Model.NumberOfPostsToShowOnHomePageList)%>
                </td>
            </tr>
            <tr>
                <td colspan="2"><%= Html.SubmitButton("Save", "Save") %></td>
            </tr>
        </table>
    <% } %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
