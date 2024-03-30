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
    [View("Campaign Page")]
    public partial class CampaignPage : BasePageObject
    {
        public CampaignPage(WebDriverFactory driverFactory) : base(driverFactory) { }
        public void CreateCampaign(Campaign campaign)
        {
            CreateCampaignWithData(campaign);
        }
    }
}
