using ConfigurationProvider.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Models;
using WebDriverProvider.Classes;

namespace TestSolution.PageObjects
{
    [View("Login Page")]
    public partial class LoginPage : BasePageObject
    {
        public LoginPage(WebDriverFactory driverFactory) : base(driverFactory) { }
        public void LoginUser(User user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            LoginWithCredentials(user);
        }
    }
}
