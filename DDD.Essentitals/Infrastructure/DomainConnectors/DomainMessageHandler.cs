using DDD.Essentitals.Domain.Commons;
using DDD.Essentitals.Domain.DomainEvents;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace DDD.Essentitals.Infrastructure.DomainConnectors
{
    public class DomainMessageHandler : IDomainMessageHandler
    {
        private readonly IMediator mediator;

        public DomainMessageHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public Task PublishAsync<T>(T domainEvent, CancellationToken cancellationToken) where T : IDomainEvent
        {
            return mediator.Publish(domainEvent, cancellationToken);
        }

        public Task SendAsync(ICommand domainCommand, CancellationToken cancellationToken)
        {
            return mediator.Send(domainCommand, cancellationToken);
        }

        public Task<TResponse> SendAsync<TResponse>(ICommand<TResponse> domainCommand, CancellationToken cancellationToken)
        {
            return mediator.Send(domainCommand, cancellationToken);
        }
    }
    public static class DomainMessageHandlerDIExtension
    {
        public static IServiceCollection AddDomainMessageHandler(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.AddMediatR(assemblies);
            services.TryAddTransient<IDomainMessageHandler, DomainMessageHandler>();
            return services;
        }
    }
}
