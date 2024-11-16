using Microsoft.EntityFrameworkCore;
using TraversalApi.DAL.Entities;

namespace TraversalApi.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-4C1D53L\\SQLEXPRESS; database=traversalNewApi; integrated security=true; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
