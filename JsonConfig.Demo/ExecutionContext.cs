using System;
using JsonConfig.Core;

namespace JsonConfig.Demo
{
    public class ExecutionContext : IExecutionContext
    {
        public virtual string AppRootPath { get { return AppDomain.CurrentDomain.BaseDirectory; } }
    }
}