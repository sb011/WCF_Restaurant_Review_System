using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Session["admin"] = txtUsername.Text;
                Response.Redirect("Admin_Home.aspx");
            }
            else
            {
                lblStatus.Text = "Invalid Username or Password";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}