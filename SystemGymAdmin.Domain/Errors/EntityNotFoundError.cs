using String = SystemGymAdmin.Domain.Resources.String;

namespace SystemGymAdmin.Domain.Errors;
public sealed class EntityNotFoundError
    : DomainError
{
    public EntityNotFoundError(object identifier)
    {
        Identifier = identifier;
        Message = String.ElementoNoEncontrado;
        Detail = string.Format(String.NoSeEncontroElementoConId, identifier);
    }

    public object Identifier { get; }
}
