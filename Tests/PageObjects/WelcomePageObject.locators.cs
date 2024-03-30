using ConfigurationProvider.Classes.Elements;
using ConfigurationProvider.Classes;
using ConfigurationProvider.Elements;
using ConfigurationProvider.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.PageObjects
{
    public partial class WelcomePage
    {
        [Element("CreateLeadSourceButton", ElementType.Button)]
        [Locator(LocatorType.XPath, "//button[text()='Create a Lead Source']")]
        public Button? CreateLeadSourceButton { get; }
    }
}
