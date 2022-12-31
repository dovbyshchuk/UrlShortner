namespace DAL.Models;

public class UrlModel
{
    public int Id { get; set; }

    public string URL { get; set; } = null!;

    public string ShortUrl { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public UserModel? CreatedBy { get; set; }

    public int CreatedById { get; set; }
}