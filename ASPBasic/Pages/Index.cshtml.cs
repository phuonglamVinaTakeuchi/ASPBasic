using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPBasic.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "this is a get request";
        }
        public IActionResult OnPost()
        {
            Message = "this is a post request";
            return new RedirectToPageResult("About");
        }

        public void OnPostDelete()
        {
            Message = "this is a Delete post request";
        }
        public IActionResult OnPostEdit(int id)
        {
            Message = "this is a Edit post request";
            return new RedirectToPageResult("About");
        }

    }
}
