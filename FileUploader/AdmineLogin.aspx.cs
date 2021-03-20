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
    public partial class AdmineLogin : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btn_login_Click(object sender, EventArgs e)

        {
            // string encPass = Encrypt("sdhjsakdhahd");


            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("sp_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emailid", txt_email.Text);
                cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (dt.Rows.Count > 0)
                {

                    Session["userid"] = dt.Rows[0][0].ToString();
                    Session["role_id"] = dt.Rows[0][3].ToString();
                    Response.Redirect("main.aspx");
                    Session.RemoveAll();


                }
                else
                {
                    lblmsg.Text = "You're username and word is incorrect";
                    lblmsg.ForeColor = System.Drawing.Color.Red;

                }
                //}
                //else
                //{
                //    lblmsg.Text = "You're not a Admin";
                //    lblmsg.ForeColor = System.Drawing.Color.Red;
                //}

            }
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