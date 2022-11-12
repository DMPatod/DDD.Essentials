using System.Collections.Concurrent;

namespace DDD.Essentitals.Domain.DomainEvents
{
    public abstract class DomainEventHolder
    {
        private readonly ConcurrentQueue<IDomainEvent> domainEvents = new();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.ToList().AsReadOnly();
        protected void AddDomainEvent<T>(T domainEvent)
            where T : IDomainEvent
        {
            domainEvents.Enqueue(domainEvent);
        }
        public bool TryRemoveDomainEvent(out IDomainEvent domainEvent)
        {
            return domainEvents.TryDequeue(out domainEvent!);
        }
    }
}
