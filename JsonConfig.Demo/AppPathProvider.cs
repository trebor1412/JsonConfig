using System;
using JsonConfig.Core;

namespace JsonConfig.Demo
{
    public class AppPathProvider : IAppPathProvider
    {
        public virtual string JsonConfigPath { get { return AppDomain.CurrentDomain.BaseDirectory; } }
    }
}