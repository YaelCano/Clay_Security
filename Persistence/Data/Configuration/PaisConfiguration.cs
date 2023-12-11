using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");
            builder.HasKey(e => e.Id).HasName("Id");

            builder.Property(u => u.NombrePais)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode()
                .HasColumnName("nombrePais");

        }
    }
}
