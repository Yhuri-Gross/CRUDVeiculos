using Microsoft.EntityFrameworkCore;
using CrudVeiculos.Models;

namespace CrudVeiculos.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
