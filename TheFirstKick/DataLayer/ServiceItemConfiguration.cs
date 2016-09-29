using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using TheFirstKick.Models;


namespace TheFirstKick.DataLayer
{
    public class ServiceItemConfiguration : EntityTypeConfiguration<ServiceItem>
    {
        public ServiceItemConfiguration()
        {
            Property(s => s.ServiceItemCode)
                .HasMaxLength(15)
                .IsRequired()
                .HasColumnAnnotation("Index"
               , new IndexAnnotation(new IndexAttribute("AK_ServiceItem_ServiceItemCode") { IsUnique = true }));

            Property(s => s.ServiceItemName)
                .HasMaxLength(80)
                .IsRequired()
                .HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("AK_ServiceItem_ServiceItemName") { IsUnique = true }));

            Property(s => s.Rate).HasPrecision(18, 2); 
        }
    }
}