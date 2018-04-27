using Autofac;
using JsonConfig.Core;
using System.Linq;
using System.Reflection;

namespace JsonConfig.Demo
{
    public class JsonConfigModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var settings = Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(t => t.Name.EndsWith("JsonConfig"))
                                   .ToList();

            settings.ForEach(type =>
            {
                builder.Register(c => c.Resolve<IJsonConfigProvider>().LoadSection(type))
                       .As(type)
                       .SingleInstance();
            });
        }
    }
}