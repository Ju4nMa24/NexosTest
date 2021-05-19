using Nexos.Repositories.Entities;
using Nexus.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Intelligences.Interfaces
{
    public interface IEditorials
    {
        public string Register(EditorialModel editorialModel);
        public List<Editorial> List();
    }
}
