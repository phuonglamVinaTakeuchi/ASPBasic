

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPBasic.Pages
{
    public class PostModel : PageModel
    {
        [ViewData]
        public string Title { get; set; }
        public string Text { get; set; }
        public void OnGet()
        {
            var title = Request.Query["title"].ToString();
            if (string.IsNullOrEmpty(title))
            {
                Title = "Nothing";
                Text = "Blank";
                return;
            }
            Title = title.Replace('-', ' ').ToUpper();
            Text = "Test thoi can gi dai du vay";

        }
    }
}
