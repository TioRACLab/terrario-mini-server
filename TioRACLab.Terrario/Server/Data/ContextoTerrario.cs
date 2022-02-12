using Microsoft.EntityFrameworkCore;
using TioRACLab.Terrario.Shared;

namespace TioRACLab.Terrario.Server.Data
{
    public class ContextoTerrario : DbContext
    {
        public ContextoTerrario()
            : base() 
        { 
            Database.EnsureCreated();
        }

        public ContextoTerrario(DbContextOptions<ContextoTerrario> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<StatusTerrario> StatusTerrario { get; set; }
    }
}
