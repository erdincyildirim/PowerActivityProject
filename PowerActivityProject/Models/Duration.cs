using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerActivityProject.Models
{
	public class Duration
	{

        public string From { get; set; }

        public string To { get; set; }

        public int DurationMinutes { get; set; }

        public Duration(string from, string to, int durationMinutes)
        {

            From = from;

            To = to;

            DurationMinutes = durationMinutes;

        }

    }
}
