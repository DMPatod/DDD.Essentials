﻿using DDD.Essentitals.Domain.Commons;

namespace DDD.Essentitals.Domain.DomainEvents
{
    public interface IDomainMessageHandler
    {
        Task PublishAsync<T>(T domainEvent, CancellationToken cancellationToken)
            where T : IDomainEvent;
        Task SendAsync(ICommand domainCommand, CancellationToken cancellationToken);
        Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> domainCommand, CancellationToken cancellationToken);
    }
}
