using System;
using Core.Enum;
using Core.Service.Calculator;

namespace Core
{
	public class MemberService
	{
		Func<MemberType, ICalculatorService> _calculatorFactory;
		public MemberService(Func<MemberType, ICalculatorService> calculatoryFactory)
		{
			_calculatorFactory = calculatoryFactory;
		}

		public decimal CheckOut(MemberType memberType, int amount)
		{
			var service = _calculatorFactory(memberType);
			return service.Cal(amount);
		}
	}
}
