using BusinessRuleEngine.Rules.Implementation;
using BusinessRuleEngine.Rules.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessRuleEngine.Helpers
{
    public class DependencyResolver<T>
    {
        public T CreateProductInstance()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IPackageable, PackageableProduct>();
            serviceCollection.AddTransient<INotification, NotifiableProduct>();
            serviceCollection.AddTransient<IAgentCommission, AgentCommissionProduct>();
            serviceCollection.AddTransient<IPrint, Printable>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return ActivatorUtilities.CreateInstance<T>(serviceProvider);
        }
    }
}
