using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
    {
        public void Configure(EntityTypeBuilder<Programacion> builder)
        {
            builder.ToTable("programacion");
            builder.HasKey(e => e.Id).HasName("Id");

            
        }
    }
}
