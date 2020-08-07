using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Features.Review
{
    public class ReviewMap : EntityTypeConfiguration<ReviewAgg>
    {
        public ReviewMap()
        {
            HasKey(t => t.Id);
            ToTable("Review", "dbo");
            Property(t => t.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.IsSealPresent).HasColumnName("IsSealPresent").IsRequired();
            Property(t => t.IsHazard).HasColumnName("IsHazard").IsRequired();
            Property(t => t.IsDamaggeFound).HasColumnName("IsDamaggeFound").IsRequired();
            Property(t => t.Note).HasColumnName("Note").HasMaxLength(100).IsUnicode(false);
        }
    }
}