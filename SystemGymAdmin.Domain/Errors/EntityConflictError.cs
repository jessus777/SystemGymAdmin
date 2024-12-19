using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String = SystemGymAdmin.Domain.Resources.String;

namespace SystemGymAdmin.Domain.Errors;
public sealed class EntityConflictError
    : DomainError
{
    public EntityConflictError(object identifier, string detail)
    {
        Identifier = identifier;
        Message = String.ElementoConflicto;
        Detail = detail;
    }

    public object Identifier { get; }
}
