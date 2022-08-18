using Flunt.Notifications;
using FluntFakeProject.Domain.ValueObjects.Assertions;

namespace FluntFakeProject.Domain.ValueObjects;

public enum AdressType { Street, Park, Avenue }

public class StreetAdress : ValueObject
{
    public AdressType AdressType { get; private set; } // Type of the adress (pt-br: Rua, Parque, Avenida)
    public string StreetName { get; private set; }
    public int HouseNumber { get; private set; }
    public string Neighborhood { get; private set; }
    public string Complement { get; private set; }
    public string IDAddress { get; private set; } // CEP

    public StreetAdress(AdressType adressType, string streetName, int houseNumber, string neighborhood, string complement, string idAddress)
    {
        AdressType = adressType;
        StreetName = streetName;
        HouseNumber = houseNumber;
        Neighborhood = neighborhood;
        Complement = complement;
        IDAddress = idAddress;

        Assert(
            AdressAssertion.CreateStreetNameContract(StreetName));
    }
}
