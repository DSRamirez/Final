using Blazor.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        public DbSet<Turnos> Turnosdb { get; set; }
        public DbSet<Peluqueros> Peluquerosdb { get; set; }
        public DbSet<Productos> Productosdb { get; set; }
        public DbSet<Servicios> Serviciosdb { get; set; }
    }
}