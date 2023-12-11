using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TurnosConfiguration : IEntityTypeConfiguration<Turnos>
    {
        public void Configure(EntityTypeBuilder<Turnos> builder)
        {
            builder.ToTable("Turnos");
            builder.HasKey(e => e.Id).HasName("idTurno");

            builder.Property(a => a.nombreTurno)
                .HasColumnName("nombreTurno")
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(b => b.horaTurnoI)
                .HasColumnName("horaTurnoI")
                .HasColumnType("time")
                .IsRequired();

            builder.Property(b => b.horaTurnoF)
                .HasColumnName("horaTurnoI")
                .HasColumnType("time")
                .IsRequired();

        }
    }
}
