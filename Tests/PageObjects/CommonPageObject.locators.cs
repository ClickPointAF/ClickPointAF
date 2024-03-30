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
    public partial class CommonPage
    {
        [Element("CommonButton", ElementType.Button)]
        [Locator(LocatorType.XPath, "//*[contains(text(), '{0}')]")]
        public Button? CommonButton { get; }
    }
}
