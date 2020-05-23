<%@ Page Title="" Language="C#" MasterPageFile="~/login.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Numl_Thesis_Examiner_System.login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="forms" runat="server">
    		<div class="d-flex justify-content-center h-100">
			<div class="user_card">
				<div class="d-flex justify-content-center">
					<div class="brand_logo_container">
						<img src="dist/img/logo.png" class="brand_logo" alt="Logo">
					</div>
				</div>
				<div class="d-flex justify-content-center form_container">
					<form runat="server">
						<div class="input-group mb-3">
							<div class="input-group-append">
								<span class="input-group-text"><i class="fas fa-user"></i></span>
							</div>
                    <asp:textbox ID="email" class="form-control input_user" placeholder="Email" runat="server"></asp:textbox>
						</div>                        
						<div class="input-group mb-2">
							<div class="input-group-append">
								<span class="input-group-text"><i class="fas fa-key"></i></span>
							</div>
                    <asp:textbox ID="password" class="form-control input_user" placeholder="Password" runat="server"></asp:textbox>
						</div>
                        <br />
                        <asp:Label ID="alert" CssClass="text-center alert alert-danger" visible="false" runat="server" Text="Label"></asp:Label>
						<div class="form-group">
							<div class="custom-control custom-checkbox">
								<input type="checkbox" class="custom-control-input" id="customControlInline">
								<label class="custom-control-label" for="customControlInline">Remember me</label>
							</div>
						</div>
							<div class="d-flex justify-content-center mt-3 login_container">
                                <asp:button ID="login" runat="server" class="btn login_btn" text="Login" OnClick="login_Click" />
				   </div>
					</form>
				</div>
		
				<div class="mt-4">
					<div class="d-flex justify-content-center links">
						Don't have an account? <a href="#" class="ml-2">Sign Up</a>
					</div>
					<div class="d-flex justify-content-center links">
						<a href="#">Forgot your password?</a>
					</div>
				</div>
			</div>
    </div>
</asp:Content>
