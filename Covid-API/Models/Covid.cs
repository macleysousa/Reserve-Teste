using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_API.Models
{

    public class Covid_model
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public Global_model Global { get; set; }
        public List<Country_model> Countries { get; set; }
        public DateTime Date { get; set; }
    }

    public class Global_model
    {
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public DateTime Date { get; set; }
        public int TotalActive { get => TotalConfirmed - TotalRecovered; }
    }

    public class Country_model
    {
        public string ID { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public int TotalActive { get => TotalConfirmed - TotalRecovered; }
        public DateTime Date { get; set; }

    }

}
