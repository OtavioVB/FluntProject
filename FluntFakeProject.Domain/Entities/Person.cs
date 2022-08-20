using FluntFakeProject.Domain.ValueObjects;
namespace FluntFakeProject.Domain.Entities;

public class Person : Entity
{
    public Name Name { get; private set; }
    public StreetAddress StreetAdress { get; private set; }
    public Identity Identity { get; private set; }


    public Person(Identity identity, StreetAddress streetAdress, Name name)
    {
        Identity = identity;
        StreetAdress = streetAdress;
        Name = name;

        AppendNotifications(Name, StreetAdress, Identity);
    }
}
