using System.ComponentModel.DataAnnotations;

namespace APItest.Entities
{
    public class Match
    {
        [Key]
        public int MatchID { get; set; }
        public int? HomeTeamID { get; set; }
        public int? AwayTeamID { get; set; }
        public DateTime? MatchDate { get; set; }
        public object HomeTeam { get; internal set; }
        public object AwayTeam { get; internal set; }
    }
}