using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Repositories.Entities
{
    public class EditorialModel
    {
        public Guid EditorialId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int NumberBooks { get; set; }
    }
}
