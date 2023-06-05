using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AMS
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Button1_Click(object sender, EventArgs e)
        {
                try
                {
                    string query = "select * from UserInfo where Email=@email and Pass=@password";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@email", txtuname.Text);
                    cmd.Parameters.AddWithValue("@password", pass.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Session["SEmail"] = txtuname.Text;
                        Response.Redirect("LoginHome.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Invalid Email or Password!', '', 'error')", true);
                    }

                }
                catch (Exception ex)
                {
                    Response.Write("Exception Occured" + ex);
                }

        }

        protected void HyperLink1_DataBinding(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

    }
}