using Nexus.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.DataAccess.Interfaces
{
    public interface IDbInitializer
    {
        public void Initialize(NexosContext context);
    }
}
