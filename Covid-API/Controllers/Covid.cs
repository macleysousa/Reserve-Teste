using Covid_API.Models;
using Covid_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Covid_API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class Covid : ControllerBase
    {
        private readonly WebClient web;
        private readonly Top10 _top10;
        public Covid()
        {
            web = new WebClient("https://api.covid19api.com/");
            _top10 = new Top10();
        }

        // GET: api/<Covid>
        [HttpGet("api/covid")]
        public async Task<Covid_model> Get()
        {
            ResponseWebClient response = await web.GetAsyn("summary");            
            Covid_model covid = response.Deserialize<Covid_model>();
            return covid;
        }

        // GET api/<Covid>/5
        [HttpGet("api/covid/top10")]
        public async Task<IEnumerable<Country_model>> top10()
        {
            return await _top10.GetAsync();
        }
       
    }
}
