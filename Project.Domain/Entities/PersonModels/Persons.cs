using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.PersonModels
{
    public class Persons
    {
        public long person_id { get; set; }
        public string person_first_name { get; set; }
        public string person_last_name { get; set; }
        public DateOnly person_birth_date { get; set; }
    }
}
