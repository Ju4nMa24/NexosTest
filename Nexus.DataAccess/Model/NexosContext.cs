using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.DataAccess.Model
{
    public class NexosContext : DbContext
    {
        public NexosContext(DbContextOptions<NexosContext> options) : base(options)
        {
        }

        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=NexosDb;Trusted_Connection=True;");
        }
    }
}
