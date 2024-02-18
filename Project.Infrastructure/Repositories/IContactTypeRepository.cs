using Project.Domain.Entities.PersonModels;

namespace Project.Infrastructure.Repositories
{
    public interface IContactTypeRepository
    {
        List<ContactTypes> GetAll();
    }
}
