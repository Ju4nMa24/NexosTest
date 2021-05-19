using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Nexos.Web.Models;

namespace Nexos.Web.Pages
{
    public class BookModel : PageModel
    {
        public SelectList EditorialSelect { get; set; }
        public SelectList AuthorSelect { get; set; }
        public void OnGet()
        {
            string uri = "http://localhost:1630";
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(uri)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Parallel.Invoke(
                () =>
                {
                    HttpResponseMessage response = client.GetAsync($"{uri}/api/Editorials").Result;
                    List<EditorialResponse> editorial = JsonConvert.DeserializeObject<List<EditorialResponse>>(response.Content.ReadAsStringAsync().Result);
                    EditorialSelect = new SelectList(editorial, "EditorialId", "Name", string.Empty);
                },
                () =>
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage responseAuthors = client.GetAsync($"{uri}/api/Authors").Result;
                    List<AuthorResponse> authors = JsonConvert.DeserializeObject<List<AuthorResponse>>(responseAuthors.Content.ReadAsStringAsync().Result);
                    AuthorSelect = new SelectList(authors, "AuthorId", "FullName", string.Empty);
                }
                );
            Page();
        }
        [BindProperty]
        public Book Book { get; set; }
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
                client.PostAsJsonAsync($"{uri}/api/Books", Book);
                return RedirectToPage("./Index");
            }


            return RedirectToPage("./Index");
        }
    }
}
