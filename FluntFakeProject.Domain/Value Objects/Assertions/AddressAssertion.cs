using Flunt.Notifications;
using Flunt.Validations;

namespace FluntFakeProject.Domain.ValueObjects.Assertions;

public static class AddressAssertion
{
    public static Contract CreateStreetNameContract(string streetName)
    {
        return new Contract()
            .IsNotNullOrEmpty(streetName, "StreetAdress.StreetName.IsNullOrEmpty.Value", "Invalid street name")
            .IsLowerOrEqualsThan(streetName.Length, 4)
            .IsGreaterOrEqualsThan(streetName.Length, 60);
    }

    public static Contract CreateHouseNameContract(string houseNumber)
    {
        return new Contract()
            .Matches(houseNumber,"^[0-9]{8}$");
    }

    public static Contract CreateNeighborhoodContract(string neighborhood)
    {
        return new Contract()
            .IsNotNullOrEmpty(neighborhood, "StreetAdress.NeighboorHood.NullOrEmpty.Value", "Invalid neighborhood name")
            .IsGreaterOrEqualsThan(neighborhood.Length, 4)
            .IsLowerOrEqualsThan(neighborhood.Length, 60);
    }

    public static Contract CreateComplementContract(string complement)
    {
        return new Contract()
            .IsNotNullOrEmpty(complement, "StreetAdress.Complement.NullOrEmpty.Value", "The street complement is invalid")
            .IsGreaterOrEqualsThan(complement.Length, 4)
            .IsLowerOrEqualsThan(complement.Length, 100);
    }

    public static Contract CreateIDAddressContract(string idAddress)
    {
        return new Contract()
            .Matches(idAddress, @"^[0]{1}[0-9]{8}$", "StreetAdress.IDAdress.RegularExpression.Value", "The Adress ID is invalid");
    }
}
