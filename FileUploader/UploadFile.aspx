<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadFile.aspx.cs" Inherits="FileUploader.UploadFile" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Uploader</title>
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
                <h3 class="card-title text-left mb-3">Upload file</h3>
                <form id="form1" runat="server">
                  <div class="form-group">
                    <label>Upload file</label>
                     <asp:FileUpload ID="File_upload" runat="server" />
                  </div>
                             
                  <div class="text-center">
                      <asp:Button ID="btn_sumit" runat="server" Text="Upload" class="btn btn-primary btn-block enter-btn" OnClick= "btn_sumit_Click"/>
                      
                      <asp:Label ID="lblmsg" runat="server" ></asp:Label>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <script src="Content/vendors/js/vendor.bundle.base.js"></script>
    <script src="Content/js/off-canvas.js"></script>
    <script src="Content/js/hoverable-collapse.js"></script>
    <script src="Content/js/misc.js"></script>
    <script src="Content/js/settings.js"></script>
    <script src="Content/js/todolist.js"></script>
  </body>
</html>
