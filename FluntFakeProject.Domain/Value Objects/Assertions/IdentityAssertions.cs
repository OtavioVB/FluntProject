using Flunt.Validations;

namespace FluntFakeProject.Domain.ValueObjects.Assertions;

public static class IdentityAssertions
{
    public static Contract CreateIndividualCodeContract(string individualCode)
    {
        return
            new Contract()
                .IsNotNullOrWhiteSpace(individualCode, "IndividualCode.NullOrWhiteSpace.Value", "Your Individual Code is invalid")
                .Matches(individualCode, @"^[0-9]{11}$", "IndividualCode.RegularExpression.Value.NotMatches", "Your Individual Code is invalid according to regular expression");
    }

    public static Contract CreateGeneralRegistryContract(string generalRegistry)
    {
        return 
            new Contract()
                .IsNotNullOrWhiteSpace(generalRegistry, "GeneralRegistry.NullOrWhiteSpace.Value", "Your General Registry is invalid")
                .Matches(generalRegistry, @"^[0-9]{9}$", "GeneralRegistry.RegularExpression.Value.NotMatches", "Your General Registry is invalid according to regular expression");
    }

    public static Contract CreateBirthPlaceContract(string birthPlace)
    {
        return 
            new Contract()
                .IsNotNullOrEmpty(birthPlace, "BirthPlace.NullOrEmpty.Value", "Your Birth Place is invalid")
                .IsGreaterOrEqualsThan(birthPlace.Length, 3)
                .IsLowerOrEqualsThan(birthPlace.Length, 40);
    }

    public static Contract CreateShippingDateContract(string shippingDate)
    {
        return
            new Contract()
                .IsBetween(Convert.ToDateTime(shippingDate), DateTime.Now.AddDays(-3650), DateTime.Now, "ShippingDate.IsBetween.Value", "Your Shipping Date Identity has expired");
    }
}
