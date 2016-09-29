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
    public class CustomerConfiguration :EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            Property(cu => cu.AccountantNumber)
               .HasMaxLength(8)
               .IsRequired()
               .HasColumnAnnotation("Index",
               new IndexAnnotation(new IndexAttribute("AK_Customer_AccountantNumber") { IsUnique = true }));

            Property(cu => cu.CompanyName)
                .HasMaxLength(30)
                .IsRequired();

            Property(cu => cu.Address)
               .HasMaxLength(30)
               .IsRequired();

            Property(cu => cu.City)
               .HasMaxLength(15)
               .IsRequired();

            Property(cu => cu.State)
               .HasMaxLength(2)
               .IsRequired();

            Property(c => c.ZipCode)
               .HasMaxLength(10)
               .IsRequired();

            Property(c => c.Phone)
               .HasMaxLength(15)
               .IsOptional();


        }
    }
}