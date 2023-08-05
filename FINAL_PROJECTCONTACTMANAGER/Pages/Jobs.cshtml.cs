using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINAL_PROJECTCONTACTMANAGER.Pages
{
    [AllowAnonymous]
    public class JobsModel : PageModel
    {
        
        private readonly ILogger<JobsModel> _logger;

        public JobsModel(ILogger<JobsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
