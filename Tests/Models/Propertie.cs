using Microsoft.Extensions.Configuration;

namespace TestSolution.Models
{
    public class Propertie
    {
        public string? DuplicateDays { get; set; }
        public bool StandardizeAddress { get; set; }
        public bool AppendCity { get; set; }
        public bool MobileCheck { get; set; }
        public bool GeolocateIP { get; set; }
        public string? DeliveryCount { get; set; }
        public string? DeliversTo { get; set; }

        public Propertie()
        {
            DuplicateDays = string.Empty;
            StandardizeAddress = false;
            AppendCity = false;
            MobileCheck = false;
            GeolocateIP = false;
            DeliveryCount = string.Empty;
            DeliversTo = string.Empty;
        }
    }
}
