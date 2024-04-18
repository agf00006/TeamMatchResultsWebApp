using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YourNamespace.Pages
{
    public class GetMatchResultsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string TeamName { get; set; }

       

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            return RedirectToPage("/MatchResults", new { teamName = TeamName });
        }
    }
}