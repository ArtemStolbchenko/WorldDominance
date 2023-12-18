using Microsoft.EntityFrameworkCore;
using WorldDomination.Models;

namespace WorldDomination.Databases
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Code> Codes { get; set; }

        public List<string> CodesString => Codes.ToList()
                                                .Select(code => code.ToString())
                                                .ToList();
    }
}
