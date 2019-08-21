using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZbW.CarRentify.CarManagement.Domain;

namespace ZbW.CarRentify.CarManagement.Infrastructure
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var carEntity = modelBuilder.Entity<Car>();
            carEntity.HasKey(x => x.Id);
            carEntity.HasOne(x => x.Model);
            carEntity.UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            var brandEntity = modelBuilder.Entity<Brand>();
            brandEntity.HasKey(x => x.Id);
            brandEntity.HasMany(x => x.Models);
            brandEntity.UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            var carClassEntity = modelBuilder.Entity<CarClass>();
            carClassEntity.HasKey(x => x.Id);
            carClassEntity.UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);

            var modelEntity = modelBuilder.Entity<Model>();
            modelEntity.HasKey(x => x.Id);
            modelEntity.HasOne(x => x.CarClass);
            modelEntity.UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction);
            base.OnModelCreating(modelBuilder);

        }
    }
}