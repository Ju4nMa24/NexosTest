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
    public class AuthorService : IAuthors
    {
        private readonly NexosContext _db;
        public AuthorService(NexosContext db) => _db = db;
        public string Register(AuthorModel authorModel)
        {
            try
            {
                _db.Authors.Add(new Author()
                {
                    AuthorId = Guid.NewGuid(),
                    BirthDate = authorModel.BirthDate,
                    City = authorModel.City,
                    Email = authorModel.Email,
                    CreationDate = DateTime.Now,
                    FullName = authorModel.FullName
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
        public List<Author> List()
        {
            try
            {
                return _db.Authors.ToList();
            }
            catch (Exception)
            {

                throw new("An error ocurred.");
            }
        }
    }
}
