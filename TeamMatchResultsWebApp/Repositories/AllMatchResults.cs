
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using APItest.Data;
using APItest.Entities;
using Microsoft.Extensions.FileSystemGlobbing;
using TeamMatchResultsWebApp.Repositories;


namespace APITest.Repositories
{
    public class AllMatchResults : IAllMatchResults
    {
        private readonly DbContextClass _dbContextClass;
        public AllMatchResults(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<MatchResults>> GetMatchResults(int MatchResultsID)
        {
            var param = new SqlParameter("@MatchResultsID", MatchResultsID);
            var matchDetails = await Task.Run(() => _dbContextClass.MatchResults.FromSqlRaw("exec spGetMatchResults @MatchResultsID", param).ToListAsync());
            return matchDetails;
        }
    }
}
