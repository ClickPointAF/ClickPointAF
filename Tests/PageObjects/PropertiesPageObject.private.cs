using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Models;

namespace TestSolution.PageObjects
{
    public partial class PropertiePage
    {
        private void CreatePropertieWithData(Propertie propertie)
        {
            try
            {
                WriteInput("PropertieDuplicateDayTextbox", "Propertie Page", propertie.DuplicateDays!);
                if(propertie.StandardizeAddress)
                {
                    CheckElement("PropertieStandardizeAddressCheckbox", "Propertie Page");
                }
                if (propertie.AppendCity)
                {
                    CheckElement("PropertieAppendCityCheckbox", "Propertie Page");
                }
                if (propertie.MobileCheck)
                {
                    CheckElement("PropertieMobileCheckCheckbox", "Propertie Page");
                }
                if (propertie.GeolocateIP)
                {
                    CheckElement("PropertieGeolocateIPCheckbox", "Propertie Page");
                }
                WriteInput("PropertieDeliveriesTextbox", "Propertie Page", propertie.DuplicateDays!);
                SelectElementByText("PropertieDeliversToDropdown", "Propertie Page", propertie.DeliversTo!);
                ClickButton("PropertieCreateButton", "Propertie Page");
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to Create a Propertie. {e.Message}.", e.InnerException);
            }
        }
    }
}
