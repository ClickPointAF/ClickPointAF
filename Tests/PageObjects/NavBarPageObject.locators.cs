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
    public partial class NavbarPage
    {
        [Element("NavBarButtons", ElementType.Button)]
        [Locator(LocatorType.XPath, "//ul[@id='sideBarPanel']//a[contains(normalize-space(), '{0}')]")]
        public Button? NavBarButtons { get; }
    }
}
