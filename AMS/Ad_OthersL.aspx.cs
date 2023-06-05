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
    public partial class Ad_Others : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string role = Request.Form["SelectRole"];
            if(role == "Select a Role")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Select a Role!', '', 'warning')", true);
            }else if(role == "Administration")
            {
                string query = "select * from AdminInfo where Username=@username and Password=@password";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtuname.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["AdUser"] = txtuname.Text;
                    Response.Redirect("Admin_Dashboard.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Invalid Username or Password!', '', 'error')", true);
                }
            }else if(role == "Police")
            {
                string query = "select * from PInfo where Username=@username and Password=@password";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtuname.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["PUser"] = txtuname.Text;
                    Response.Redirect("Ad_U_L_Home.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Invalid Username or Password!', '', 'error')", true);
                }
            }else if(role == "RDA")
            {
                string query = "select * from RDAInfo where Username=@username and Password=@password";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtuname.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["RDAUser"] = txtuname.Text;
                    Response.Redirect("Ad_U_L_Home.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Invalid Username or Password!', '', 'error')", true);
                }
            }else if(role == "Insurance")
            {
                string query = "select * from InInfo where Username=@username and Password=@password";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtuname.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["InUser"] = txtuname.Text;
                    Response.Redirect("Ad_U_L_Home.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Invalid Username or Password!', '', 'error')", true);
                }
            }
        }
    }
}