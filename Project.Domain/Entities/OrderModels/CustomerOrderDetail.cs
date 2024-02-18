using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.OrderModels
{
    public class CustomerOrderDetail
    {
        public long customer_order_detail_id { get; set; }
        public long customer_order_id { get; set; }
        public long product_id { get; set; }
        public SqlMoney price { get; set; }
        public SqlMoney price_with_discount { get; set; }
        public int product_amount { get; set; }
    }
}
