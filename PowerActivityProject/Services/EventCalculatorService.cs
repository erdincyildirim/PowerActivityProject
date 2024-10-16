using PowerActivityProject.Interfaces;
using PowerActivityProject.Models;
using PowerActivityProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerActivityProject.Services
{
	public class EventCalculatorService : IEventCalculator
	{
		public ResultView CalculateEvent(List<Event> events, List<Duration> durations)
		{

			ResultView _resultView = new ResultView();

			List<int> _eventIds = new List<int>();

			var currentTime = TimeSpan.Zero;

			string currentLocation = null;

			var eventList = (from e in events
							 orderby e.StartTime, e.Priority descending
							 select e).ToList();

			foreach (var item in eventList)
			{

				if(currentLocation != null && currentLocation != item.Location)
				{

					var findDuration = (from d in durations
										where d.From == currentLocation && d.To == item.Location ||
										d.From == item.Location && d.To == currentLocation
										select d).FirstOrDefault();

					if(findDuration != null)
					{

						TimeSpan newTime = currentTime + TimeSpan.FromMinutes(findDuration.DurationMinutes);

						if(newTime >= item.StartTime)
						{
							continue;
						}	

					}


				}

				if(currentTime <= item.StartTime)
				{

					currentTime = item.EndTime;

					currentLocation = item.Location;

					_resultView.TotalValue += item.Priority;

					_resultView.MaxEvent++;

					_eventIds.Add(item.Id);

				}

			}

			_resultView.EventId = _eventIds.ToArray();

			return _resultView;

		}

	}

}
