using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoContactoConfiguration : IEntityTypeConfiguration<TipoContacto>
    {
        public void Configure(EntityTypeBuilder<TipoContacto> builder)
        {
            builder.ToTable("TipoContacto");
            builder.HasKey(e => e.Id).HasName("Id");

            builder.Property(e => e.descripcion)
                .HasColumnName("descripcion")
                .HasMaxLength(60)
                .IsUnicode(false);
        }
    }
}
