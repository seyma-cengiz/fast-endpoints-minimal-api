using FastEndpoints;
using FastEndpointStudies.Mappings;
using FastEndpointStudies.Requests;
using FastEndpointStudies.Responses;
using FastEndpointStudies.Services;
using Microsoft.AspNetCore.Authorization;

namespace FastEndpointStudies.Endpoints
{
    [HttpPost("books"), AllowAnonymous]
    public class CreateBookEndpoint : Endpoint<CreateBookRequest, CreateBookResponse>
    {
        private IBookService _service;
        public CreateBookEndpoint(IBookService service)
        {
            _service = service;
        }
        public override async Task HandleAsync(CreateBookRequest req, CancellationToken ct)
        {
            var book = req.ToBook();
            book.Id = Guid.NewGuid();
            await _service.CreateBookAsync(book);

            var response = book.ToCreateBookResponse();
            await SendCreatedAtAsync<GetBookEndpoint>(new { Id = book.Id }, response, generateAbsoluteUrl: true, cancellation: ct);

        }
    }
}
