#nullable disable

namespace CORE.Entities
{
    public class Challenge
    {
        public int challengeId { get; set; }
        public string challenge_name { get; set; }
        public int challenge_level { get; set; }
        public int trackId { get; set; }
        public Track track { get; set; }
    }

}