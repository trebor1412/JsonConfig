using Autofac;
using System;

namespace JsonConfig.Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = AutofacConfig.Register();

            var config = container.Resolve<DemoJsonConfig>();
            Console.WriteLine($"Host:{config.Host}");
            Console.WriteLine($"Host:{config.Port}");
            foreach (var account in config.Accounts)
            {
                Console.WriteLine($"Name:{account.Name}, IsAdmin:{account.IsAdmin}");                
            }

            Console.ReadLine();
        }
    }
}