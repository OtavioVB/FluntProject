using Flunt.Notifications;
using FluntFakeProject.Domain.ValueObjects.Assertions;
using Flunt.Validations;

namespace FluntFakeProject.Domain.ValueObjects;

public enum AddressType { Street, Park, Avenue }

public class StreetAddress : ValueObject
{
    public AddressType AddressType { get; private set; } // Type of the address (pt-br: Rua, Parque, Avenida)
    public string StreetName { get; private set; }
    public string HouseNumber { get; private set; }
    public string Neighborhood { get; private set; }
    public string Complement { get; private set; }
    public string IDAddress { get; private set; } // CEP

    public StreetAddress(AddressType addressType, string streetName, string houseNumber, string neighborhood, string complement, string idAddress)
    {
        AddressType = addressType;
        StreetName = streetName;
        HouseNumber = houseNumber;
        Neighborhood = neighborhood;
        Complement = complement;
        IDAddress = idAddress;

        AppendNotifications(
            AddressAssertion.CreateStreetNameContract(StreetName),
            AddressAssertion.CreateHouseNameContract(HouseNumber),
            AddressAssertion.CreateNeighborhoodContract(Neighborhood),
            AddressAssertion.CreateComplementContract(Complement),
            AddressAssertion.CreateIDAddressContract(IDAddress)
        );
    }
}
