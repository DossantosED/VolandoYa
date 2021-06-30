using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolandoYa.Models
{
    public class VolandoYaContext : DbContext
    {
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Vuelo> Vuelos { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Aerolinea> Aerolineas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Tarjeta> Tajetas { get; set; }
        public DbSet<Boleto> Boletos { get; set; }

        public VolandoYaContext()
        {

        }

        public VolandoYaContext(DbContextOptions<VolandoYaContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DEREK\SQLEXPRESS;Initial Catalog=VolandoYa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }

        }
    }
}
