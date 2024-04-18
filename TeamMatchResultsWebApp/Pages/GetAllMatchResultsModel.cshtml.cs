using APItest.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeamMatchResultsWebApp.Pages
{
    public class AllMatchResultsModel : PageModel
    {
        private readonly MatchResults _MatchResults;

        public AllMatchResultsModel(MatchResults MatchResults)
        {
            _MatchResults = MatchResults;
        }

        public List<MatchResultViewModel> AllMatchResults { get; set; }

        public async Task OnGetAsync()
        {
            MatchResults = await _MatchResults.GetAllMatchResultsAsync();
        }
    }

    public class MatchResultViewModel
    {
        public int MatchID { get; set; }
        public string MatchDate { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public string HomeTeamResult { get; set; }
        public string AwayTeamResult { get; set; }
    }
}
