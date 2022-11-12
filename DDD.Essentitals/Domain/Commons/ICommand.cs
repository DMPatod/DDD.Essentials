using MediatR;

namespace DDD.Essentitals.Domain.Commons
{
    public interface ICommand : ICommand<bool>
    {
    }
    public interface ICommand<out T> : IRequest<T>
    {
    }
}
