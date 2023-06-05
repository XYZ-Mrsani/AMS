using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AMS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into UserInfo values('" + txtname.Text + "','" + txtlname.Text + "','" + txtadd.Text + "','" + email.Text + "','" + txtVNum.Text + "','" + txtVType.Text + "','" + txtIN.Text + "','" + txtINum.Text + "','" + pass.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Account Created Successfully!', '', 'success').then(function(){window.location='Login.aspx';});", true);
                con.Close();

            }catch(Exception ex)
            {
                Response.Write("Exception Occured " + ex);
            }
           
        }
    }
}