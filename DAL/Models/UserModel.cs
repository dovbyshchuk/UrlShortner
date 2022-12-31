namespace DAL.Models;

public class UserModel
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public List<UrlModel> OwnedUrls { get; set; } = new();
}