using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace FileUploader
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {

            //string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(cs))
            //{

            //SqlCommand cmd = new SqlCommand("sp_loginInfo", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@pLoginName", txt_name.Text);
            //cmd.Parameters.AddWithValue("@pEmail", txt_email.Text); 
            //cmd.Parameters.AddWithValue("@pPassword", txt_pass.Text);
            //con.Open();
            //    int k = cmd.ExecuteNonQuery();
            //    if (k != 0)
            //    {
            //    Response.Redirect("AdmineLogin.aspx");
            //    }
            //    con.Close();
            //}

            string Username = txt_name.Text.ToString();
            string Email = txt_email.Text.ToString();
            String password = txt_pass.Text.ToString();
              string connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
             String passwords = encryption(password);
            //Get the encrypt the password by using the class  
            //string pass = encryption(password);
            //lblmsg.Text = pass;
            //Check whether the UseName and password are Empty  
            if (Email.Length > 0 && password.Length > 0)
            {
                //creating the connection string              
              
               
                con.Open();
                // Check whether the Username Found in the Existing DB  
                //String search = "SELECT * FROM loginInfo_Tbl WHERE (Email = '" + Email + "');";
                SqlCommand cmds = new SqlCommand("SELECT * FROM loginInfo_Tbl WHERE(Email = '" + Email + "'); ", con);
                //cmds.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqldrs = cmds.ExecuteReader();
                if (sqldrs.Read())
                {
                    String passed = (string)sqldrs["Password"];
                    lblmsg.Text = "Username Already Taken";
                }
                else
                {
                    try
                    {

                        // if the Username not found create the new user accound  
        //                INSERT INTO dbo.[loginInfo_Tbl](LoginName, Email, PasswordHash)
        //VALUES(@pLoginName, @PEmail, @pPassword)
                        string sql = "INSERT INTO loginInfo_Tbl (LoginName, Email, PasswordHash) VALUES ('" + Username + "','" + Email + "','" + passwords + "');";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        //SqlCommand cmd = new SqlCommand("sp_loginInfo", con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@pLoginName", txt_name.Text);
                        //cmd.Parameters.AddWithValue("@pEmail", txt_email.Text);
                        //cmd.Parameters.AddWithValue("@pPassword", passwords);
                        //con.Open();
                         cmd.ExecuteNonQuery();
                        //if (k != 0)
                        //{
                            String Message = "saved Successfully";
                            lblmsg.Text = Message.ToString();
                            txt_name.Text = "";
                            txt_email.Text = "";
                            txt_pass.Text = "";
                            Response.Redirect("AdmineLogin.aspx");
                       // }
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        lblmsg.Text = ex.ToString();
                    }
                    con.Close();
                }
            }

            else
            {
                String Message = "Username or Password is empty";
                lblmsg.Text = Message.ToString();
            }
        }
            public static string encryption(String password)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] encrypt;
                UTF8Encoding encode = new UTF8Encoding();
                //encrypt the given password string into Encrypted data  
                encrypt = md5.ComputeHash(encode.GetBytes(password));
                StringBuilder encryptdata = new StringBuilder();
                //Create a new string by using the encrypted data  
                for (int i = 0; i < encrypt.Length; i++)
                {
                    encryptdata.Append(encrypt[i].ToString());
                }
                return encryptdata.ToString();
            }

            //public static string Encrypt(string stringToEncrypt)
            //{
            //    MD5 md5 = new MD5CryptoServiceProvider();

            //    //compute hash from the bytes of text  
            //    md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(stringToEncrypt));

            //    //get hash result after compute it  
            //    byte[] result = md5.Hash;

            //    StringBuilder strBuilder = new StringBuilder();
            //    for (int i = 0; i < result.Length; i++)
            //    {
            //        //change it into 2 hexadecimal digits  
            //        //for each byte  
            //        strBuilder.Append(result[i].ToString("x2"));
            //    }

            //    return strBuilder.ToString();
            //}
        }
    }