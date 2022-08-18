using Flunt.Validations;

namespace FluntFakeProject.Domain.ValueObjects.Assertions;

public static class NameAssertions
{
    public static Contract CreateValidationForNameContract(string name, string key = "Name.Value", string message = "The name is invalid")
    {
        return new Contract()
            .IsNotNull(name, key, message)
            .IsGreaterOrEqualsThan(name.Length, 3, key, message)
            .IsLowerOrEqualsThan(name.Length, 20, key, message);
    }
}
