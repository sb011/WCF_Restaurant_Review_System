using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Admin_Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindData();
            }
            if (Session["admin"] != null)
            {

            }
            else
            {
                Response.Redirect("Admin_Login.aspx");
            }

        }
        protected void BindData()
        {
            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            DataSet ds = client.GetAllReviews();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            int ID = (int)e.Keys["Id"];

            client.DeleteReview(ID);

            lblStautus.Text = "Review Deleted Successfully";
            lblStautus.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                
                e.Row.Cells[2].Text = "Username";
                e.Row.Cells[3].Text = "Email ID";
                e.Row.Cells[4].Text = "Restaurant Name";
                e.Row.Cells[5].Text = "Feedback";
                e.Row.Cells[6].Text = "Rating";
            }
            e.Row.Cells[1].Visible = false;

        }
    }
}