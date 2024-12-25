using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SystemGymAdmin.Application.Behaviors;
using FluentValidation;

namespace SystemGymAdmin.Application.Services;
public static class ApplicationLayerService
{
    public static IServiceCollection AddApplicationServiceLayer(this IServiceCollection services)
    {
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        return services;
    }
}
