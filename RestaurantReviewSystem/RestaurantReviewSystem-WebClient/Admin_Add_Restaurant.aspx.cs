using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Admin_Add_Restaurant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {

            }
            else
            {
                Response.Redirect("Admin_Login.aspx");
            }

        }

        protected void Btn_Add_Restaurant_Click(object sender, EventArgs e)
        {
            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");
            RestaurantServiceReference.Restaurant res = new RestaurantServiceReference.Restaurant();

            res.FoodType = txtFoodType.Text;
            res.Description = txtDescription.Text;
            res.City = txtCity.Text;
            res.Name = txtName.Text;
            res.ContactNo = txtContactNo.Text;

            client.AddRestaurant(res);

            lblStatus.Text = "Restaurant Added Successfully...";
            lblStatus.ForeColor = System.Drawing.Color.Green;
        }
    }
}