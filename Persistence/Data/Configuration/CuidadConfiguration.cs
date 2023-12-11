using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CuidadConfiguration : IEntityTypeConfiguration<Cuidad>
    {
        public void Configure(EntityTypeBuilder<Cuidad> builder)
        {
            builder.ToTable("Ciudad");
            builder.HasKey(x => x.Id).HasName("Id");

            builder.Property(z => z.nombreCiu)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("NombreCiudad");

            builder.HasOne(R => R.Departamento)
            .WithMany(O => O.Cuidads)
            .HasForeignKey(d => d.IdDepartamentoFk)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Fk_Ciudad_Departamento")
        }
    }
}
