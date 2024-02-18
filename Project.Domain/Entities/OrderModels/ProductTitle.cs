using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.OrderModels
{
    public class ProductTitle
    {
        public long product_title_id { get; set; }
        public string product_title { get; set; }
        public long product_category_id { get; set; }
    }
}
