using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            // builder.HasIndex(e => e.IdPerson).IsUnique();
            builder.ToTable("Persona");
            builder.HasKey(e => e.Id).HasName("Id");

            builder.HasIndex(e => e.IdTPersonaFk).IsUnique();
            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre");

            builder.Property(e => e.FechaRegistro)
                .HasColumnType("date")
                .HasColumnName("FechaRegistro");

            builder.Property(r => r.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre");

            builder.HasOne(d => d.Cuidad)
                .WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdCuidadFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Persona_Ciudad");

            builder.HasOne(d => d.Categoria)
                .WithMany(p => p.personas)
                .HasForeignKey(d => d.IdCategoriaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Persona_Categoria");

            builder.HasOne(d => d.TipoPersona)
                .WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdTPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Persona_TipoPersona");
        }        
        }
    }

