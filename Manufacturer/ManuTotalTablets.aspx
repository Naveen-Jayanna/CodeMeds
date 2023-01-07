<%@ Page Title="" Language="C#" MasterPageFile="~/Manufacturer.Master" AutoEventWireup="true" CodeBehind="ManuTotalTablets.aspx.cs" Inherits="FinalYearProject.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div>

    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

    <asp:GridView ID="gvTotal" runat="server" 
        class="table table-bordered table-condensed table-hover table-striped" 
        AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Tablet Name" />
            <asp:BoundField DataField="Remaining" HeaderText="Total Tablets left" />

        </Columns>
    </asp:GridView>
    

    </div>


</asp:Content>
