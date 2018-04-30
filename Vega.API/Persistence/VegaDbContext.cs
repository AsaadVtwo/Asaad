using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Vega.api.Models;
using Vega.API.Models;

namespace Vega.api.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext( DbContextOptions<VegaDbContext> options)
             : base(options)
        {
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}