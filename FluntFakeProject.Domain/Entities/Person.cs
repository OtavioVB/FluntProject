using FluntFakeProject.Domain.ValueObjects;
namespace FluntFakeProject.Domain.Entities;

public class Person : Entity
{
    public Name Name { get; private set; }
    public StreetAdress StreetAdress { get; private set; }
    public Identity Identity { get; private set; }


    public Person(Identity identity, StreetAdress streetAdress, Name name)
    {
        Identity = identity;
        StreetAdress = streetAdress;
        Name = name;

        AppendNotifications(Name, StreetAdress, Identity);
    }
}
