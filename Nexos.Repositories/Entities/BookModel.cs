using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Repositories.Entities
{
    public class BookModel
    {
        public Guid BookId { get; set; }
        public Guid AuthorId { get; set; }
        public Guid EditorialId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Gender { get; set; }
        public string NumberPage { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
