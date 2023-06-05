using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace AMS
{
    public partial class LoginHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVbind();
            }

            if (Session["SEmail"] == null)
            {
                Response.Redirect("Login.aspx");
            }
           Label5.Text = Session["SEmail"].ToString();
            //TextBox1.Text = Session["SEmail"].ToString();
            // txtname.Text = Session["SEmail"].ToString();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GVbind();
        }



        protected void GVbind()
        {
            if (Session["SEmail"] == null) {
                Response.Redirect("Login.aspx");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Query where email='" + Session["SEmail"].ToString() + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Exception occured! " + ex.Message);
                }
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");

            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string location = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string description = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text; 
            
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Query set location='" + location + "', description='" + description + "' where queryId='" + Id + "'", con);
                    int t = cmd.ExecuteNonQuery();
                    if (t > 0)
                    {
                        Response.Write("<script>Data Successfully Updated!</script>");
                        GridView1.EditIndex = -1;
                        GVbind();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Exception occured! " + ex.Message);
                }


        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GVbind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Query where queryId='" + Id + "'", con);
                    int t = cmd.ExecuteNonQuery();
                    if (t > 0)
                    {
                        Response.Write("<script>Data Successfully Deleted!</script>");
                        GridView1.EditIndex = -1;
                        GVbind();
                    }



                }
                catch (Exception ex)
                {
                    Response.Write("Exception occured! " + ex.Message);
                }
        }

       

    }
}