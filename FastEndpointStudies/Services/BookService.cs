using FastEndpointStudies.Models;
using FastEndpointStudies.Repositories;

namespace FastEndpointStudies.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _repository;
        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<Book> GetBookAsync(Guid id)
        {
            return await _repository.GetBookAsync(id);
        }
        public async Task CreateBookAsync(Book b)
        {
            await _repository.CreateBookAsync(b);
        }

    }
}
