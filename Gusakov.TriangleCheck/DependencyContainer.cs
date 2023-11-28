using FluentValidation;
using Gusakov.TriangleCheck.Commands.Validation;
using Gusakov.TriangleCheck.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gusakov.TriangleCheck;

internal static class DependencyContainer
{
    internal static IServiceProvider GetContainer()
    {
        var services = new ServiceCollection();

        services.AddTransient<ICheckerTriangleService, CheckerTriangleService>();
        services.AddValidatorsFromAssemblyContaining<CheckTriangleCommandValidator>();

        return services.BuildServiceProvider();
    }
}
