namespace FluntFakeProject.Domain.Handlers
{
    public class Response
    {
        public string Message { get; private set; }

        public Response(string message) => Message = message;
    }
}
