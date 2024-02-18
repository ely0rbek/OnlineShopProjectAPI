using Project.Domain.Entities.PersonModelDTO;
using Project.Domain.Entities.PersonModels;


namespace Project.Infrastructure.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();

        string PostData(Customer customer);

        CustomerDTO updateCustomer(long id,CustomerDTO customer);

        string deleteCustomer(long id);

    }
}
