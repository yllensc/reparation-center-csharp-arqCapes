using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");
        builder.Property(p => p.IdentificationDocument)
            .IsRequired()
            .HasMaxLength(12);
        builder.HasIndex(p => p.IdentificationDocument)
            .IsUnique();
        builder.Property(p => p.FirstName)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(p => p.LastName)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasMaxLength(12);
    }

}