using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorUI.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public string TypeMessage { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Messages.Add(TypeMessage);
            return Page();
        }
    }
}
