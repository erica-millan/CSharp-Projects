using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerTimeApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string ServerTime { get; set; }


        public void OnGet()
        {
            //adding property
             ServerTime = DateTime.Now.ToString("F");
        }
    }
}
