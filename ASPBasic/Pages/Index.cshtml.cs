using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPBasic.Interface;
using ASPBasic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace ASPBasic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;
        public HashSet<Book> Books => _repository.Books;
        public int Count => _repository.Books.Count;
        public IndexModel(IRepository repository) => _repository = repository;

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
           

        }


    }
}
