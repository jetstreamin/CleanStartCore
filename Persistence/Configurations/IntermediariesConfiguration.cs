using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Persistence.Configurations
{
    public class IntermediariesConfiguration : IEntityTypeConfiguration<Intermediary>
    {
        public void Configure(EntityTypeBuilder<Intermediary> builder)
        {
            builder.HasKey(e => e.IntermediaryId);

            builder.Property(e => e.IntermediaryId)
                .HasColumnName("IntermediaryID")
                .HasMaxLength(5)
                .ValueGeneratedNever();

            builder.Property(e => e.Address).HasMaxLength(60);

            builder.Property(e => e.City).HasMaxLength(15);

            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

            builder.Property(e => e.ContactName).HasMaxLength(30);

            builder.Property(e => e.ContactTitle).HasMaxLength(30);

            builder.Property(e => e.ContactEmail).HasMaxLength(255);

            builder.Property(e => e.Country).HasMaxLength(15);

            builder.Property(e => e.Fax).HasMaxLength(24);

            builder.Property(e => e.Phone).HasMaxLength(24);

            builder.Property(e => e.PostalCode).HasMaxLength(10);

            builder.Property(e => e.Region).HasMaxLength(15);
        }
    }
}
