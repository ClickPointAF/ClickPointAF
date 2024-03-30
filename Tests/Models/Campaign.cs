using Microsoft.Extensions.Configuration;

namespace TestSolution.Models
{
    public class Campaign
    {
        public string? Name { get; set; }
        public string? Channel { get; set; }
        public string? LeadType { get; set; }
        public string? Price { get; set; }
        public bool RequireAuth { get; set; }

        public Campaign()
        {
            Name = string.Empty;
            Channel = string.Empty;
            LeadType = string.Empty;
            Price = string.Empty;
            RequireAuth = false;
        }
    }
}
