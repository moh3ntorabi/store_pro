﻿using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Domain.Entities.Carts;
using Phoenix_Store.Domain.Entities.Finances;
using Phoenix_Store.Domain.Entities.HomePage;
using Phoenix_Store.Domain.Entities.Orders;
using Phoenix_Store.Domain.Entities.Products;
using Phoenix_Store.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserInRole> UserInRoles { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        DbSet<ProductFeature> ProductFeatures { get; set; }
        DbSet<Slider> Sliders { get; set; }
        DbSet<HomePageImages> HomePageImages { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<CartItem> CartItems { get; set; }
        DbSet<RequestPay> RequestPays { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
    

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
