﻿using ConfigurationProvider.Classes;
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
            var elements = RetrieveElements("LeadSourceList", "Lead Source Page");
            bool containsName = elements.Any(element => element.Text.Contains(lead.Name!));
            return containsName;
        }
    }
}
