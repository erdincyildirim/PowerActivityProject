using PowerActivityProject.Models;
using PowerActivityProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerActivityProject.Interfaces
{
	public interface IEventCalculator
	{

		ResultView CalculateEvent(List<Event> events, List<Duration> durations);

	}
}
