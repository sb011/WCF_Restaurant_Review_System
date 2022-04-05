using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Customer_UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]!=null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
            
        }

        protected void Btn_Add_Restaurant_Click(object sender, EventArgs e)
        {
            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");
            RestaurantServiceReference.Customer customer = new RestaurantServiceReference.Customer();

            customer.Username = txtUsername.Text;
            customer.Email = txtEmail.Text;
            customer.ContactNo = txtContactNo.Text;

            client.UpdateUser(customer);

            lblStatus.Text = "Profile Updated Successffully";
            lblStatus.ForeColor = System.Drawing.Color.Green;
        }
    }
}