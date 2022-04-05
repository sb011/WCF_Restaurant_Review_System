using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Customer_ShowReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindData();

            }
            if (Session["username"] != null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        protected void BindData()
        {
            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            int id = client.GetUserId(Session["username"].ToString());
            DataSet ds = client.GetReviewForOneUser(id);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            int ID = (int)e.Keys["Id"];

            RestaurantServiceReference.Review review = new RestaurantServiceReference.Review(); 
            string feedback = (string)e.NewValues["feedback"];
            string rating = (string)e.NewValues["rating"];
            string name = (string)e.NewValues["name"];
            string id = (string)e.NewValues["userId"];

            review.Id = ID;
            review.Feedback = feedback;
            review.Rating = int.Parse(rating);
            review.Name = name;
            review.UserId = int.Parse(id);
            

            bool status = client.UpdateReview(review);

            lblStatus.Text = "Review Updated Successfully...";
            lblStatus.ForeColor = System.Drawing.Color.Green;

            GridView1.EditIndex = -1;
            BindData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            int ID = (int)e.Keys["Id"];
            client.DeleteReview(ID);
            lblStatus.Text = "Review Deleted Successfully...";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[3].Text = "Restaurant Name";
                e.Row.Cells[4].Text = "Feedback";
                e.Row.Cells[5].Text = "Rating";
            }

            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
            
        }
    }
}