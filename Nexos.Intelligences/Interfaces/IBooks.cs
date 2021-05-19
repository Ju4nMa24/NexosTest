using Nexos.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Intelligences.Interfaces
{
    public interface IBooks
    {
        public string Register(BookModel bookModel);
        public int RegisterCount();
    }
}
