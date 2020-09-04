using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

public class ECommerceDbContext:DbContext{
    
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }

    public DbSet<Category> Categories{get;set;}
}