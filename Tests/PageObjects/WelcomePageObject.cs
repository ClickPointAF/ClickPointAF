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
    [View("Welcome Page")]
    public partial class WelcomePage : BasePageObject
    {
        public WelcomePage(WebDriverFactory driverFactory) : base(driverFactory) { }
        public void CreateLead()
        {
            ClickButton("CreateLeadSourceButton", "Welcome Page");
        }
    }
}
