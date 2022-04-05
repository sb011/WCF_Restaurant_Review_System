using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewSystem_WebClient
{
    public partial class Admin_Restaurant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindData();

            }
            if (Session["admin"] != null)
            {

            }
            else
            {
                Response.Redirect("Admin_Login.aspx");
            }
        }
        protected void add_Restaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Add_Restaurant.aspx");
        }
        protected void BindData()
        {
            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            DataSet ds = client.GetAllRestaurants();
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


            int ID = (int)e.Keys["restaurantId"];

            RestaurantServiceReference.Restaurant res = new RestaurantServiceReference.Restaurant();
            string name =(string)e.NewValues["name"];
            string city = (string)e.NewValues["city"];
            string description = (string)e.NewValues["description"];
            string food_type = (string)e.NewValues["food_type"];
            string contactno = (string)e.NewValues["contactno"];



            res.RestaurantId = ID;
            res.Name = name;
            res.City = city;
            res.Description = description;
            res.FoodType = food_type;
            res.ContactNo = contactno;

            client.UpdateRestaurant(res);

            GridView1.EditIndex = -1;
            lblStatus.Text = "Restaurant Updated Successfully...";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            RestaurantServiceReference.RestaurantServiceClient client = new RestaurantServiceReference.RestaurantServiceClient("BasicHttpBinding_IRestaurantService");

            int ID = (int)e.Keys["restaurantId"];
            client.DeleteRestaurant(ID);
            lblStatus.Text = "Restaurant Deleted Successfully...";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            BindData();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[2].Text = "Restaurant Name";
                e.Row.Cells[3].Text = "City";
                e.Row.Cells[4].Text = "Description";
                e.Row.Cells[5].Text = "Food Type";
                e.Row.Cells[6].Text = "Contact No";
            }
            e.Row.Cells[1].Visible = false;
        }
    }
}