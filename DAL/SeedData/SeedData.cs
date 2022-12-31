using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.SeedData;

public class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        //Set of Users
        builder.Entity<UserModel>().HasData(
            new UserModel() { Id = 3, Username = "dovbyshchuk", FirstName = "Volodymyr", LastName = "Dovbyshchuk", Password = "VDovbyshchuk13042003"}
            );
        
        //Set of
        builder.Entity<UrlModel>().HasData(
            new UrlModel() { Id = 1, CreatedDate = DateTime.Now, CreatedById = 3, URL = "https://www.youtube.com/watch?v=qK5zdGTwWWE"}
            );

    }
}