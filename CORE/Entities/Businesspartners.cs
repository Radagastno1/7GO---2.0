#nullable disable


namespace CORE.Entities
{
    public class Businesspartners
    {
        public int businessId { get; set; }
        public string business_name { get; set; }
        public ICollection<Reward> business_rewards { get; set; }
    }
}

