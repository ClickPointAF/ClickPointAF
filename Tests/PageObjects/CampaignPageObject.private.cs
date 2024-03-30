using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Models;

namespace TestSolution.PageObjects
{
    public partial class CampaignPage
    {
        private void CreateCampaignWithData(Campaign campaign)
        {
            try
            {
                WriteInput("CampaignNameTextbox", "Campaign Page", campaign.Name!);
                SelectElementByText("CampaignChannelDropdown", "Campaign Page", campaign.Channel!);
                SelectElementByText("CampaignLeadTypeDropdown", "Campaign Page", campaign.LeadType!);
                WriteInput("CampaignPriceTextbox", "Campaign Page", campaign.Price!);
                if(!campaign.RequireAuth)
                {
                    UncheckElement("CampaignRequireAuthCheckbox", "Campaign Page");
                }
                ClickButton("CampaignNextButton", "Campaign Page");
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to Create a Campaign. {e.Message}.", e.InnerException);
            }
        }
    }
}
