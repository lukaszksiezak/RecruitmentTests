using Microsoft.Extensions.DependencyInjection;
using Recruitment.Diamond.Presenters;

namespace Recruitment.Diamond
{
    internal static class Startup
    {
        internal static ServiceCollection GetServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IDiamondGenerator, DiamondGenerator>();
            serviceCollection.AddSingleton<IPresenter, ConsolePresenter>();
            serviceCollection.AddSingleton<DiamondService>();

            return serviceCollection;
        }
    }
}
