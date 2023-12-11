using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure (EntityTypeBuilder<Rol> builder)
        {

            builder.ToTable("Rol");
            builder.Property(p => p.Id)
                .IsRequired();
            builder.Property(p => p.Nombre)
                .HasColumnName("rolName")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
