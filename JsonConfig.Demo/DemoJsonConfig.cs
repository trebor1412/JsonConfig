using System.Collections.Generic;

namespace JsonConfig.Demo
{
    public class DemoJsonConfig
    {
        public string Host { get; set; }
        public string Port { get; set; }

        public List<Account> Accounts { get; set; }
    }

    public class Account
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
    }
}
