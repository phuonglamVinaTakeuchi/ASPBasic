using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPBasic.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; } 
        public string Publisher { get; set; } 
        public int Year { get; set; } 
        public string Description { get; set; } 
    }
}
