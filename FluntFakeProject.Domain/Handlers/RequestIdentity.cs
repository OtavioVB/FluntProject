using Flunt.Notifications;
using Flunt.Validations;
using FluntFakeProject.Domain.ValueObjects.Assertions;

namespace FluntFakeProject.Domain.Handlers
{
    public class RequestIdentity : Notifiable
    {
        public string GeneralRegistry { get; private set; } = string.Empty;
        public string IndividualCode { get; private set; } = string.Empty;
        public string BirthPlace { get; private set; } = string.Empty;
        public string ShippingDate { get; private set; } = string.Empty;

        public RequestIdentity(string generalRegistry, string individualCode, string birthPlace, string shippingDate)
        {
            GeneralRegistry = generalRegistry;
            IndividualCode = individualCode;
            BirthPlace = birthPlace;
            ShippingDate = shippingDate;

            AppendNotifications(
                IdentityAssertions.CreateGeneralRegistryContract(generalRegistry),
                IdentityAssertions.CreateBirthPlaceContract(birthPlace),
                IdentityAssertions.CreateIndividualCodeContract(individualCode),
                IdentityAssertions.CreateShippingDateContract(shippingDate)
            );
        }
    }
}
