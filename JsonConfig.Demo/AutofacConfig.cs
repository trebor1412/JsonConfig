using Autofac;
using JsonConfig.Core;

namespace JsonConfig.Demo
{
    public class AutofacConfig
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AppPathProvider>()
                   .AsImplementedInterfaces();
            builder.RegisterType<JsonConfigProvider>()
                   .AsImplementedInterfaces();
            builder.RegisterModule<JsonConfigModule>();
            
            return builder.Build();
        }
    }
}