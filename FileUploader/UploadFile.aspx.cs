using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploader
{

    public partial class UploadFile : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btn_sumit_Click(object sender, EventArgs e)
        {

            if (File_upload.PostedFile != null)
            {
                //try
                string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                //string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                string fileName, fileExt = ".xlss";
                string conn = string.Empty;
                DataTable dtexcel = new DataTable();
                string path = string.Concat(Server.MapPath("~/ExcelFile1/" + File_upload.FileName));
                File_upload.SaveAs(path);
                // Connection String to Excel Workbook  
                if (fileExt.CompareTo(".xls") == 0)
                    conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                else
                    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
                                                                                                                                   //string excelCS = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
                using (OleDbConnection con = new OleDbConnection(conn))
                {
                    //OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", cs);
                    //con.Open();
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel);
                    // Create DbDataReader to Data Worksheet  
                    // DbDataReader dr = cmd.ExecuteReader();
                    // SQL Server Connection String  

                    // Bulk Copy to SQL Server   
                    SqlBulkCopy bulkInsert = new SqlBulkCopy(cs);
                    bulkInsert.DestinationTableName = "Employee";
                    //bulkInsert.WriteToServer(dr);
                    // BindGridview();
                    lblmsg.Text = "Your file uploaded successfully";
                    lblmsg.ForeColor = System.Drawing.Color.Green;
                }
                //}
                //catch (Exception)
                //{
                //    lblmsg.Text = "Your file not uploaded";
                //    lblmsg.ForeColor = System.Drawing.Color.Red;
                //}
            }


            //
            //string fileName, fileExt = ".xlss";
            //string conn = string.Empty;
            //string path = string.Concat(Server.MapPath("~/ExcelFile1/" + File_upload.FileName));
            //DataTable dtexcel = new DataTable();
            //if (fileExt.CompareTo(".xls") == 0)
            //    conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            //else
            //    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            //using (OleDbConnection con = new OleDbConnection(conn))
            //{
            //    try
            //    {
            //        OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
            //        oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
            //    }
            //    catch (Exception ex)
            //    {


            //    }
            //}
        }
    }
}