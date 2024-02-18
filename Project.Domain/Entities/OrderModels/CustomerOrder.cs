using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.OrderModels
{
    public class CustomerOrder
    {
        public long customer_order_id { get; set; }
        public DateTime operation_time { get; set; }
        public long supermarket_location_id { get; set; }
        public long customer_id { get; set; }

    }
}
