using Flunt.Notifications;
using Flunt.Validations;
using FluntFakeProject.Domain.ValueObjects;
using FluntFakeProject.Domain.Entities;

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

            return new Response("Address has been created");
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

            return new Response("Identity has been created");
        }

        public Response Handle(RequestName requestName, RequestAddress requestAddress, RequestIdentity requestIdentity)
        {
            Handle(requestName);
            Handle(requestAddress);
            Handle(requestIdentity);

            var person = new Person(
                new Identity(requestIdentity.GeneralRegistry, requestIdentity.IndividualCode, requestIdentity.BirthPlace, requestIdentity.ShippingDate),
                new StreetAddress(requestAddress.AddressType, requestAddress.StreetName, requestAddress.HouseNumber, requestAddress.Neighborhood, requestAddress.Complement, requestAddress.IDAddress),
                new Name(requestName.FirstName, requestName.LastName, requestName.Nickname));

            return new Response("Person has been created");
        }
    }
}
