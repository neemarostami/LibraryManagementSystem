using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Service.Implementation;
using LibraryManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        [Route("List")]
        public List<Book> GetBooksList()
        {
            return bookService.GetBooks().ToList();

        }
    }
}
