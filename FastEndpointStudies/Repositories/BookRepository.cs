using FastEndpointStudies.Models;

namespace FastEndpointStudies.Repositories
{
    public class BookRepository : IBookRepository
    {
        public async Task CreateBookAsync(Book b)
        {
            //insert into db 
            //dummy response
            await Task.Delay(1);
        }

        public Task<Book> GetBookAsync(Guid id)
        {
            //get from db
            //dummy response
            return Task.Run(() =>
            {
                return new Book
                {
                    Id = id,
                    Title = "test",
                    Author = "test",
                    PublishDate = DateTime.Now,
                };
            });
        }
    }
}
