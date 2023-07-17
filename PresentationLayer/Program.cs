using BusinessLayer_;
using BusinessLayer_.BL_Abstract;
using BusinessLayer_.DependencyInjection.Microsoft;
using DataAccessLayer_;
using DataAccessLayer_.DA_Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace PresentationLayer
{
    public class Program
    {
        public static void ResolveApp(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IBirimlerService_, Birimler_Manager>();
            serviceCollection.AddSingleton<IPersonellerService_, Personeller_Manager>();
            serviceCollection.AddSingleton<IViewPersonelBirimService_, ViewPersonelBirim_Manager>();

            ServiceProvider provider = serviceCollection.BuildServiceProvider();
            
        }

        
        static void Main(string[] args)
        {
            var service =
        }
      
    }
}
