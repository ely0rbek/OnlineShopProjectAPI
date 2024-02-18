using Dapper;
using Npgsql;
using Project.Domain.Entities.PersonModels;

namespace Project.Infrastructure.Repositories
{
    public class ContactTypeRepository : IContactTypeRepository
    {
        public string connectionString = "Host=localhost; Port = 5432; Database = ExamSql; User Id = postgres; Password = 1234;";
        public NpgsqlConnection connection;
        public ContactTypeRepository()
        {
            connection = new NpgsqlConnection(connectionString);
        }
        public List<ContactTypes> GetAll()
        {
            return connection.Query<ContactTypes>("select * from contact_types").ToList();
        }
    }
}
