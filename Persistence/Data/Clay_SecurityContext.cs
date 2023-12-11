using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class Clay_SecurityContext : DbContext
    {
        public Clay_SecurityContext(DbContextOptions<Clay_SecurityContext> options) : base(options)
        {
        }

        public DbSet<CategoriaPer> CategoriaPers { get; set; }
        public DbSet<ContactoPer> ContactoPers { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Cuidad> Cuidads { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<DirPersona> DirPersonas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Programacion> Programacions { get; set; }
        public DbSet<TipoContacto> TipoContactos { get; set; }
        public DbSet<TipoDireccion> TipoDireccions { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<Turnos> Turnoss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
