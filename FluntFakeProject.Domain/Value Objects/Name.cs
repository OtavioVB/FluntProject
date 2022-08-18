using Flunt.Notifications;
using Flunt.Validations;
using Flunt.FakeProjects.ValueObjects.Assertions;

namespace FluntFakeProject.Domain.ValueObjects;

public class Name : ValueObject
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Nickname { get; set; }

    public Name(string firstName, string lastName, string nickname)
    {
        FirstName = firstName;
        LastName = lastName;
        Nickname = nickname;

        AppendNotifications(
            NameAssertions.CreateValidationForNameContract(FirstName, "FirstName.Value", "The user first name is invalid."),
            NameAssertions.CreateValidationForNameContract(LastName, "LastName.Value", "The user last name is invalid."),
            NameAssertions.CreateValidationForNameContract(Nickname, "Nickname.Value", "The user nickname is invalid")
        );
    }
}