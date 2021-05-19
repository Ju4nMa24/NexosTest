using Nexus.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.DataAccess.Model
{
    public class DbInitializer : IDbInitializer
    {
        public void Initialize(NexosContext context)
        {
            context.Database.EnsureCreated();
            if (context.Editorials.Any())
                return;   // DB has been seeded

            Editorial editorial = new Editorial()
            {
                EditorialId = Guid.NewGuid(),Name="Alexander S.A.S",Address="Cra. 123 No. 10-39",Email="alexanders@gmail.com",Phone=7069980,NumberBooks=1
            };
            context.Editorials.Add(editorial);
            context.SaveChanges();
            context.SaveChanges();
        }
    }
}
