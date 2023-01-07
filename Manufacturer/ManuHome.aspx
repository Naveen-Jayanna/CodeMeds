<%@ Page Title="" Language="C#" MasterPageFile="~/Manufacturer.Master" AutoEventWireup="true" CodeBehind="ManuHome.aspx.cs" Inherits="FinalYearProject.Manufacturer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--<div class="four-grids">
					<div class="col-md-3 four-grid">
						<div class="four-agileits">
							<div class="icon">
								<i class="glyphicon glyphicon-user" aria-hidden="true"></i>
							</div>
							<div class="four-text">
								<h3>User</h3>
								<h4> 24,420  </h4>
								
							</div>
							
						</div>
					</div>
					<div class="col-md-3 four-grid">
						<div class="four-agileinfo">
							<div class="icon">
								<i class="glyphicon glyphicon-list-alt" aria-hidden="true"></i>
							</div>
							<div class="four-text">
								<h3>Clients</h3>
								<h4>15,520</h4>

							</div>
							
						</div>
					</div>
					<div class="col-md-3 four-grid">
						<div class="four-w3ls">
							<div class="icon">
								<i class="glyphicon glyphicon-folder-open" aria-hidden="true"></i>
							</div>
							<div class="four-text">
								<h3>Projects</h3>
								<h4>12,430</h4>
								
							</div>
							
						</div>
					</div>
					<div class="col-md-3 four-grid">
						<div class="four-wthree">
							<div class="icon">
								<i class="glyphicon glyphicon-briefcase" aria-hidden="true"></i>
							</div>
							<div class="four-text">
								<h3>Old Projects</h3>
								<h4>14,430</h4>
								
							</div>
							
						</div>
					</div>
					<div class="clearfix"></div>
				</div>--%>
<body>
<div>
<br />
     <h3>
         <asp:Label ID="lblTabletName" runat="server" Text="Select a Tablet to manufacture" ></asp:Label>
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
         <asp:Label ID="lblQuantity" runat="server" Text="Quantity of Tablets to be generated (in multiples of 20) " ></asp:Label>
         <br />
          <br />
          <asp:TextBox ID="tbQuantity" class="form-control"  runat="server"  placeholder="Quantity" 
                 ValidationGroup="A"></asp:TextBox>
         </h3>
          <br />
          <br />

         <asp:Button ID="btnGenerate" runat="server" Text="Generate"  
             class="btn btn-info btn-md" style="background-color:DodgerBlue;" 
             onclick="btnSubmit_Click" ValidationGroup="A"/>

</div>
<br />
          <br /><br />
          <br />
</body>


</asp:Content>
