#nullable disable

namespace CORE.Entities;

public class User
{
    public int userId { get; set; }
    public string user_name { get; set; }
    public string user_inlog { get; set; }
    public string password { get; set; }
    public string user_img { get; set; }
    public ICollection<User> users { get; set; }
    public ICollection<Challenge> challenges { get; set; }
}