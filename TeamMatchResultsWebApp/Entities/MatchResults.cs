using System.ComponentModel.DataAnnotations;

namespace APItest.Entities
{
    public class MatchResults
    {
        public int MatchID { get; set; }
        public int HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public int MatchResultsID { get; set; }
        public string HomeTeamResult { get; set; }
        public string AwayTeamResult { get; set; }

        internal Task<MatchResults> GetAllMatchResultsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
