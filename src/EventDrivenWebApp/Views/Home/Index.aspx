<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    
    
    <form method="post" action="<%= Html.AttributeEncode(Url.Action("SubmitOrder", "Home")) %>">
        <input type="submit" value="Submit" />
    </form>

    
</asp:Content>
