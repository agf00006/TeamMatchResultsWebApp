using APItest.Repositories;

namespace TeamMatchResultsWebApp.Repositories
{
    public interface ITeamMatchResults
    {
        public Task<List<TeamMatchResults>> GetTeamMatchResults(int TeamID);
    }
}
