using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
           builder.ToTable("Order");
        // Configuración de propiedades de Order
        builder.Property(o => o.DateOrder)
            .IsRequired();
        builder.Property(o => o.NumPlate)
            .HasMaxLength(20);
        // ... otras propiedades
        
        // Configuración de la relación con Bill
        builder.HasOne(o => o.Bill)  // Order tiene una relación con Bill
            .WithOne(b => b.RepairOrder)  // Bill tiene una única orden asociada
            .HasForeignKey<Bill>(b => b.RepairOrderId)  // Clave foránea en Bill
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento de borrado, ajusta según tus necesidades
        
        // Configuración de la relación con Client
        builder.HasOne(o => o.Client)  // Order tiene una relación con Client
            .WithMany(c => c.Orders)  // Client tiene una colección de Orders
            .HasForeignKey(o => o.CustomerId)  // Clave foránea en Order
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento de borrado, ajusta según tus necesidades
        
        // Configuración de la relación con Vehicle
        builder.HasOne(o => o.Vehicle)  // Order tiene una relación con Vehicle
            .WithMany(v => v.Orders)  // Vehicle tiene una colección de Orders
            .HasForeignKey(o => o.VehicleId)  // Clave foránea en Order
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento de borrado, ajusta según tus necesidades
        }
    }
}