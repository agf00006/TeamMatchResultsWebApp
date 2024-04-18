using APItest.Entities;

namespace TeamMatchResultsWebApp.Repositories
{
  
    public interface IMatches
    {
        public Task<List<MatchResults>> GetMatchResults(int MatchResultsID);
    }
}
