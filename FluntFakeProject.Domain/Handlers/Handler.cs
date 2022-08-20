using Flunt.Notifications;
using Flunt.Validations;
using FluntFakeProject.Domain.ValueObjects;

namespace FluntFakeProject.Domain.Handlers
{
    public class Handler : Notifiable
    {
        public Response Handle(RequestName request)
        {
            if (request.IsValid is false)
            {
                AppendNotifications(request);
                throw new Exception("Request name is invalid");
            }

            var name = new Name(request.FirstName, request.LastName, request.Nickname);

            AppendNotifications(name);

            if (IsValid is false) throw new Exception("Entities or value objects are not valid");

            return new Response("Name created");
        }

        public Response Handle(RequestAddress request)
        {
            if (request.IsValid is false)
            {
                AppendNotifications(request);
                throw new Exception("Request address is invalid");
            }

            var name = new StreetAddress(request.AddressType, request.StreetName, request.HouseNumber, request.Neighborhood, request.Complement, request.IDAddress);

            AppendNotifications(name);

            if (IsValid is false) throw new Exception("Entities or value objects are not valid");

            return new Response("Address created");
        }

        public Response Handle(RequestIdentity request)
        {
            if (request.IsValid is false)
            {
                AppendNotifications(request);
                throw new Exception("Request identity is invalid");
            }

            var name = new Identity(request.GeneralRegistry, request.IndividualCode, request.BirthPlace, request.ShippingDate);

            AppendNotifications(name);

            if (IsValid is false) throw new Exception("Entities or value objects are not valid");

            return new Response("Identity created");
        }

        public Response Handle(RequestName requestName, RequestAddress requestAddress, RequestIdentity requestIdentity)
        {
            Handle(requestName);
            Handle(requestAddress);
            Handle(requestIdentity);

            return new Response("Person has been created");
        }
    }
}
