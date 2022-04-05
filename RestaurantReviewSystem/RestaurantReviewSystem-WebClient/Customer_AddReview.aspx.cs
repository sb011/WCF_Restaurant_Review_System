using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Customer_AddReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");
                DropDownList1.DataSource = client.GetRestaurantNames();
                DropDownList1.DataBind();
            }
            if(Session["username"]!=null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Btn_Add_Review_Click(object sender, EventArgs e)
        {
            try
            {
                RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");
                RestaurantServiceReference.Review review = new RestaurantServiceReference.Review();

                int id = client.GetUserId(Session["username"].ToString());
                review.UserId = id;
                review.Name = DropDownList1.SelectedValue;
                review.Feedback = txtFeedback.Text;
                review.Rating = int.Parse(txtRating.Text);

                client.AddReview(review);
                lblStauts.Text = "Review Added Successfully";
                lblStauts.ForeColor = System.Drawing.Color.Green;
            }
            catch(Exception ex)
            {
                lblStauts.Text = ex.Message.ToString();
                lblStauts.ForeColor = System.Drawing.Color.Red;

            }
            

        }
    }
}