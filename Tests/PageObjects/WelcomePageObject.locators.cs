﻿using ConfigurationProvider.Classes.Elements;
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

        [Element("ClosePopupButton", ElementType.Button)]
        [Locator(LocatorType.XPath, "//div[contains(.//h5[@class='modal-title'], 'Next Steps')]//div[@class='modal-footer']//button[@class='btn btn-secondary']")]
        public Button? ClosePopupButton { get; }
        

    }
}
