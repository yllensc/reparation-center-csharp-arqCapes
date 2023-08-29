using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Reflection;

namespace Infrastructure.Data;
    public class RepairContext: DbContext
    {
        public RepairContext(DbContextOptions<RepairContext> options): base(options){

        }
        public DbSet<Bill> Bills { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<Client> Clients { get; set;}
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Vehicle> Vehicles { get; set;}
        public DbSet<ItemRepair> ItemRepairs { get; set;}
        public DbSet<Order> Orders { get; set;}
        public DbSet<OrderEmployee> OrderEmployees { get; set;}
        


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //modelBuilder.Entity<ProductPerson>().HasKey(p => new{p.IdProductFK, p.IdPersonFK});
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

