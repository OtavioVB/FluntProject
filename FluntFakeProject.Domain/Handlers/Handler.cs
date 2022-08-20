namespace FluntFakeProject.Domain.Handlers
{
    public class Handler
    {
        public Response Handle(RequestName request)
        {
            return new Response("Name created");
        }

        public Response Handle(RequestAddress request)
        {
            return new Response("Address created");
        }

        public Response Handle(RequestIdentity request)
        {
            return new Response("Identity created");
        }
    }
}
