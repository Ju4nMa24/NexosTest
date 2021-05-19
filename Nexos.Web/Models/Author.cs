using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nexos.Web.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
