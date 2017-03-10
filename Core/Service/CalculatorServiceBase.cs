using log4net;

namespace Core.Service
{
	public class CalculatorServiceBase
	{
		protected ILog Logger;
		public CalculatorServiceBase(ILog logger)
		{
			Logger = logger;
		}
	}
}
