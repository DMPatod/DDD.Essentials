namespace DDD.Essentitals.Domain.DomainEvents
{
    public interface IDomainEventHandler<in TDomainEvent>
        where TDomainEvent : IDomainEvent
    {
    }
}
