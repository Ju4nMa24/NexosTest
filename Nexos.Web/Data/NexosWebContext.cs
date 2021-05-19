using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nexos.Web.Models;

namespace Nexos.Web.Data
{
    public class NexosWebContext : DbContext
    {
        public NexosWebContext (DbContextOptions<NexosWebContext> options)
            : base(options)
        {
        }

        public DbSet<Nexos.Web.Models.Editorial> Editorial { get; set; }
    }
}
