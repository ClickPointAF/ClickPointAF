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
    [View("Propertie Page")]
    public partial class PropertiePage : BasePageObject
    {
        public PropertiePage(WebDriverFactory driverFactory) : base(driverFactory) { }
        public void CreatePropertie(Propertie propertie)
        {
            CreatePropertieWithData(propertie);
        }
    }
}
