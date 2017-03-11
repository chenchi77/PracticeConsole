using log4net;

namespace Core.Service.Calculator
{
	public class GoldCalculatorService : CalculatorServiceBase, ICalculatorService
	{
		public GoldCalculatorService(ILog logger) : base(logger)
		{
		}

		public decimal Cal(decimal amount)
		{
			return amount * 0.5M;
		}
	}
}
