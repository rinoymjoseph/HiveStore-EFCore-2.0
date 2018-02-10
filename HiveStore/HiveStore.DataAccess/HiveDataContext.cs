﻿using HiveStore.DataAccess.Employee.Configuration;
using HiveStore.DataAccess.Order.Configuration;
using HiveStore.DataAccess.Product.Configuration;
using HiveStore.Entity.Employee;
using HiveStore.Entity.Order;
using HiveStore.Entity.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HiveStore.DataAccess
{
    public class HiveDataContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderDetailsEntity> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LIN35005716\SQLEXPRESS;Database=Hive;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customizations must go after base.OnModelCreating(builder)

            builder.ApplyConfiguration(new EmployeeConfiguration<EmployeeEntity>());
            builder.ApplyConfiguration(new ProductConfiguration<ProductEntity>());
            builder.ApplyConfiguration(new OrderConfiguration<OrderEntity>());
            builder.ApplyConfiguration(new OrderDetailsConfiguration<OrderDetailsEntity>());

            // Imagine a ton more customizations
        }

    }
}
