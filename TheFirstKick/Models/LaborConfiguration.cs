using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TheFirstKick.Models
{
    public class LaborConfiguration : EntityTypeConfiguration<Labor>
    {
        public LaborConfiguration ()
        {
            Property(z => z.ServiceItemCode)
               .HasMaxLength(15)
               .IsRequired()
               .HasColumnAnnotation("Index"
              , new IndexAnnotation(new IndexAttribute("AK_labor",2) { IsUnique = true }));

            Property(z => z.WorkOrderId)
               .HasColumnAnnotation("Index",
              new IndexAnnotation(new IndexAttribute("AK_labor", 1) { IsUnique = true }));

            Property(z => z.ServiceItemName)
               .HasMaxLength(80)
               .IsRequired();

            Property(z => z.LaborHours).HasPrecision(18, 2);

            Property(z => z.Rate).HasPrecision(18, 2);

            Property(z => z.ExtendedPrice)
                .HasPrecision(18, 2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);


            Property(c => c.Notes)
                .HasMaxLength(140)
                .IsOptional();



        }
    }
}