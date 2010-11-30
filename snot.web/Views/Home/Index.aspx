<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="snot.model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        <% foreach (snot.model.Note note in (List<snot.model.Note>)ViewData["notes"]) { %>
        <%: note.Title %><br/>
        <% } %>
    </p>
</asp:Content>
