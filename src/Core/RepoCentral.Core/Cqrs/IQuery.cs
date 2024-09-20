namespace RepoCentral.Core.Cqrs;

public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : notnull
{
}
