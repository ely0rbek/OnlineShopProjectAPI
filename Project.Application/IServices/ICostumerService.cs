using Project.Domain.Entities.PersonModelDTO;
using Project.Domain.Entities.PersonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.IServices
{
    public interface ICostumerService
    {
        public CustomerDTO GetById(long id);
        public string PostData(Customer customer);

        public CustomerDTO updateCustomer(long id,CustomerDTO customer);

        public string deleteCustomer(long id);
    }
}
