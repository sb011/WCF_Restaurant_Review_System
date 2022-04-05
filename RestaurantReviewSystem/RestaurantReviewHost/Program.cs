using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace RestaurantReviewHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(RestaurantReviewSystem.RestaurantService);
            Uri tcp = new Uri("net.tcp://localhost:8010/RestaurantService");
            Uri http = new Uri("http://localhost:8000/RestaurantService");

            ServiceHost host = new ServiceHost(t, tcp, http);
            host.Open();
            Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
            Console.ReadLine();
            host.Close();
        }
    }
}
