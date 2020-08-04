using System;
using System.Collections.Generic;

namespace ComponentProcessingMicroservice.Models
{
    public partial class OrderDetails
    {
        public int RequestId { get; set; }
        public int ProcessingCharge { get; set; }
        public int PackagingDeliveryCharge { get; set; }
        public DateTime Date { get; set; }
    }
}
