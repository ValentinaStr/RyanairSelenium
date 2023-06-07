using ILogger;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoggerDb
{
	public class LogDbModel : ILogData
	{
		public int id { get; set; }
		[Column(name:"Day & time depart")]
		public DateTime DepartDayTimeFrom { get; set; }
		[Column(name: "City depart")]
		public string DepartCityFrom { get; set; }
		[Column(name: "Day & time arrival")]
		public DateTime DepartDayTimeTo { get; set; }
		[Column(name: "City arrival")]
		public string DepartCityTo { get; set; }
		[Column(name: "Return: Day & time depart")]
		public DateTime ReturnDayTimeFrom { get; set; }
		[Column(name: "Return: City depart")]
		public string ReturnCityFrom { get; set; }
		[Column(name: "Return: Day & time arrival")]
		public DateTime ReturnDayTimeTo { get; set; }
		[Column(name: "Return: City arrival")]
		public string ReturnCityTo { get; set; }
		public string CostGeneral { get; set; }

		public LogDbModel(DateTime departDayTimeFrom, string departCityFrom, DateTime departDayTimeTo, string departCityTo,
						DateTime returnDayTimeFrom, string returnCityFrom, DateTime returnDayTimeTo, string returnCityTo, 
						string costGeneral)
		{
			DepartDayTimeFrom = departDayTimeFrom;
			DepartCityFrom = departCityFrom;
			DepartDayTimeTo = departDayTimeTo;
			DepartCityTo = departCityTo;
			ReturnDayTimeFrom = returnDayTimeFrom;
			ReturnCityFrom = returnCityFrom;
			ReturnDayTimeTo = returnDayTimeTo;
			ReturnCityTo = returnCityTo;
			CostGeneral = costGeneral;
		}		
		public void Deconstruct(out DateTime departDayTimeFrom, out string departCityFrom, out DateTime departDayTimeTo, out string departCityTo,
								out DateTime returnDayTimeFrom, out string returnCityFrom, out DateTime returnDayTimeTo, out string returnCityTo,
								out string costGeneral)
		{
			departDayTimeFrom = DepartDayTimeFrom;
			departCityFrom = DepartCityFrom;
			departDayTimeTo = DepartDayTimeTo;
			departCityTo = DepartCityTo;
			returnDayTimeFrom = ReturnDayTimeFrom;
			returnCityFrom = ReturnCityFrom;
			returnDayTimeTo = ReturnDayTimeTo;
			returnCityTo = ReturnCityTo;
			costGeneral = CostGeneral;
		}
	}
}
	
