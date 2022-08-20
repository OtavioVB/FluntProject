using FluntFakeProject.Domain.ValueObjects;
using Flunt.Notifications;
using Flunt.Validations;
using FluntFakeProject.Domain.ValueObjects.Assertions;

namespace FluntFakeProject.Domain.Handlers
{
    public class RequestAddress : Notifiable
    {
        public AddressType AddressType { get; private set; }
        public string StreetName { get; private set; } = string.Empty;
        public string HouseNumber { get; private set; } = string.Empty;
        public string Neighborhood { get; private set; } = string.Empty;
        public string Complement { get; private set; } = string.Empty;
        public string IDAddress { get; private set; } = string.Empty;

        public RequestAddress(AddressType addressType, string streetName, string houseNumber, string neighborhood, string complement, string idAddress)
        {
            AddressType = addressType;
            StreetName = streetName;
            HouseNumber = houseNumber;
            Neighborhood = neighborhood;
            Complement = complement;
            IDAddress = idAddress;

            AppendNotifications(
                AddressAssertion.CreateIDAddressContract(IDAddress),
                AddressAssertion.CreateNeighborhoodContract(Neighborhood),
                AddressAssertion.CreateComplementContract(Complement),
                AddressAssertion.CreateStreetNameContract(StreetName),
                AddressAssertion.CreateHouseNameContract(HouseNumber)
            );
        }
    }
}
