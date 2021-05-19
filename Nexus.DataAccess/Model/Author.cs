using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.DataAccess.Model
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid AuthorId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
