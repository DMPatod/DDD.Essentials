using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Essentitals.Domain.Integrations
{
    public interface IIntegrationMessageHandler
    {
        IReadOnlyCollection<IIntegrationMessage> IntegrationMessages { get; }
        void Add<T>(T message)
            where T : IIntegrationMessage;
        Task DistributeAsync(CancellationToken cancellationToken = default);
    }
}
