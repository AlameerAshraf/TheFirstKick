using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TheFirstKick.Models;


namespace TheFirstKick.DataLayer
{
    public class InventoryItemConfiguration : EntityTypeConfiguration<InventoryItem>
    {
        public InventoryItemConfiguration ()
        {
            Property(ia => ia.InventoryItemCode)
                .HasMaxLength(15)
                .IsRequired()
                .HasColumnAnnotation("Index"
               , new IndexAnnotation(new IndexAttribute("AK_InventoryItem_InventoryItemCode") { IsUnique = true }));

            Property(ia => ia.InventoryItemName)
                .HasMaxLength(80)
                .IsRequired()
                .HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("AK_InventoryItem_InventoryItemName") { IsUnique = true }));

            Property(ia => ia.UnitPrice).HasPrecision(18, 2);
        }
    }
}