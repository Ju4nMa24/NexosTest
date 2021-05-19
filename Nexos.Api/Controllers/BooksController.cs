using Microsoft.AspNetCore.Mvc;
using Nexos.Intelligences.Interfaces;
using Nexos.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nexos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooks _books;
        public BooksController(IBooks books)
        {
            _books = books;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]BookModel model)
        {
            if (ModelState.IsValid)
            {
                string response = Task.Run(() => _books.Register(model)).Result;
                if (response == "OK")
                    return Ok("Autor registrada correctamente.");
            }
            return BadRequest();
        }
    }
}
