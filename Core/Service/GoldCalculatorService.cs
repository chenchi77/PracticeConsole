using System;
using log4net;

namespace Core.Service
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
