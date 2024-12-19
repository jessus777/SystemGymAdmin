using String = SystemGymAdmin.Domain.Resources.String;


namespace SystemGymAdmin.Domain.Errors;
public sealed class DuplicateEntityError
    : DomainError
{
    public DuplicateEntityError(object identifier)
    {
        Identifier = identifier;
        Message = String.ElementoDuplicado;
        Detail = string.Format(String.YaExisteElementoX, identifier);
    }

    public object Identifier { get; }
}
