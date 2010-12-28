<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="snot.model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    
    <% foreach (Note note in (List<Note>)ViewData["notes"]) { %>
    <h1><%: note.Title %></h1>
    <i>created on <%: note.DateCreated.ToShortDateString() %> by <%: note.Author.UserName %></i><br/>
    <% foreach (TaggedValue t in note.Tags) { %>
        [<%: t.Tag.Text %>: <% foreach (string v in t.Values)
                               { %> <%: v %> <% } %>]
    <br/>
    <% } %>
    <br/>
    <% foreach (TopicAppearance ta in note.Topics) { %>
    <h2><%: "".PadLeft(ta.Level, '=') + ta.Topic.Text %></h2>
    <% foreach (Idea i in ta.Ideas) { %>
    *<%: i.Text %><br/>
    <% } %>
    <% } %>
    <hr/>
    <% } %>
    
</asp:Content>
