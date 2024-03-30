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
    [View("Lead Source Page")]
    public partial class LeadSourcePage : BasePageObject
    {
        public LeadSourcePage(WebDriverFactory driverFactory) : base(driverFactory) { }
        public void CreateLead(LeadSource lead)
        {
            CreateLeadSource(lead);
        }

        public void DeleteLead(LeadSource lead)
        {
            DeleteLeadSource(lead);
        }
        public bool LeadSourceDisplayed(LeadSource lead)
        {
            if (IsDisplayed("LeadSourceIsDisplayed", "Lead Source Page", lead.Name!) &
            IsDisplayed("LeadSourceIsDisplayed", "Lead Source Page", lead.Email!))
            {
                return true;
            }
            return false;
        }
        public bool LeadSourceNotDisplayed(LeadSource lead)
        {
            if (IsNotDisplayed("LeadSourceIsDisplayed", "Lead Source Page", lead.Name!) &
            IsNotDisplayed("LeadSourceIsDisplayed", "Lead Source Page", lead.Email!))
            {
                return true;
            }
            return false;
        }
    }
}
