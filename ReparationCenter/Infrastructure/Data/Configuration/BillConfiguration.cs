using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
    public class BillConfiguration: IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.ToTable("Bill");
        builder.Property(p => p.Date)
            .IsRequired();
        builder.Property(p => p.Total)
            .IsRequired()
            .HasMaxLength(20);
       builder.HasOne(b => b.RepairOrder)  // Bill tiene una relación con Order
            .WithOne(o => o.Bill)  // Order tiene una única factura asociada
            .HasForeignKey<Bill>(b => b.RepairOrderId)  // Clave foránea en Bill
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento de borrado, ajusta según tus necesidades
     }
}