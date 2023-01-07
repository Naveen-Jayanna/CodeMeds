<%@ Page Title="" Language="C#" MasterPageFile="~/Pharmacy.Master" AutoEventWireup="true" CodeBehind="PharRequests.aspx.cs" Inherits="FinalYearProject.PharRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div>

    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

    <asp:GridView ID="gvRequests" runat="server" class="table table-bordered table-condensed table-hover table-striped">
    </asp:GridView>
    



</div>
</asp:Content>