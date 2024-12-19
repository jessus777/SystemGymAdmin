using FluentResults;
using MediatR;
using System.Text.Json.Serialization;
using SystemGymAdmin.Domain;

namespace SystemGymAdmin.Application.Requests;
public abstract class ApplicationRequest<TResult> : IRequest<Result<TResult>>
{
    [JsonIgnore]
    public OperationContext Context { get; internal set; } = null!;
}

public abstract class ApplicationRequest : IRequest<Result>
{
    [JsonIgnore]
    public OperationContext Context { get; internal set; } = null!;
}
