<%@ Page Title="" Language="C#" MasterPageFile="~/Warehouse.Master" AutoEventWireup="true" CodeBehind="WarehouseToCompany.aspx.cs" Inherits="FinalYearProject.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
<div>
<br />
     <h3>
         <asp:Label ID="lblTabletName" runat="server" Text="Select a Tablet to Request" ></asp:Label>
         </h3>
                <br />
            <td class="style3">
                <asp:DropDownList ID="ddlTablets" ValidationGroup="A" class="form-control" RenderMode="Lightweight" runat = "server"  >
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="ddlTablets" ErrorMessage="Select a tablet" 
                ForeColor="Red" InitialValue="Select One" ValidationGroup="A"></asp:RequiredFieldValidator>
            </td>
            <br />
     <h3>
         <asp:Label ID="lblQuantity" runat="server" Text="Number of boxes required(1 Box equals 20 tablets) " ></asp:Label>
         <br />
          <br />
          <asp:TextBox ID="tbQuantity" class="form-control"  runat="server"  placeholder="Quantity" 
                 ValidationGroup="A"></asp:TextBox>
         </h3>
          <br />
          <br />

         <asp:Button ID="btnGenerate" runat="server" Text="Request"  
             class="btn btn-info btn-md" style="background-color:DodgerBlue;" 
             onclick="btnSubmit_Click" ValidationGroup="A"/>

</div>
<br />
          <br /><br />
          <br />
</body>
</asp:Content>
