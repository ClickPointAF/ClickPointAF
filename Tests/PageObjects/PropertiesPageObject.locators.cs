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
    public partial class PropertiePage
    {
        [Element("PropertieDuplicateDayTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "CampaignDetails_LeadTypeOptions_DuplicateDays")]
        public TextBox? PropertieDuplicateDayTextbox { get; }

        [Element("PropertieStandardizeAddressCheckbox", ElementType.CheckBox)]
        [Locator(LocatorType.XPath, "//input[@id='CampaignDetails_QualityOptions_StandardizeAddress']/following-sibling::span")]
        public CheckBox? PropertieStandardizeAddressTextbox { get; }

        [Element("PropertieAppendCityCheckbox", ElementType.CheckBox)]
        [Locator(LocatorType.XPath, "//input[@id='CampaignDetails_LeadTypeOptions_AppendCityState']/following-sibling::span")]
        public CheckBox? PropertieAppendCityTextbox { get; }

        [Element("PropertieMobileCheckCheckbox", ElementType.CheckBox)]
        [Locator(LocatorType.XPath, "//input[@id='CampaignDetails_TCPAOptions_MobileCheck']/following-sibling::span")]
        public CheckBox? PropertieMobileCheckTextbox { get; }

        [Element("PropertieGeolocateIPCheckbox", ElementType.CheckBox)]
        [Locator(LocatorType.XPath, "//input[@id='CampaignDetails_TCPAOptions_GeolocateIPAddressk']/following-sibling::span")]
        public CheckBox? PropertieGeolocateIPTextbox { get; }

        [Element("PropertieDeliveriesTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "CampaignDetails_QuantityLimitOptions_MaxSell")]
        public TextBox? PropertieDeliveriesTextbox { get; }

        [Element("PropertieDeliversToDropdown", ElementType.DropDown)]
        [Locator(LocatorType.Id, "CampaignDetails_AdditionalOptions_ExclusiveGroupUID")]
        public DropDown? PropertieDeliversToDropdown { get; }


        [Element("PropertieCreateButton", ElementType.Button)]
        [Locator(LocatorType.Id, "createSourceBtn")]
        public Button? PropertieCreateButton { get; }

    }
}
