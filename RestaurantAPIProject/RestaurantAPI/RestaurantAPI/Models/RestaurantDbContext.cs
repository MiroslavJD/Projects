using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestorantAPI.Models;

public partial class RestaurantDbContext : DbContext
{
    
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<FoodItem> FoodItems { get; set; }
    public DbSet<OrderMaster> OrderMasters { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

  
}
