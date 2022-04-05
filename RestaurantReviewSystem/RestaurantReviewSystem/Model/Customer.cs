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
    public class Customer
    {
        [DataMember(IsRequired =false)]
        public int UserId { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string ContactNo { get; set; }

        [DataMember]
        public string Email { get; set; }

        
    }
}
