using WebDriverProvider.Classes;
using TestSolution.PageObjects;

namespace TestSolution.Helpers
{
    public class PageObjectHelper
    {
        private readonly WebDriverFactory _factory;
        public CommonPage CommonPageObject { get; private set; }
        public NavbarPage NavbarPageObject { get; private set; }
        public LeadSourcePage LeadSourcePage { get; private set; }

        public PageObjectHelper(WebDriverFactory factory)
        {
            _factory = factory;
            CommonPageObject = new CommonPage(_factory);
            NavbarPageObject = new NavbarPage(_factory);
            LeadSourcePage = new LeadSourcePage(_factory);
        }
    }
}

