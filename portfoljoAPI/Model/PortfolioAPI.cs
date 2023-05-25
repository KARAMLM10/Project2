using System.ComponentModel.DataAnnotations;
namespace portfoljoAPI.Model
{
    public class PortfolioAPI
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
