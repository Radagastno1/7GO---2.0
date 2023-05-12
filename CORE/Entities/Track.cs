#nullable disable

namespace CORE.Entities;

public class Track
{
    public int trackId { get; set; }
    public string track_name { get; set; }
    public string track_description { get; set; }
    public string track_geo { get; set; }
    public float track_length { get; set; }
    public decimal latitude{get;set;}
    public decimal longitude{get;set;}
    public ICollection<Reward> track_rewards { get; set; }
}