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
    [View("Navbar Page")]
    public partial class NavbarPage : BasePageObject
    {
        public NavbarPage(WebDriverFactory driverFactory) : base(driverFactory) { }

    }
}
