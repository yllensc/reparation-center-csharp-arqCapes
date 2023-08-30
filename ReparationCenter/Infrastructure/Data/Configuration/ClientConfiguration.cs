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
         builder.HasOne(c => c.User)  // Client tiene una relación con User
        .WithMany(u => u.Clients)  // User tiene una colección de Clients
        .HasForeignKey(c => c.UserId)  // Clave foránea en Client
        .OnDelete(DeleteBehavior.Cascade); // se borra en cascada, de user y cliente
    }

}