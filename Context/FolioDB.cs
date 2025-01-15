using Folio.Models;
using Microsoft.EntityFrameworkCore;

namespace Folio.Context
{
    public class FolioDB : DbContext
    {
        public DbSet<AdminModel> AdminModels { get; set; }
        public DbSet<HomeModel> HomeModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PDRSFJK\\SQLEXPRESS;Database=MyFolio;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
