using FastEndpointStudies.Models;
using FastEndpointStudies.Requests;
using FastEndpointStudies.Responses;

namespace FastEndpointStudies.Mappings
{
    public static class BookMapping
    {
        public static Book ToBook(this CreateBookRequest createBookRequest)
        {
            return new Book
            {
                Title = createBookRequest.Title,
                Author = createBookRequest.Author,
                PublishDate = createBookRequest.PublishDate
            };
        }

        public static CreateBookResponse ToCreateBookResponse(this Book book)
        {
            return new CreateBookResponse
            {
                Id = book.Id,
                Title = book.Title,
                Status = "Added"
            };
        }

        public static GetBookResponse ToGetBookResponse(this Book book)
        {
            return new GetBookResponse
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                PublishDate = book.PublishDate
            };
        }
    }
}
