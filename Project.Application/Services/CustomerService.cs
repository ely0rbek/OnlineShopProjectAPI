using Project.Application.IServices;
using Project.Domain.Entities.PersonModelDTO;
using Project.Domain.Entities.PersonModels;
using Project.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services
{
    public class CustomerService : ICostumerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public CustomerDTO GetById(long id)
        {
            List<Customer> list = _customerRepository.GetAll();
            foreach (Customer customer in list)
            {
                if (id == customer.customer_id)
                {
                    var customerDTO = new CustomerDTO()
                    {
                        card_number = customer.card_number,
                        discount = customer.discount,
                    };
                    return customerDTO;
                }     
            }
            return new CustomerDTO() { };
        }

        public string PostData(Customer customer)
        {
            if (customer.card_number == null)
            {
                return "To'gri malumot emas";
            }
            try
            {
                return _customerRepository.PostData(customer);
            }
            catch
            {
                return "Error in service";
            }
        }
        public CustomerDTO updateCustomer(long id,CustomerDTO customer)
        {
            try
            {
                return _customerRepository.updateCustomer(id,customer);
            }
            catch
            {
                return new CustomerDTO();
            }
        }

        public string deleteCustomer(long id)
        {
            try
            {
                return _customerRepository.deleteCustomer(id);
            }
            catch
            {
                return "Error in service";
            }
        }

    }
}
