using Microsoft.Extensions.Configuration;

namespace TestSolution.Models
{
    public class LeadSource
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        public LeadSource()
        {
            Name = string.Empty;
            Email = string.Empty;
            Country = string.Empty;
            Address = string.Empty;
            Address2 = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
        }
    }
}
