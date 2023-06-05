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
    public partial class Ad_U_L_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVbind();
            }
            if (Session["PUser"] == null && Session["RDAUser"] == null && Session["InUser"] == null)
            {
                Response.Redirect("Ad_OthersL.aspx");
                
            }
            if (Session["PUser"] != null)
            {
                Label1.Text = Session["PUser"].ToString();
            }
            else if (Session["RDAUser"] != null)
            {
                Label1.Text = Session["RDAUser"].ToString();
            }
            else if (Session["InUser"] != null)
            {
                Label1.Text = Session["InUser"].ToString();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Ad_OthersL.aspx");
        }

        protected void GVbind()
        {
           
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Query", con);
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

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GVbind();
        }
    }
}