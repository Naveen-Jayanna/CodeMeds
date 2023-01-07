<%@ Page Title="" Language="C#" MasterPageFile="~/Warehouse.Master" AutoEventWireup="true" CodeBehind="WareHome.aspx.cs" Inherits="FinalYearProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>

    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

    <asp:GridView ID="gvRequests" runat="server" class="table table-bordered table-condensed table-hover table-striped">
    </asp:GridView>
    



</div>
</asp:Content>
