using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.ToTable("Contrato");

            builder.HasKey(j => j.Id).HasName("id");
            builder.Property(e => e.fechaContrato)
            .HasColumnType("date")
            .HasColumnName("fechaContrato");

            builder.Property(u => u.fechaFin)
            .HasColumnType("date")
            .HasColumnName("fechaFin");

            builder.HasOne(c => c.Empleado)
            .WithMany(c => c.Contratos)
            .HasForeignKey( y => y.IdEmpleadoFk)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Fk_Contrato_Empleado");

            builder.HasOne(c => c.Estado)
            .WithMany(c => c.Contratos)
            .HasForeignKey( y => y.IdEmpleadoFk)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Fk_Contrato_Empleado");

        }
    }
}
