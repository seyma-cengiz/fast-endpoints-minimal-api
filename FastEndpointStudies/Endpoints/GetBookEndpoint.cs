using FastEndpoints;
using FastEndpointStudies.Mappings;
using FastEndpointStudies.Requests;
using FastEndpointStudies.Responses;
using FastEndpointStudies.Services;
using Microsoft.AspNetCore.Authorization;

namespace FastEndpointStudies.Endpoints
{
    [HttpGet("books/{id:guid}"), AllowAnonymous]
    public class GetBookEndpoint : Endpoint<GetBookRequest, GetBookResponse>
    {
        private readonly IBookService _service;
        public GetBookEndpoint(IBookService service)
        {
            _service = service;
        }
        public override async Task HandleAsync(GetBookRequest req, CancellationToken ct)
        {
            var book = await _service.GetBookAsync(req.Id);

            if (book is null)
            {
                await SendNotFoundAsync(ct);
                return;
            }

            var response = book.ToGetBookResponse();
            await SendOkAsync(response, ct);
        }
    }
}
