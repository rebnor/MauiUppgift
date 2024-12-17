using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiUppgift.Models.SunModel
{
    public class Results
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string SolarNoon { get; set; }
        public string DayLength { get; set; }
        public string CivilTwilightBegin { get; set; }
        public string CivilTwilightEnd { get; set; }
        public string NauticalTwilightBegin { get; set; }
        public string NauticalTwilightEnd { get; set; }
        public string AstronomicalTwilightBegin { get; set; }
        public string AstronomicalTwilightEnd { get; set; }
    }
}
