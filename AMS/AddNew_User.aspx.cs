using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AMS
{
    public partial class AddNew_User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdUser"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (Session["Police"] != null)
                {
                    sessionlbl.Text = Session["Police"].ToString();
                }
                else if (Session["RDA"] != null)
                {
                    sessionlbl.Text = Session["RDA"].ToString();
                }
                else
                {
                    sessionlbl.Text = Session["Insurance"].ToString();
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Dashboard.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            if (sessionlbl.Text == "Police")
            {
                string query = "Insert into PInfo (Username,Password) values('" + txtuname.Text + "','" + txtpass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('New User Added Successfully!', '', 'success')", true);
                    con.Close();
                }
                catch(Exception ex)
                {
                    Response.Write(ex);
                }
            }
            if(sessionlbl.Text == "RDA")
            {
                string query = "Insert into RDAInfo (Username,Password) values('" + txtuname.Text + "','" + txtpass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('New User Added Successfully!', '', 'success')", true);
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }

            if(sessionlbl.Text == "Insurance")
            {
                string query = "Insert into InInfo (Username,Password) values('" + txtuname.Text + "','" + txtpass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('New User Added Successfully!', '', 'success')", true);
                    con.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
        }
    }
}