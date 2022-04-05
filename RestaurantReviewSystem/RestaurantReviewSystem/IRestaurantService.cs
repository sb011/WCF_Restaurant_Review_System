using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestaurantReviewSystem.Model;

namespace RestaurantReviewSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestaurantService" in both code and config file together.
    [ServiceContract(Name="IRestaurantService")]
    public interface IRestaurantService
    {
        [OperationContract]
        void RegisterUser(Customer user);

        [OperationContract]
        int SignInUser(string username, string password);

        [OperationContract]
        bool UpdateUser(Customer user);

        [OperationContract]
        bool DeleteUser(int id);

        [OperationContract]
        DataSet GetAllUsers();

        [OperationContract]
        void AddRestaurant(Restaurant restaurant);

        [OperationContract]
        bool DeleteRestaurant(int id);

        [OperationContract]
        bool UpdateRestaurant(Restaurant restaurant);

        [OperationContract]
        DataSet GetAllRestaurants();

        [OperationContract]
        void AddReview(Review review);

        [OperationContract]
        IEnumerable<String> GetRestaurantNames();

        [OperationContract]
        int GetUserId(string uname);

        [OperationContract]
        DataSet GetAllReviews();

        [OperationContract]
        bool UpdateReview(Review review);

        [OperationContract]
        bool DeleteReview(int id);

        [OperationContract]
        DataSet GetReviewForOneUser(int id);



    }
}
