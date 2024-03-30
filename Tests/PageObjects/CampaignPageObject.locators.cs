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
    public partial class CampaignPage
    {
        [Element("CampaignNameTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "CampaignDetails_GeneralOptions_Name")]
        public TextBox? CampaignNameTextbox { get; }

        [Element("CampaignChannelDropdown", ElementType.DropDown)]
        [Locator(LocatorType.Id, "CampaignDetails_Channel")]
        public DropDown? CampaignChannelDropdown { get; }

        [Element("CampaignLeadTypeDropdown", ElementType.DropDown)]
        [Locator(LocatorType.Id, "CampaignDetails_LeadTypeOptions_LeadTypeUID")]
        public DropDown? CampaignLeadTypeDropdown { get; }

        [Element("CampaignPriceTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "CampaignDetails_GeneralOptions_Price")]
        public TextBox? CampaignPriceTextbox { get; }

        [Element("EditCampaignPriceTextbox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "GeneralOptions_Price")]
        public TextBox? EditCampaignPriceTextbox { get; }

        [Element("CampaignRequireAuthCheckbox", ElementType.CheckBox)]
        [Locator(LocatorType.XPath, "//input[@id='CampaignDetails_GeneralOptions_RequiresAuthentication']/following-sibling::span")]
        public CheckBox? CampaignRequireAuthCheckbox { get; }

        [Element("CampaignNextButton", ElementType.Button)]
        [Locator(LocatorType.Id, "createNextBtn")]
        public Button? CampaignNextButton { get; }

        [Element("CampaignRow", ElementType.Button)]
        [Locator(LocatorType.XPath, "//tr[td[contains(text(), '{0}')] and td[contains(text(), '{1}')]]")]
        public Button? CampaignRow { get; }

        [Element("CampaignSave", ElementType.Button)]
        [Locator(LocatorType.Id, "btnCampaignSave")]
        public Button? CampaignSave { get; }

    }
}
