using Nexos.Repositories.Entities;
using Nexus.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Intelligences.Interfaces
{
    public interface IAuthors
    {
        public string Register(AuthorModel authorModel);
        public List<Author> List();
    }
}
