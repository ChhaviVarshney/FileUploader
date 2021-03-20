<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FileUploader.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Register</title>
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
                <h3 class="card-title text-left mb-3">Register</h3>
                <form id="form1" runat="server">
                  <div class="form-group">
                    <label>Username</label>
                     <asp:TextBox ID="txt_name" runat="server" class="form-control p_input"></asp:TextBox>
                  </div>
                  <div class="form-group">
                    <label>Email</label>
                      <asp:TextBox ID="txt_email" runat="server" class="form-control p_input"></asp:TextBox>
                  </div>
                  <div class="form-group">
                    <label>Password</label>
                      <asp:TextBox ID="txt_pass" runat="server" class="form-control p_input"></asp:TextBox>
                    
                  </div>            
                  <div class="text-center">
                      <asp:Button ID="btn_login" runat="server" text="Login" type="submit" class="btn btn-primary btn-block enter-btn" OnClick="btn_login_Click"/>
                      </br>
                      <asp:Label ID="lblmsg" runat="server" ></asp:Label>
                                     </div>
                  
                  <p class="sign-up text-center">Already have an Account?<a href="AdmineLogin.aspx"> Sign In</a></p>
                  <p class="terms">By creating an account you are accepting our<a href="#"> Terms & Conditions</a></p>
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