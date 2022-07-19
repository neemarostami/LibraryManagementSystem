using LibraryManagementSystem.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private readonly DbSet<T> entities;
        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T Get(Guid id)
        {
            return entities.SingleOrDefault(p => p.Id == id);
        }
    }
}
