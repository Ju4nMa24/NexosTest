using Antlr4.Runtime.Misc;
using Nexos.Intelligences.Interfaces;
using Nexos.Repositories.Entities;
using Nexus.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Intelligences.Services
{
    public class EditorialService : IEditorials
    {
        private readonly NexosContext _db;
        public EditorialService(NexosContext db) => _db = db;
        public string Register(EditorialModel editorialModel)
        {
            try
            {
                _db.Editorials.Add(new Editorial()
                {
                    EditorialId = Guid.NewGuid(),
                    Address = editorialModel.Address,
                    Email = editorialModel.Email,
                    Name = editorialModel.Name,
                    NumberBooks = editorialModel.NumberBooks,
                    Phone = editorialModel.Phone
                });
                _db.SaveChanges();
                _db.Dispose();
                return "OK";
            }
            catch
            {
                throw new("An error ocurred.");
            }

        }
        public List<Editorial> List()
        {
            try
            {
                return _db.Editorials.ToList();
                _db.Dispose();
            }
            catch (Exception)
            {

                throw new("An error ocurred.");
            }
        }
    }
}
