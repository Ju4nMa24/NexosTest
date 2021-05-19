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
    public class EditorialsController : ControllerBase
    {
        private readonly IEditorials _editorials;
        private readonly IBooks _books;
        public EditorialsController(IEditorials editorials, IBooks books)
        {
            _editorials = editorials;
            _books = books;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]EditorialModel model)
        {
            if (ModelState.IsValid)
            {
                model.NumberBooks = _books.RegisterCount();
                string response = Task.Run(() => _editorials.Register(model)).Result;
                if (response == "OK")
                    return Ok("Editorial registrada correctamente.");
            }
            return BadRequest();
        } 
        [HttpGet]
        public async Task<IActionResult> EditorialsList()
        {
            try
            {
                return Ok(await Task.Run(() => _editorials.List()));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
