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
    public class Review
    {
        [DataMember(IsRequired = false)]
        public int Id { get; set; }

        [DataMember(IsRequired = false)]
        public int UserId { get; set; }

        [DataMember(IsRequired = false)]
        public string Name { get; set; }

        [DataMember]
        public string Feedback { get; set; }

        [DataMember]
        public int Rating { get; set; }
    }
}
