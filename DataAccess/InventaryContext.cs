using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }

        //Se configura la conexión a la BD
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost; Database=InventoryDB; Integrated Security=true;");
            }
        }

        //En el momento en que se crea el modelo se ejecutará una serie de pasos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity {  CategoryId = "ASH", CategoryName = "Aseo hogar" },
                new CategoryEntity {  CategoryId = "ASP", CategoryName = "Aseo personal" },
                new CategoryEntity {  CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity {  CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity {  CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity {  CategoryId = "VDJ", CategoryName = "Videojuegos" }
            );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAddress = "Calle 8 con 23" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "Calle 7 con 24" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Sur", WarehouseAddress = "Calle 6 con 25" }
            );
        }
    }
}