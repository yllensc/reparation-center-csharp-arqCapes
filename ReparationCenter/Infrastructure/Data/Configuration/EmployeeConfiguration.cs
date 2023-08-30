using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.Property(p => p.Specialty)
            .HasMaxLength(100);
            builder.HasOne(c => c.User)  // Client tiene una relación con User
           .WithMany(u => u.Employees)  // User tiene una colección de Clients
           .HasForeignKey(c => c.UserId)  // Clave foránea en Client
           .OnDelete(DeleteBehavior.Cascade); // se borra en cascada, de user y cliente
        }
    }
}