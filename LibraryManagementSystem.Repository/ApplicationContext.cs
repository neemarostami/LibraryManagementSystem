using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Domain.Model.EFCoreMappings;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new BookMap(modelBuilder.Entity<Book>());
            new MemberMap(modelBuilder.Entity<Member>());
            new ReservationMap(modelBuilder.Entity<Reservation>());
            new ReservationDetailMap(modelBuilder.Entity<ReservationDetail>());
        }
    }
}
