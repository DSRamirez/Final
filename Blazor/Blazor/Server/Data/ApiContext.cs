using Microsoft.EntityFrameworkCore;
using Blazor.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        public DbSet<Turnos> Turnos { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Peluqueros> Peluqueros { get; set; }
    }
}
