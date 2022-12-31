using DAL.EntityConfigurations;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class UrlShortnerContext : DbContext
{
    public UrlShortnerContext(DbContextOptions<UrlShortnerContext> options) : base(options)
    {
        //dbSet
    }
    
    public DbSet<UserModel> Users { get; set; } = null!;

    public DbSet<UrlModel> ShortedUrls { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UrlModelConfiguration());
        builder.ApplyConfiguration(new UserModelConfiguration());
        SeedData.SeedData.Seed(builder);
    }
}