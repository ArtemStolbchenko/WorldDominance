using Microsoft.EntityFrameworkCore;
using WorldDomination.Models;

namespace WorldDomination.Databases
{
    public class CodeDbContext : DbContext
    {
        public CodeDbContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<Code> codes { get; set; }

    }
}
