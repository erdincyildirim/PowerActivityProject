
using PowerActivityProject.Interfaces;
using PowerActivityProject.Models;
using PowerActivityProject.Services;

public class Program
{

	public static void Main(string[] args)
	{

		IEventCalculator _eventCalculator = new EventCalculatorService();

		var _events = new List<Event>()
		{
			new Event(1, TimeSpan.Parse("10:00"), TimeSpan.Parse("12:00"), "A", 50),
			new Event(2, TimeSpan.Parse("10:00"), TimeSpan.Parse("11:00"), "B", 30),
			new Event(3, TimeSpan.Parse("11:30"), TimeSpan.Parse("12:30"), "A", 40),
			new Event(4, TimeSpan.Parse("14:30"), TimeSpan.Parse("16:00"), "C", 70),
			new Event(5, TimeSpan.Parse("14:25"), TimeSpan.Parse("15:30"), "B", 60),
			new Event(6, TimeSpan.Parse("13:00"), TimeSpan.Parse("14:00"), "D", 80)
		};

		var _durations = new List<Duration>
		{
			new Duration("A", "B", 15),
			new Duration("A", "C", 20),
			new Duration("A", "D", 10),
			new Duration("B", "C", 5),
			new Duration("B", "D", 25),
			new Duration("C", "D", 25)
		};

		var _result = _eventCalculator.CalculateEvent(_events, _durations);

		Console.WriteLine($"Katılınabilecek Maksimum Etkinlik Sayısı : {_result.MaxEvent}\nKatılınabilecek Etkinliklerin ID'leri: {string.Join(",",_result.EventId)}\nToplam Değer : {_result.TotalValue}");

	}

}