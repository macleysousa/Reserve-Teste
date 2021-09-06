using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class Country_model
    {
        public string id { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string slug { get; set; }
        public int newConfirmed { get; set; }
        public int totalConfirmed { get; set; }
        public int newDeaths { get; set; }
        public int totalDeaths { get; set; }
        public int newRecovered { get; set; }
        public int totalRecovered { get; set; }
        public int totalActive { get => totalConfirmed - totalRecovered; }
        public DateTime date { get; set; }

    }
}
