<%@ Page Title="" Language="C#" MasterPageFile="~/Warehouse.Master" AutoEventWireup="true" CodeBehind="WarehouseResponse.aspx.cs" Inherits="FinalYearProject.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div>

    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

    <asp:GridView ID="gvHistory" runat="server" 
        class="table table-bordered table-condensed table-hover table-striped" 
        AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Request_Id" HeaderText="Request ID" />
            <asp:BoundField DataField="Tablet_Name" HeaderText="Tablet Name" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="Status" HeaderText="Status(0=Pending 1=Granted)" />

        </Columns>
    </asp:GridView>
    

    </div>

</asp:Content>
