using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;

namespace AMS
{
    public partial class InsertFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clearfn();
            }

            if (Session["SEmail"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Label5.Text = Session["SEmail"].ToString();
            TextBox1.Text= Session["SEmail"].ToString();
        }


        public void clearfn()
        {
            txtLocation.Text = "";
            txtDescription.Text = "";
            lblErrorMzg.Text = "";
        }

        protected void btnUpload_Click1(object sender, EventArgs e)
        {
            if (uploadImage.HasFiles)
            {
                try
                {
                    string extension = Path.GetExtension(uploadImage.FileName);
                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                    {
                        if (uploadImage.PostedFile.ContentLength <= 102400)
                        {
                            string type = dropdownList.SelectedItem.Value;
                            string fname = Path.GetFileName(uploadImage.FileName);
                            uploadImage.SaveAs(Server.MapPath("images/") + fname);



                            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
                            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                            {
                                con.Open();
                                SqlCommand cmd = new SqlCommand("insert into Query values ('" + txtLocation.Text + "','" + txtDescription.Text + "','" + uploadImage.FileName + "','"+TextBox1.Text+"','"+type+"')", con);
                                int t = cmd.ExecuteNonQuery();
                                if (t > 0)
                                {
                                    Response.Write("<script>alert('File has been uploaded successfully!')</script>");
                                    clearfn();
                                }
                            }
                        }
                        else
                        {
                            lblErrorMzg.Text = "You can only upload files size less than 100kb";
                        }
                    }
                    else
                    {
                        lblErrorMzg.Text = "Only .jpg .jpeg and .png images are allowed.";
                        lblErrorMzg.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblErrorMzg.Text = "the following error has been occured:" + ex.Message;
                    clearfn();
                }
            }
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
    }
}