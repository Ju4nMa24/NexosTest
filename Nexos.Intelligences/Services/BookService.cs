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
    public class BookService : IBooks
    {
        private readonly NexosContext _db;
        public BookService(NexosContext db) => _db = db;
        public string Register(BookModel bookModel)
        {
            try
            {
                _db.Books.Add(new Book()
                {
                    BookId = Guid.NewGuid(),
                    AuthorId = bookModel.AuthorId,
                    EditorialId = bookModel.EditorialId,
                    Title = bookModel.Title,
                    Gender = bookModel.Gender,
                    NumberPage = bookModel.NumberPage,
                    Year = bookModel.Year,
                    CreationDate = DateTime.Now
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
        public int RegisterCount() => _db.Books.Count();
    }
}
