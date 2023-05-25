using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Data;

namespace PortfolioAPI.Controllers
{
    public class PortfolioAPIk : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public PortfolioAPIk(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
