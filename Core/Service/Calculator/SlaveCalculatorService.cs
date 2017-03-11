using log4net;

namespace Core.Service.Calculator
{
	public class SlaveCalculatorService : CalculatorServiceBase, ICalculatorService
	{
		public SlaveCalculatorService(ILog logger) : base(logger) { }
		public decimal Cal(decimal amount)
		{
			return amount * 0.8M;
		}
	}
}
