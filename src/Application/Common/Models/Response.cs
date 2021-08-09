using System.Net;


namespace test.Application.Common.Models
{
    public record Response
    {
        public HttpStatusCode StatusCode { get; init; } = HttpStatusCode.OK;
        public string ErrorMessage { get; init; }
    }
}
