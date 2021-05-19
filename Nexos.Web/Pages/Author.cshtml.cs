using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nexos.Web.Models;

namespace Nexos.Web.Pages
{
    public class AuthorModel : PageModel
    {
        public void OnGet() => Page();
        [BindProperty]
        public Author Author { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            string uri = "http://localhost:1630";
            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient()
                {
                    BaseAddress = new Uri(uri)
                };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.PostAsJsonAsync($"{uri}/api/Authors", Author);
                return RedirectToPage("./Index");
            }


            return RedirectToPage("./Index");
        }
    }
}
