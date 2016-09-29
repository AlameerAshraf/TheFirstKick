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
    public class WorkOrderConfiguration : EntityTypeConfiguration<WorkOrder>
    {
        public WorkOrderConfiguration ()
        {
            Property(w => w.OrderDateTime).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(w => w.Description).HasMaxLength(256).IsOptional();

            Property(w => w.Total).HasPrecision(18, 2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(w => w.CertificationRequierments).HasMaxLength(120).IsOptional();
        }
    }
}