using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace AMS
{
    public partial class Summery_Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                LoadData1();
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

        void LoadData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select type, count(type) as num_acc from Query group by type", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            string[] x = new string[dt.Rows.Count];
            int[] y = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(dt.Rows[i][1]);
            }
            Chart1.Series[0].Points.DataBindXY(x, y);
            Chart1.Series[0].ChartType = SeriesChartType.Pie;
            Chart1.Legends[0].Enabled = true;
        }

        void LoadData1()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#_Practicle\Project_PUSL2020\AMS\AMSDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select type, count(type) as num_acc from Query group by type", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            string[] x = new string[dt.Rows.Count];
            int[] y = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(dt.Rows[i][1]);
            }
            Chart2.Series[0].Points.DataBindXY(x, y);
            Chart2.Series[0].ChartType = SeriesChartType.Bar;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Ad_OthersL.aspx");
        }
    }
}