using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nexos.Web.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string AuthorId { get; set; }
        public string EditorialId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Gender { get; set; }
        public string NumberPage { get; set; }
    }
}
