using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContactoPerConfiguration : IEntityTypeConfiguration<ContactoPer>
    {
        public void Configure(EntityTypeBuilder<ContactoPer> builder)
        {
            builder.ToTable("ContactoPer");
            builder.HasKey(c => c.Id).HasName("Id");

            builder.Property( e => e.descripcion)
            .HasColumnName("descripcion")
            .HasMaxLength(60)
            .IsUnicode(false)
            .IsRequired();

            builder.HasIndex(t => t.descripcion).IsUnique();

            builder.HasOne( d => d.TipoContacto)
            .WithMany(p => p.ContactoPers)
            .HasForeignKey(k => k.IdTContactoFK)
            .OnDelete(DeleteBehavior.ClientNoAction)
            .HasConstraintName("Fk_ContactoPer_TipoContacto");

            builder.HasOne(t => t.Persona)
            .WithMany(p => p.ContactoPers)
            .HasForeignKey(u => u.IdTPersonaFk)
            .OnDelete(DeleteBehavior.ClientNoAction)
            .HasConstraintName("Fk_ContactoPer_Persona");
        }
    }
}
