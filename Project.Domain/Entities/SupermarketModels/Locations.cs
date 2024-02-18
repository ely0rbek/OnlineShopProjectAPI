using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.SupermarketModels
{
    public class Locations
    {
        public long location_id { get; set; }
        public string location_address { get; set;}
        public long location_city_id { get; set;}
    }
}
