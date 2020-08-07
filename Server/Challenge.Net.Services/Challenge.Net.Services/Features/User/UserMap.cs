using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Features.User
{
    public class UserMap : EntityTypeConfiguration<UserAgg>
    {
        public UserMap()
        {
            HasKey(t => t.Id);
            ToTable("User", "dbo");
            Property(t => t.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.UId).HasColumnName("UId").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(t => t.Name).HasColumnName("Name").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}