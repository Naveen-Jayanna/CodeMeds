<%@ Page Title="" Language="C#" MasterPageFile="~/Warehouse.Master" AutoEventWireup="true" CodeBehind="WarehouseRequests.aspx.cs" Inherits="FinalYearProject.WarehouseRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div>

    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

    <asp:GridView ID="gvRequests" runat="server" 
        class="table table-bordered table-condensed table-hover table-striped" 
        AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Request_Id" HeaderText="Request ID" />
            <asp:BoundField DataField="Pharmacy_Id" HeaderText="Pharmacy ID" />
            <asp:BoundField DataField="Tablet_Name" HeaderText="Tablet Name" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:TemplateField HeaderText="Grant Request">
                <ItemTemplate>
                    <asp:LinkButton ID="btnGrant" runat="server" 
                        CommandArgument='<%# Eval("Request_Id") %>' onclick="btnGrant_Click">Grant</asp:LinkButton>
                </ItemTemplate>

            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    



</div>


</asp:Content>
