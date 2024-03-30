using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Models;

namespace TestSolution.PageObjects
{
    public partial class LeadSourcePage
    {
        private void CreateLeadSource(LeadSource lead)
        {
            try
            {
                WriteInput("LeadSourceNameTextbox", "Lead Source Page", lead.Name!);
                WriteInput("LeadSourceEmailTextbox", "Lead Source Page", lead.Email!);
                SelectElementByValue("LeadSourceCountrySelect", "Lead Source Page", lead.Country!);
                WriteInput("LeadSourceAddressTextbox", "Lead Source Page", lead.Address!);
                WriteInput("LeadSourceAddress2Textbox", "Lead Source Page", lead.Address2!);
                WriteInput("LeadSourceCityTextbox", "Lead Source Page", lead.City!);
                SelectElementByText("LeadSourceStateSelect", "Lead Source Page", lead.State!);
                WriteInput("LeadSourceZipCodeTextbox", "Lead Source Page", lead.ZipCode!);
                ClickButton("LeadSourceNextButton", "Lead Source Page");
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to Create a Lead Source. {e.Message}.", e.InnerException);
            }
        }

        private void DeleteLeadSource(LeadSource lead)
        {
            try
            {
                ClickButton("LeadSourceRow", "Lead Source Page", lead.Name!, lead.Email!);
                ClickButton("LeadSourceDeleteButton", "Lead Source Page");
                ClickButton("LeadSourceConfirmDelete", "Lead Source Page");
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to Delete a Lead Source. {e.Message}.", e.InnerException);
            }
        }
    }
}
