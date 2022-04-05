using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Login : System.Web.UI.Page
    {
        RestaurantServiceReference.RestaurantServiceClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");
                int status;
                string uname = txtUsername.Text;
                string pass = txtPassword.Text;
                status = client.SignInUser(uname, pass);

                if (status == 1)
                {
                    Session["username"] = txtUsername.Text;
                    lblStatus.Text = "Signed In Successfully";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("Customer_Home.aspx");
                }
                else if (status == 2)
                {
                    lblStatus.Text = "InCorrect Pasaword !";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
                else if (status == 3)
                {
                    lblStatus.Text = "User Doesn't Exist !";
                    string strMsg = "User Doesn't Exist !";
                    string script = "<script language=\"javascript\" type=\"text/javascript\">alert('" + strMsg + "');</script>";
                    Response.Write(script);
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            
        }
    }
}