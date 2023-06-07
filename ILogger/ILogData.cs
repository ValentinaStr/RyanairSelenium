namespace ILogger
{
	public interface ILogData
	{
		public void Deconstruct(out DateTime departDayTimeFrom, out string departCityFrom, out DateTime departDayTimeTo, out string departCityTo,
			out DateTime returnDayTimeFrom, out string returnCityFrom, out DateTime returnDayTimeTo, out string returnCityTo, out string costGeneral);
	}
}
