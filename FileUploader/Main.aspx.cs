using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploader
{
    public partial class Main : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(!IsPostBack)
            {
                BindData();
            }

        }
        protected void BindData()
        {  
                using (SqlConnection SqlCon = new SqlConnection(cs))
                {

                    SqlCon.Open();
                    SqlDataAdapter SqlDa = new SqlDataAdapter("select * from Employee", SqlCon);
                    DataTable dt = new DataTable();
                    SqlDa.Fill(dt);
                    Grid_view.DataSource = dt;
                    Grid_view.DataBind();

                }
        }
        protected void Grid_view_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid_view.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void Btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string find = "select * from Employee where(Address like '%' + @Address + '%' or Designation like '%' + @Designation + '%')";
            SqlCommand SqlCon = new SqlCommand(find, con);
            //SqlCon.Parameters.Add("@name", SqlDbType.NVarChar).Value = Btn_Search.Text;
            //SqlCon.Parameters.Add("@city", SqlDbType.NVarChar).Value = Btn_Search.Text;
            SqlCon.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txt_search.Text;
            SqlCon.Parameters.Add("@Designation", SqlDbType.NVarChar).Value = txt_search.Text;

            con.Open();
            SqlCon.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = SqlCon;
            DataSet ds = new DataSet();
            da.Fill(ds, "Name");
            da.Fill(ds, "City");
            da.Fill(ds, "Address");
            da.Fill(ds, "Designation");
            Grid_view.DataSource = ds;
            Grid_view.DataBind();
            con.Close();   




        }
    }
}