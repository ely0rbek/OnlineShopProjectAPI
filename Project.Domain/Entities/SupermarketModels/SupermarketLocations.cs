using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.SupermarketModels
{
    public class SupermarketLocations
    {
        public long supermarket_location_id { get; set; }
        public long supermarket_id { get; set; }
        public long location_id { get; set; }
    }
}
