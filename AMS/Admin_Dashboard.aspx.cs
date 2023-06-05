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
    public partial class Admin_Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdUser"] == null)
            {
                Response.Redirect("Ad_OthersL.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    showdata();
                    showdata2();
                    showdata3();
                }
            }
        }

        protected void showdata()
        {
            /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select Id,Username,Password from PInfo;";
            query += "select Id,Username,Password from RDAInfo;";
            query += "select Id,Username,Password from InInfo;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

                GridView2.DataSource = ds.Tables[1];
                GridView2.DataBind();

                GridView3.DataSource = ds.Tables[2];
                GridView3.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }*/
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select Id,Username,Password from PInfo;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void showdata2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select Id,Username,Password from RDAInfo;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void showdata3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select Id,Username,Password from InInfo;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView3.DataSource = dt;
                    GridView3.DataBind();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            showdata();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            showdata();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("lblId") as Label;
            TextBox uname = GridView1.Rows[e.RowIndex].FindControl("txtuname") as TextBox;
            TextBox pass = GridView1.Rows[e.RowIndex].FindControl("txtpass") as TextBox;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "update PInfo set Username='" + uname.Text + "',Password='" + pass.Text + "' where Id="+int.Parse(id.Text)+"";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            showdata();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("lblId") as Label;
            TextBox uname = GridView1.Rows[e.RowIndex].FindControl("txtuname") as TextBox;
            TextBox pass = GridView1.Rows[e.RowIndex].FindControl("txtpass") as TextBox;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete from PInfo where Id="+int.Parse(id.Text)+"";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            showdata();
        }

        protected void btnnew_Click(object sender, EventArgs e)
        {
            Session["Police"] = Label1.Text;
            Response.Redirect("AddNew_User.aspx");
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            showdata2();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            showdata2();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView2.Rows[e.RowIndex].FindControl("lblId") as Label;
            TextBox uname = GridView2.Rows[e.RowIndex].FindControl("txtuname") as TextBox;
            TextBox pass = GridView2.Rows[e.RowIndex].FindControl("txtpass") as TextBox;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "update RDAInfo set Username='" + uname.Text + "',Password='" + pass.Text + "' where Id=" + int.Parse(id.Text) + "";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView2.EditIndex = -1;
            showdata2();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView2.Rows[e.RowIndex].FindControl("lblId") as Label;
            TextBox uname = GridView2.Rows[e.RowIndex].FindControl("txtuname") as TextBox;
            TextBox pass = GridView2.Rows[e.RowIndex].FindControl("txtpass") as TextBox;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete from RDAInfo where Id=" + int.Parse(id.Text) + "";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView2.EditIndex = -1;
            showdata2();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["RDA"] = Label2.Text;
            Response.Redirect("AddNew_User.aspx");
        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            showdata3();
        }

        protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView3.EditIndex = -1;
            showdata3();
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView3.Rows[e.RowIndex].FindControl("lblId") as Label;
            TextBox uname = GridView3.Rows[e.RowIndex].FindControl("txtuname") as TextBox;
            TextBox pass = GridView3.Rows[e.RowIndex].FindControl("txtpass") as TextBox;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "update InInfo set Username='" + uname.Text + "',Password='" + pass.Text + "' where Id=" + int.Parse(id.Text) + "";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView3.EditIndex = -1;
            showdata3();
        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView3.Rows[e.RowIndex].FindControl("lblId") as Label;
            TextBox uname = GridView3.Rows[e.RowIndex].FindControl("txtuname") as TextBox;
            TextBox pass = GridView3.Rows[e.RowIndex].FindControl("txtpass") as TextBox;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete from InInfo where Id=" + int.Parse(id.Text) + "";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView3.EditIndex = -1;
            showdata3();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Insurance"] = Label3.Text;
            Response.Redirect("AddNew_User.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Ad_OthersL.aspx");
        }
    }
}