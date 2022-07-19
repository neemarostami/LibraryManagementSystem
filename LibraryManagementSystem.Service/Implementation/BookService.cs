using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service.Interface;

namespace LibraryManagementSystem.Service.Implementation
{
    public class BookService : IBookService
    {
        private IRepository<Book> bookRepository;
        private IRepository<ReservationDetail> reservationDetailRepository;

        public BookService(IRepository<Book> bookRepository, 
            IRepository<ReservationDetail> reservationDetailRepository)
        {
            this.bookRepository = bookRepository;
            this.reservationDetailRepository = reservationDetailRepository;
        }

        public Book GetBook(Guid id)
        {
            return bookRepository.Get(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return bookRepository.GetAll();
        }
    }
}
