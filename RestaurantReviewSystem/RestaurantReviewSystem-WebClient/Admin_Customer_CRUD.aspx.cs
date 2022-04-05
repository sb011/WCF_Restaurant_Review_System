using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Admin_Customer_CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindData();

            }
            
            
        }
        protected void BindData()
        {
            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            DataSet ds = client.GetAllUsers();
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

            int ID = (int)e.Keys["userId"];

            RestaurantServiceReference.Customer customer = new RestaurantServiceReference.Customer();
            string username = (string)e.NewValues["username"];
            string email = (string)e.NewValues["email"];
            string password = (string)e.NewValues["password"];
            string contactno = (string)e.NewValues["contactno"];


            customer.UserId = ID;
            customer.Username = username;
            customer.Email = email;
            customer.Password = password;
            customer.ContactNo = contactno;

            client.UpdateUser(customer);

            GridView1.EditIndex = -1;

            lblStatus.Text = "Customer Updated Successfully...";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            int ID = (int)e.Keys["userId"];
            client.DeleteUser(ID);

            lblStatus.Text = "Customer Removed Successfully...";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //e.Row.Cells[1].Visible = false; 
                e.Row.Cells[2].Text = "Username";
                e.Row.Cells[3].Text = "Email ID";
                e.Row.Cells[5].Text = "Contact No";
            }
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[4].Visible = false;
        }
    }
}