using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using APItest.Data; 
using APItest.Entities; 
using Microsoft.EntityFrameworkCore;
using TeamMatchResultsWebApp.Repositories;

namespace APItest.Repositories
{
    public class TeamMatchResults : ITeamMatchResults
    {
        private readonly DbContextClass _dbContext;

        public TeamMatchResults(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MatchResults>> GetTeamMatchResults(string TeamName)
        {
            if (TeamName is null)
            {
                throw new ArgumentNullException(nameof(TeamName));
            }

            var matchResults = await _dbContext.MatchResults
                .FromSqlRaw("EXEC spGetTeamMatchResults @TeamID")
                .ToListAsync();

            return matchResults;
        }

        Task<List<TeamMatchResults>> ITeamMatchResults.GetTeamMatchResults(int TeamID)
        {
            throw new NotImplementedException();
        }
    }
}