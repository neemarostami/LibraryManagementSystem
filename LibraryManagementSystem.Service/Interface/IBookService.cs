using LibraryManagementSystem.Domain.Model;

namespace LibraryManagementSystem.Service.Interface
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(Guid id);
    }
}
