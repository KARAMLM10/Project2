using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    public class PortfolioAPIC
    {
        [Key]
        public int PortfolioAPIID { get; set; }
        public string name { get; set;}
        public string description { get; set;}
        public string link { get; set; }
    }
}
