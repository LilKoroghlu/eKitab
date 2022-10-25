using eKitabWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace eKitabWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optioins) : base(optioins)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
