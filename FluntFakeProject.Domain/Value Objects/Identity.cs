using FluntFakeProject.Domain.ValueObjects.Assertions;

namespace FluntFakeProject.Domain.ValueObjects;

public class Identity : ValueObject
{
    /*
     * The values that has been used are fictitious
     */
    public string GeneralRegistry { get; private set; } // RG
    public string IndividualCode { get; private set; } // CPF
    public string BirthPlace { get; private set; } // Place where the person was born
    public string ShippingDate { get; private set; } // ID Issuance 

    public Identity(string generalRegistry, string individualCode, string birthPlace, string shippingDate)
    {
        GeneralRegistry = generalRegistry;
        IndividualCode = individualCode;
        BirthPlace = birthPlace;
        ShippingDate = shippingDate;

        AppendNotifications(
            IdentityAssertions.CreateIndividualCodeContract(IndividualCode),
            IdentityAssertions.CreateGeneralRegistryContract(GeneralRegistry),
            IdentityAssertions.CreateBirthPlaceContract(BirthPlace),
            IdentityAssertions.CreateShippingDateContract(ShippingDate));
    }
}
