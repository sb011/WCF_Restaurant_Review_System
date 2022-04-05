using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Admin_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["admin"]!=null)
            {

            }
            else
            {
                Response.Redirect("Admin_Login.aspx");
            }

        }

        protected void Btn_Restaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Restaurant.aspx");
        }

        protected void Btn_Review_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Review.aspx");
        }

        protected void Btn_User_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Customer_CRUD.aspx");
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Session.Clear();
            Response.Redirect("Main_Page.aspx");
        }
    }
}