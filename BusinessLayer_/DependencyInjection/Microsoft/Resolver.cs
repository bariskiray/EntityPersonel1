using BusinessLayer_.BL_Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_.DependencyInjection.Microsoft
{
    public static class Resolver
    {
        public static void ResolveApp(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IBirimlerService_, Birimler_Manager>();
            serviceCollection.AddSingleton<IPersonellerService_, Personeller_Manager>();
            serviceCollection.AddSingleton<IViewPersonelBirimService_, ViewPersonelBirim_Manager>();

            ServiceProvider provider = serviceCollection.BuildServiceProvider();
            provider.GetService<Personeller_Manager>();
        }
    }
}
