using System;
using Core.Enum;
using Core.Service.Calculator;

namespace Core
{
	public class MemberService
	{
		ICalculatorService _calculatorService;
		public MemberService(Func<MemberType, ICalculatorService> calculatoryFactory, MemberType memberType)
		{
			_calculatorService = calculatoryFactory(memberType);
		}

		public decimal CheckOut(int amount)
		{
			return _calculatorService.Cal(amount);
		}
	}
}
