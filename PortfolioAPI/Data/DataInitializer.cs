using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Models;

namespace PortfolioAPI.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;

        public DataInitializer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void MigrateData()
        {
            _dbContext.Database.Migrate();
            SeedData();
            _dbContext.SaveChanges();
        }

        private void SeedData()
        {
            //throw new NotImplementedException();
            if (!_dbContext.PortfolioAPIS
                    .Any(e => e.name == "BankApp"))
            {
                _dbContext.Add(new PortfolioAPIC
                {
                    PortfolioAPIID = 1,
                    description = "Bank App Karam",
                    link = "https://karambank.azurewebsites.net/"
                });
            }

        }
    }

}
