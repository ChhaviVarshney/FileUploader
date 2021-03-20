<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdmineLogin.aspx.cs" Inherits="FileUploader.AdmineLogin" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Admine Login</title>
    <!-- plugins:css -->
    <link rel="stylesheet" href="Content/vendors/mdi/css/materialdesignicons.min.css">
    <link rel="stylesheet" href="Content/vendors/css/vendor.bundle.base.css">
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <!-- endinject -->
    <!-- Layout styles -->
    <link rel="stylesheet" href="Content/css/style.css">
    <!-- End layout styles -->
    <link rel="shortcut icon"  />
  </head>
  <body>
    <div class="container-scroller">
      <div class="container-fluid page-body-wrapper full-page-wrapper">
        <div class="row w-100 m-0">
          <div class="content-wrapper full-page-wrapper d-flex align-items-center auth login-bg">
            <div class="card col-lg-4 mx-auto">
              <div class="card-body px-5 py-5">
                <h3 class="card-title text-left mb-3">Login</h3>
                <form id="form1" runat="server">
                  <div class="form-group">
                    <label>Email ID*</label>
                    <asp:TextBox ID="txt_email" runat="server" class="form-control p_input"></asp:TextBox>
                  </div>
                  <div class="form-group">
                    <label>Password *</label>
                    <asp:TextBox ID="txt_pass" runat="server"  class="form-control p_input"></asp:TextBox>
                  </div>
                  <div class="form-group d-flex align-items-center justify-content-between">
                   <%-- <div class="form-check">
                      <label class="form-check-label">
                          <asp:CheckBox runat="server" class="form-check-input"/> Remember me </label>     
                    </div>--%>
                    <a  class="forgot-pass">Forgot password</a>
                  </div>
                  <div class="text-center">
                      <asp:Button ID="btn_login" runat="server" text="Login" type="submit" class="btn btn-primary btn-block enter-btn" OnClick="btn_login_Click"/>
                      </br>
                      <asp:Label ID="lblmsg" runat="server" ></asp:Label>
                                     </div>
                  <%--<div class="d-flex">
                    <button class="btn btn-facebook mr-2 col">
                      <i class="mdi mdi-facebook"></i> Facebook </button>
                    <button class="btn btn-google col">
                      <i class="mdi mdi-google-plus"></i> Google plus </button>
                  </div>--%>
                  <p class="sign-up">Don't have an Account?<a href="Registration.aspx"> Sign Up</a></p>
                </form>
              </div>
            </div>
          </div>
          <!-- content-wrapper ends -->
        </div>
        <!-- row ends -->
      </div>
      <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src="Content/vendors/js/vendor.bundle.base.js"></script>
    <!-- endinject -->
    <!-- Plugin js for this page -->
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <script src="Content/js/off-canvas.js"></script>
    <script src="Content/js/hoverable-collapse.js"></script>
    <script src="Content/js/misc.js"></script>
    <script src="Content/js/settings.js"></script>
    <script src="Content/js/todolist.js"></script>
    <!-- endinject -->
  </body>
</html>