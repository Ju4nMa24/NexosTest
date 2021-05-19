using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.DataAccess.Model
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
