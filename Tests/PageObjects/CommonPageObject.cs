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
    [View("Common Page")]
    public partial class CommonPage : BasePageObject
    {
        public CommonPage(WebDriverFactory driverFactory) : base(driverFactory) { }
    }
}
