using Gusakov.TriangleCheck.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gusakov.TriangleCheck;

internal static class DependencyContainer
{
    internal static IServiceProvider GetContainer()
    {
        var services = new ServiceCollection();
        services.AddTransient<ICheckerTriangleService, CheckerTriangleService>();
        return services.BuildServiceProvider();
    }
}
