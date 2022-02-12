using Microsoft.EntityFrameworkCore;
using TioRACLab.Terrario.Shared;

namespace TioRACLab.Terrario.Server.Data
{
    public class ContextoTerrario : DbContext
    {
        public ContextoTerrario()
            : base() { }

        public ContextoTerrario(DbContextOptions<ContextoTerrario> options)
            : base(options) { }

        public DbSet<StatusTerrario> StatusTerrario { get; set; }
    }
}
