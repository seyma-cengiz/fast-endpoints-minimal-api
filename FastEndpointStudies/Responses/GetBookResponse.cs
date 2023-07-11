namespace FastEndpointStudies.Responses
{
    public class GetBookResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
