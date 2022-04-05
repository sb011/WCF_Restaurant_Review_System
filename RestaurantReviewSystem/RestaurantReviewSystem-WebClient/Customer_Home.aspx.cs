using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Customer_Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]!=null)
            {
                
                Label1.Text = Session["username"].ToString();
            }
            else
            {
                Response.Redirect("Login.apsx");
            }
            
            
        }

        protected void Button2_Click(object sender, EventArgs e) //Add Review
        {
            Response.Redirect("Customer_AddReview.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_ShowReview.aspx");
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session.Clear();
            Response.Redirect("Main_Page.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_UpdateProfile.aspx");
        }
    }
}