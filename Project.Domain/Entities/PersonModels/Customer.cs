using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.PersonModels
{
    public class Customer
    {
        public long customer_id { get; set; }
        public long card_number { get; set;}
        public int discount { get; set;}
    }
}
