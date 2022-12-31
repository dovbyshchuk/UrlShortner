using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations;

public class UserModelConfiguration : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        var users = new List<UserModel>()
        {
            new()
            {
                Id = 1,
                Username = "admin",
                Password = "admin",
                FirstName = "Admin",
                LastName = "Admin",
            },
            new()
            {
                Id = 2,
                Username = "guest",
                Password = "guest",
                FirstName = "Guest",
                LastName = "Guest",
            },
        };
        builder.HasData(users);
    }
}