using log4net;

namespace Core.Service.Calculator
{
	public class GerenalCalculatorService : CalculatorServiceBase, ICalculatorService
	{
		public GerenalCalculatorService(ILog logger) : base(logger) { }
		public decimal Cal(decimal amount)
		{
			return amount;
		}
	}
}
