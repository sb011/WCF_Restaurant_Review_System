using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Registration : System.Web.UI.Page
    {
        RestaurantServiceReference.RestaurantServiceClient client;

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }



        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");
                    RestaurantServiceReference.Customer user = new RestaurantServiceReference.Customer();

                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    user.Email = txtEmail.Text;
                    user.ContactNo = txtContactNo.Text;

                    try
                    {
                        client.RegisterUser(user);
                    }
                    catch (FaultException ex)
                    {
                        // lblStatus.Text = ex.Message.ToString();
                        //lblStatus.ForeColor = System.Drawing.Color.Red;
                        Console.Write(ex.Message.ToString());
                    }
                    

                    Session["username"] = txtUsername.Text;
                    Response.Redirect("Customer_Home.aspx");

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message.ToString());

            }
        }

        
    }
}