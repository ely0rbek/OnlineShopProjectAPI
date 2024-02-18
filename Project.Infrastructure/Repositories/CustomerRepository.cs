using Dapper;
using Npgsql;
using Project.Domain.Entities.PersonModelDTO;
using Project.Domain.Entities.PersonModels;


namespace Project.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public string connectionString = "Host=localhost; Port = 5432; Database = ExamSql; User Id = postgres; Password = 1234;";
        public NpgsqlConnection connection;
        public CustomerRepository()
        {
            connection = new NpgsqlConnection(connectionString);
        }
        public List<Customer> GetAll()
        {
            return connection.Query<Customer>("select * from customers").ToList();
        }

        public string PostData(Customer customer)
        {
            var count = connection.Execute("insert into customers(customer_id,card_number,discount) values(@id,@number,@discount)", new {id=customer.customer_id,number=customer.card_number,discount=customer.discount});
            return "Qo'shildi";
        }

        public CustomerDTO updateCustomer(long id, CustomerDTO customer)
        {
            var count = connection.Execute($"update customers set card_number=@number,discount=@discount where customer_id={id}", new { number = customer.card_number, discount = customer.discount });
            return customer;
        }
        public string deleteCustomer(long id)
        {
            var count = connection.Execute("delete from customers where customer_id=@id", new { id = id });
            return "O'chirildi";
        }
    }
}
