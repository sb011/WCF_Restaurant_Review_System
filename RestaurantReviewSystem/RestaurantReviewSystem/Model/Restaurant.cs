using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace RestaurantReviewSystem.Model
{
    [DataContract]
    public class Restaurant
    {
        [DataMember(IsRequired = false)]
        public int RestaurantId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string FoodType { get; set; }

        [DataMember]
        public string ContactNo { get; set; }


    }
}
