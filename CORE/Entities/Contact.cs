#nullable disable

namespace CORE.Entities;

public class Contact
{
    public int userId { get; set; }
    public User user { get; set; }

    public int contactId { get; set; }
    public User contact { get; set; }
}