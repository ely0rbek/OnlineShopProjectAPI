using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.PersonModels
{
    public class PersonContacts
    {
        public long person_contact_id {  get; set; }
        public long person_id { get; set; }
        public long contact_type_id { get; set;}
        public string contact_value { get; set; }
    }
}
