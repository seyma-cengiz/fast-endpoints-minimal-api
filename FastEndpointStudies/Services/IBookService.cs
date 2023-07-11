using FastEndpointStudies.Models;

namespace FastEndpointStudies.Services
{
    public interface IBookService
    {
        Task<Book> GetBookAsync(Guid id);
        Task CreateBookAsync(Book b);
    }
}
