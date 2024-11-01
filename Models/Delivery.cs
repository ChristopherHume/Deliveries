using System;

namespace Loaner.Models
{
    public class Delivery
    {

        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DeliveryTime { get; set; }

    }
}
