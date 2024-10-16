using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerActivityProject.Models
{
	public class Event
	{

        public int Id { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string Location { get; set; }

        public int Priority { get; set; }


        public Event(int id, TimeSpan startTime, TimeSpan endTime, string location, int priority)
        {

            Id = id;

            StartTime = startTime;

            EndTime = endTime;

            Location = location;

            Priority = priority;
            
        }

    }

}
