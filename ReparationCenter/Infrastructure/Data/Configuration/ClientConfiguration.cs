using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Client");
        builder.Property(p => p.DateRegister)
            .IsRequired();
        builder.Property(p => p.Email)
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