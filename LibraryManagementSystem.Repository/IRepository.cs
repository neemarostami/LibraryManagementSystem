using LibraryManagementSystem.Domain.Model;

namespace LibraryManagementSystem.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(Guid id);
        IEnumerable<T> GetAll();
    }
}
