using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Models;

namespace ConfigurationProvider.Classes
{
    public class AppSettings
    {
        private static readonly Lazy<AppSettings> _instance = new Lazy<AppSettings>(() => new AppSettings());
        public static AppSettings Instance => _instance.Value;

        public User AdminUser { get; private set; }

        private AppSettings()
        {
            AdminUser = new User
            {
                Email = ConfigBuilder.Instance.GetString("ADMINUSER_EMAIL"),
                Password = ConfigBuilder.Instance.GetString("ADMINUSER_PASSWORD"),
            };
        }
    }
}
