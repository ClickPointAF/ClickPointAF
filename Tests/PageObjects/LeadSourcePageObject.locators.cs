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
    public partial class LeadSourcePage
    {
        [Element("Create Button", ElementType.Button)]
        [Locator(LocatorType.Id, "createLeadSourceBtn")]
        public Button? CreateButton { get; }

        [Element("LeadSourceNameTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "Name")]
        public TextBox? LeadSourceNameTextbox { get; }

        [Element("LeadSourceEmailTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "Email")]
        public TextBox? LeadSourceEmailTextbox { get; }

        [Element("LeadSourceCountrySelect", ElementType.DropDown)]
        [Locator(LocatorType.Id, "Country")]
        public DropDown? LeadSourceCountrySelect { get; }

        [Element("LeadSourceAddressTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "Address")]
        public TextBox? LeadSourceAddressTextbox { get; }

        [Element("LeadSourceAddress2Textbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "Address2")]
        public TextBox? LeadSourceAddress2Textbox { get; }

        [Element("LeadSourceCityTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "City")]
        public TextBox? LeadSourceCityTextbox { get; }

        [Element("LeadSourceStateSelect", ElementType.DropDown)]
        [Locator(LocatorType.Id, "State")]
        public DropDown? LeadSourceStateSelect { get; }

        [Element("LeadSourceZipCodeTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "Zip")]
        public TextBox? LeadSourceZipCodeTextbox { get; }

        [Element("LeadSourceNextButton", ElementType.Button)]
        [Locator(LocatorType.XPath, "//a[contains(text(), 'Next')]")]
        public Button? LeadSourceNextButton { get; }

        [Element("LeadSourceIsDisplayed", ElementType.Button)]
        [Locator(LocatorType.XPath, "//tbody[@role='presentation']//tr[@role='row']//td[contains(text(), '{0}')]")]
        public Button? LeadSourceIsDisplayed { get; }
    }
}
