using Microsoft.EntityFrameworkCore;
using WorldDomination.Models;

namespace WorldDomination.Databases
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
