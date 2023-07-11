using FastEndpointStudies.Models;

namespace FastEndpointStudies.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetBookAsync(Guid id);
        Task CreateBookAsync(Book b);
    }
}
