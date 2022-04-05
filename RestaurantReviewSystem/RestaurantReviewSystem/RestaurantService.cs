using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestaurantReviewSystem.Model;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading.Tasks;
using System.Configuration;



namespace RestaurantReviewSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestaurantService" in both code and config file together.
    //[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class RestaurantService : IRestaurantService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RR"].ConnectionString;

        public void RegisterUser(Customer user)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //cmd.CommandText = "SELECT * FROM Customer where username = @username";


                //SqlParameter p = new SqlParameter("@username", user.Username);
                //cmd.Parameters.Add(p);

                //con.Open();
                //SqlDataReader rdr = cmd.ExecuteReader();
                // if (rdr.Read())
                //{
                // con.Close();
                // return false;
                //} 
                //else
                //{
                cmd.CommandText = "INSERT INTO Customer (username, email, password, contactno) VALUES (@username, @email, @password, @contactno)";
                SqlParameter p2 = new SqlParameter("@username", user.Username);
                SqlParameter p3 = new SqlParameter("@email", user.Email);
                SqlParameter p4 = new SqlParameter("@password", user.Password);
                SqlParameter p5 = new SqlParameter("@contactno", user.ContactNo);


                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                //return true;
                //}

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);

            }
            //return false;
        }
        public int SignInUser(string username, string password)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Customer WHERE username=@username";
            SqlParameter p = new SqlParameter("@username", username);
            cmd.Parameters.Add(p);

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    if (password.Equals(rdr["password"]))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            else
            {
                return 3;
            }

            con.Close();

            return 0;
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Restaurant (name, city, description, food_type, contactno) VALUES (@name, @city, @description, @food_type, @contactno)";
                SqlParameter p1 = new SqlParameter("@name", restaurant.Name);
                SqlParameter p2 = new SqlParameter("@city", restaurant.City);
                SqlParameter p3 = new SqlParameter("@description", restaurant.Description);
                SqlParameter p4 = new SqlParameter("@food_type", restaurant.FoodType);
                SqlParameter p5 = new SqlParameter("@contactno", restaurant.ContactNo);


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);

            }

        }

        public bool DeleteRestaurant(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Restaurant WHERE restaurantId = @id";
                SqlParameter p1 = new SqlParameter("@id", id);

                cmd.Parameters.Add(p1);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();


                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);
                return false;

            }

        }
        public DataSet GetAllRestaurants()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Restaurant", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Restaurant");
            return ds;
        }

        public DataSet GetAllUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            return ds;
        }

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Restaurant SET name=@name,city=@city,description=@description,food_type=@food_type,contactno=@contactno WHERE restaurantId=@id";
                SqlParameter p1 = new SqlParameter("@name", restaurant.Name);
                SqlParameter p2 = new SqlParameter("@city", restaurant.City);
                SqlParameter p3 = new SqlParameter("@description", restaurant.Description);
                SqlParameter p4 = new SqlParameter("@food_type", restaurant.FoodType);
                SqlParameter p5 = new SqlParameter("@contactno", restaurant.ContactNo);
                SqlParameter p6 = new SqlParameter("@id", restaurant.RestaurantId);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);
                return false;

            }

        }

        public bool UpdateUser(Customer user)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Customer SET username=@username,email=@email,password=@password,contactno=@contactno WHERE userId=@id";
                SqlParameter p1 = new SqlParameter("@username", user.Username);
                SqlParameter p2 = new SqlParameter("@email", user.Email);
                SqlParameter p3 = new SqlParameter("@password", user.Password);
                SqlParameter p4 = new SqlParameter("@contactno", user.ContactNo);
                SqlParameter p5 = new SqlParameter("@id", user.UserId);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);
                return false;

            }
        }
        public bool DeleteUser(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Customer WHERE userId = @id";
                SqlParameter p1 = new SqlParameter("@id", id);

                cmd.Parameters.Add(p1);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();


                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);
                return false;

            }


        }

        public void AddReview(Review review)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Review (userId, name, feedback, rating) VALUES (@userId, @name, @feedback, @rating)";

                SqlParameter p1 = new SqlParameter("@userId", review.UserId);
                SqlParameter p2 = new SqlParameter("@name", review.Name);
                SqlParameter p3 = new SqlParameter("@feedback", review.Feedback);
                SqlParameter p4 = new SqlParameter("@rating", review.Rating);
                

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
               

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);

            }
        }

        public IEnumerable<String> GetRestaurantNames()
        {
            List<String> list= new List<string>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT name FROM Restaurant";

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                list.Add(rdr.GetString(0));
            }

            con.Close();

            return list;

        }
        public int GetUserId(string uname)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT userId FROM Customer WHERE username=@username";

            SqlParameter p1 = new SqlParameter("@username", uname);
            

            cmd.Parameters.Add(p1);

            con.Open();

            SqlDataReader rdr =  cmd.ExecuteReader();

            int id=0;
            if(rdr.Read())
            {
                id = rdr.GetInt32(0);
                con.Close();
                return id;
            }
            else
            {
                con.Close();
                return id;
            }

        }

        public DataSet GetAllReviews()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT Review.id,Customer.username,Customer.email,Review.name,Review.feedback,Review.rating From Review INNER JOIN Customer ON Review.userId = Customer.userId";

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Close();
            return ds; 
        }

        public bool DeleteReview(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Review WHERE Id=@id";
                SqlParameter p1 = new SqlParameter("@id", id);

                cmd.Parameters.Add(p1);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);
                return false;

            }
        }

        public DataSet GetReviewForOneUser(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Review WHERE userId=@id";
            SqlParameter p1 = new SqlParameter("@id", id);

            cmd.Parameters.Add(p1);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Close();
            return ds;


        }

        public bool UpdateReview(Review review)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Review SET userId=@userId,name=@name,feedback=@feedback,rating=@rating WHERE Id=@id";
                SqlParameter p1 = new SqlParameter("@name", review.Name);
                SqlParameter p2 = new SqlParameter("@feedback", review.Feedback);
                SqlParameter p3 = new SqlParameter("@rating", review.Rating);
                SqlParameter p4 = new SqlParameter("@id", review.Id);
                SqlParameter p5 = new SqlParameter("@userId", review.UserId);


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);
                return false;

            }
        }
    }
}

