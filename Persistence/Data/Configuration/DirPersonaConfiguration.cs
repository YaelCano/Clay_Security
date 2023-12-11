using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DirPersonaConfiguration : IEntityTypeConfiguration<DirPersona>
    {
        public void Configure(EntityTypeBuilder<DirPersona> builder)
        {
            builder.ToTable("dirpersona");
            builder.HasKey(d => d.Id).HasName("Id");

            builder.HasOne(d => d.Persona)
            .WithMany(p => p.DirPersonas)
            .HasForeignKey(s => s.IdPersonaFk)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Fk_DirPersona_Persona");

            builder.HasOne(u => u.TipoDireccion)
                .WithMany(p => p.DirPersonas)
                .HasForeignKey(u => u.IdTipoDireccionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_DirPersona_TipoDireccion");
        }
    }
}
