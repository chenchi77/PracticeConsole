using System;
using Autofac;
using Core;
using Core.Enum;

namespace PracticeConsole
{
	class MainClass
	{
		static IContainer Container { get; set; }

		public static void Main(string[] args)
		{
			Container = AutofacStart.Start();
			var amount = 100;

			Console.WriteLine(string.Format("Gold => {0}", Process(MemberType.Gold, amount)));
			Console.WriteLine(string.Format("Slave => {0}", Process(MemberType.Slave, amount)));
			Console.WriteLine(string.Format("Gerenal => {0}", Process(MemberType.Gerenal, amount)));
		}

		public static decimal Process(MemberType memberType, int amount)
		{
			using (var scope = Container.BeginLifetimeScope())
			{
				var memberService = scope.Resolve<MemberService>(new NamedParameter("memberType", memberType));
				return memberService.CheckOut(amount);
			}
		}
	}
}
