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
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthors _authors;
        public AuthorsController(IAuthors authors)
        {
            _authors = authors;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]AuthorModel model)
        {
            if (ModelState.IsValid)
            {
                string response = Task.Run(() => _authors.Register(model)).Result;
                if (response == "OK")
                    return Ok("Autor registrada correctamente.");
            }
            return BadRequest();
        }
        [HttpGet]
        public async Task<IActionResult> AuthorsList()
        {
            try
            {
                return Ok(await Task.Run(() => _authors.List()));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
