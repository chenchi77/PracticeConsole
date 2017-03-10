using log4net;

namespace Core.Service
{
	public class CalculatorService : CalculatorServiceBase, ICalculatorService
	{
		public CalculatorService(ILog logger) : base(logger) { }
		public decimal Cal(decimal amount)
		{
			return amount;
		}
	}
}
