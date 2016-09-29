using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TheFirstKick.Models
{
    public class PartConfiguration : EntityTypeConfiguration<Part>
    {
       public PartConfiguration()
        {
            Property(c => c.InventoryItemCode)
                .HasMaxLength(15)
                .IsRequired()
                .HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("AK_Part",2) { IsUnique = true }));

            Property(c => c.WorkOrderId)
                 .HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("AK_Part", 1) { IsUnique = true }));

            Property(c => c.InventoryItemName)
                .HasMaxLength(80)
                .IsRequired();

            Property(c => c.UnitPrice).HasPrecision(18, 2);

            Property(c => c.ExtendedPrice)
                .HasPrecision(18, 2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(c => c.Notes)
                .HasMaxLength(140)
                .IsOptional();

        }
    }
}