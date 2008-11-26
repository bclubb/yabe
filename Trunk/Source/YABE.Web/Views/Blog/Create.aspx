<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" CodeBehind="~/CodeBehind/Blog/Create.aspx.cs" Inherits="YABE.Web.CodeBehind.Blog.Create" %>
<%@ Import Namespace="YABE.Web.Extensions"%>
<%@ Import Namespace="System.Web.Mvc.Html"%>
<asp:content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <h2>New Blog</h2>
    
    <%= Html.CustomValidationSummary() %>
    
    <% using (Html.BeginForm()) %>
    <% { %>
        <table>
            <tr>
                <td><label for="blog.host">Host</label></td>
                <td>
                    <%=Html.TextBox("blog.host")%>
                    <%=Html.ValidationMessage("blog.host", "*")%>
                </td>
            </tr>
            <tr>
                <td colspan="2"><%=Html.SubmitButton("Submit", "Submit")%></td>
            </tr>
        </table>
    <% }%>
</asp:content>
<asp:content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:content>
