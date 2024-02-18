using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.OrderModels
{
    public class ShopProduct
    {
        public long product_id { get; set; }
        public long product_title_id { get; set; }
        public long product_manufacturer_id { get; set; }
        public long product_supplier_id { get; set; }
        public SqlMoney unit_price { get; set; }
        public string comment { get; set; }
    }
}
