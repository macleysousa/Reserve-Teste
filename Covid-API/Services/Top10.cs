using Covid_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_API.Services
{
    public class Top10
    {
        private readonly WebClient web;
        public Top10()
        {
            web = new WebClient("https://api.covid19api.com/");
        }
        public async Task<IEnumerable<Country_model>> GetAsync()
        {
            ResponseWebClient response = await web.GetAsyn("summary");

            Covid_model total = response.Deserialize<Covid_model>();
            List<Country_model> country = total.Countries.OrderByDescending(x => x.TotalActive).ToList();
            var top10 = country.Take(9);
            return top10;


        }
    }
}
