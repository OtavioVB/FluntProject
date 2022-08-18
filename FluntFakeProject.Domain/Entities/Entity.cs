using Flunt.Notifications;


namespace FluntFakeProject.Domain.Entities;

public abstract class Entity : Notifiable
{
    public Guid Identifier { get; }

    protected Entity() => Identifier = Guid.NewGuid();
}
