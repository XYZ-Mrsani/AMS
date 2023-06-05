using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace AMS
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SEmail"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            showdata();
            Button2.Visible = false;
            Button3.Visible = false;
            Label3.Text = Session["SEmail"].ToString();
        }

        protected void showdata()
        {
            Label1.Text = Session["SEmail"].ToString();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from UserInfo Where Email='"+Label1.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    lblname.Text = sdr["Fname"].ToString();
                    lbllname.Text = sdr["Lname"].ToString();
                    lbladd.Text = sdr["Address"].ToString();
                    lblmail.Text = sdr["Email"].ToString();
                    lblvnum.Text = sdr["Vnumber"].ToString();
                    lblvtype.Text = sdr["Vtype"].ToString();
                    lblin.Text = sdr["Iname"].ToString();
                    lblinum.Text = sdr["Inumber"].ToString();

                }
                Label2.Text = lblname.Text + " " + lbllname.Text;
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
                con.Close();
            }

            /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from UserInfo Where Email='" + Label1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    lblname.Text = dt.Rows[0]["Fname"].ToString();
                }

                
            }catch(Exception ex)
            {
                Response.Write(ex);
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* string name = txtname.Text;
             string lname = txtlname.Text;
             string add = txtadd.Text;
             string vnum = txtvnumber.Text;
             string vtype = txtvtype.Text;
             string iname = txtIn.Text;
             string inum = txtInum.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
             con.Open();
             string query = "UPDATE UserInfo set Fname='"+name+"', Lname='"+lname+"', Address='"+add+"', Vnumber='"+vnum+"', Vtype='"+vtype+"', Iname='"+iname+"', Inumber='"+inum+"' where Email='saniyayt2021@gmail.com'";
             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 cmd.ExecuteNonQuery();
                 Response.Redirect("LoginHome.aspx");
                 //ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Account Updated Successfully!', '', 'success')", true);

             }
             catch(Exception ex)
             {
                 Response.Write(ex);
             }
             con.Close();
             /*Session["name"] = txtname.Text;
             Response.Redirect("LoginHome.aspx");*/
            /* Session["Fname"] = lblname.Text;
             Session["Lname"] = lbllname.Text;
             Session["Add"] = lbladd.Text;
             Session["Email"] = lblmail.Text;
             Session["Vnumber"] = lblvnum.Text;
             Session["Vtype"] = lblvtype.Text;
             Session["Iname"] = lblin.Text;
             Session["Inum"] = lblinum.Text;

             Response.Redirect("Update_Profile.aspx");*/
            TextBox1.Text = lblname.Text;
            TextBox2.Text = lbllname.Text;
            TextBox3.Text = lbladd.Text;
            TextBox5.Text = lblvtype.Text;
            TextBox6.Text = lblvnum.Text;
            TextBox7.Text = lblin.Text;
            TextBox8.Text = lblinum.Text;
            TextBox1.Visible = true;
            lname.Visible = true;
            TextBox2.Visible = true;
            llname.Visible = true;
            TextBox3.Visible = true;
            ladd.Visible = true;
            TextBox5.Visible = true;
            ltype.Visible = true;
            TextBox6.Visible = true;
            lnumber.Visible = true;
            TextBox7.Visible = true;
            linsurancen.Visible = true;
            TextBox8.Visible = true;
            linsurancenum.Visible = true;
            Button1.Visible = false;
            Button2.Visible = true;
            Button3.Visible = true;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "UPDATE UserInfo set Fname='" + TextBox1.Text + "', Lname='"+TextBox2.Text+ "', Address='"+TextBox3.Text+ "', Vnumber='"+TextBox5.Text+"', Vtype='"+TextBox6.Text+"',Iname='"+TextBox7.Text+"', Inumber='"+TextBox8.Text+"'  where Email='"+Label1.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Account Updated Successfully!', '', 'success').then(function(){window.location='Profile.aspx';});", true);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete from UserInfo where Email='" + Label1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Account Deleted Successfully!', '', 'success').then(function(){window.location='Login.aspx';});", true);
                con.Close();
            }catch(Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}