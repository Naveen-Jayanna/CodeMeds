<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FinalYearProject.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
    <form id="form1" runat="server">
    <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Login Page</title>

    <!-- HTML5 shim, for IE6-8 support of HTML5 elements. All other JS at the end of file. -->
    <!--[if lt IE 9]>
      <script src="js/html5shiv.js"></script>
      <script src="js/respond.min.js"></script>
    <![endif]-->

    <!--headerIncludes-->

	<!-- css files -->
	<link rel="stylesheet" href="./bundles/css/style.css" type="text/css" media="all"> <!-- Style-CSS --> 
	<link href="./bundles/css/font-awesome.min.css" rel="stylesheet" type="text/css" media="all">
	<!-- //css files -->
	
	<!-- google fonts -->
	<link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">
	<!-- //google fonts -->
	
</head>

<body>

    <div id="page" class="page"><div class="signupform">
	<div class="container">
		<!-- main content -->
		<div class="agile_info">
			<div class="w3l_form editContent">
				<h1 class="editContent">A Step In The Right Direction</h1>
				<p class="editContent" style="outline: none; cursor: inherit; outline-offset: -2px; color: rgb(102, 102, 102); font-size: 16px; background-color: rgba(0, 0, 0, 0); font-family: Raleway, sans-serif;">A simple service to authenticate medicine</p>
				<img src="bundles/images/image.jpg" alt="">
			</div>
			<div class="w3_info editContent" style="outline: rgba(233, 94, 94, 0.5) solid 2px; outline-offset: -2px; cursor: pointer;">
				<h2 class="editContent">Login to your Account</h2>
				<p class="editContent">Enter your details to login.</p>
				<form action="#" method="post">
					<div class="editContent">
						<label class="editContent" style="outline: none; cursor: inherit;">Email Address</label>
						<div class="input-group editContent">
							<span class="fa fa-envelope" aria-hidden="true" style="outline: none; cursor: inherit;"></span>
							<%--<input type="email" placeholder="Enter Your Email" required=""> --%>
                            <asp:TextBox ID="tbemail" runat="server" class="email" type="email"  placeholder="Email"></asp:TextBox>
						</div>
					</div>
					<div class="editContent">
						<label class="editContent" style="outline: none; cursor: inherit;">Password</label>
						<div class="input-group editContent">
							<span class="fa fa-lock" aria-hidden="true" style="outline: none; cursor: inherit;"></span>
							<%--<input type="Password" placeholder="Enter Password" required="">--%>
                            <asp:TextBox ID="tbpassword" runat="server" class="pass" type="password"  placeholder="Password"></asp:TextBox>
						</div> 
					</div> 
					<div class="login-check">
						 
					</div>						
					<%--	<button class="btn btn-danger btn-block" type="submit">Login</button>   --%>
                        <asp:Button  class="btn btn-default" ID="btnSubmit" runat="server" Text="Submit" 
                    onclick="btnSubmit_Click" ValidationGroup="A" 
                        onclientclick="btnSubmit_Click" />             
				</form>
				<p class="account editContent">By clicking login, you agree to our <a href="#">Terms &amp; Conditions!</a></p>
				
			</div>
		</div>
		<!-- //main content -->
	</div>

</div></div>
	


    
    </form>
</body></html>


