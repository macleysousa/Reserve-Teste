using Covid19.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WebClient web;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            web = new WebClient("http://localhost:27074");
        }

        public async Task OnGet()
        {
            ResponseWebClient response = await web.GetAsyn("api/covid/top10");
            if (response.StatusCode==200)
            {
                var top10 = response.Deserialize<List<Models.Country_model>>();
                ViewData["Top10"] = top10;
            }
            
        }
    }
}
