using FluntFakeProject.Domain.ValueObjects;
using Flunt.Notifications;
using Flunt.Validations;
using FluntFakeProject.Domain.ValueObjects.Assertions;

namespace FluntFakeProject.Domain.Handlers
{
    public class RequestName : Notifiable
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;

        public RequestName(string firstName, string lastName, string nickname)
        {
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;

            AppendNotifications(
                NameAssertions.CreateValidationForNameContract(FirstName),
                NameAssertions.CreateValidationForNameContract(LastName),
                NameAssertions.CreateValidationForNameContract(Nickname)
            );
        }
    }
}
