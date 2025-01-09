namespace SharedKernel
{
    public class Entity
    {
        private readonly List<IDomainEvent> _domainEvents = [];

        public List<IDomainEvent> DomainEvents => [.. _domainEvents];

        public void ClearDomainEvents() => _domainEvents.Clear();

        public void Rise(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
