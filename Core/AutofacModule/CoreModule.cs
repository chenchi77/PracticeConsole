using System;
using Autofac;
using Core.Service.Calculator;
using Core.Enum;
using Autofac.Core;

namespace Core.AutofacModule
{
	public class CoreModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<GerenalCalculatorService>().As<ICalculatorService>().Keyed<ICalculatorService>(MemberType.Gerenal);
			builder.RegisterType<GoldCalculatorService>().As<ICalculatorService>().Keyed<ICalculatorService>(MemberType.Gold);
			builder.RegisterType<SlaveCalculatorService>().As<ICalculatorService>().Keyed<ICalculatorService>(MemberType.Slave);

			builder.Register<Func<MemberType, ICalculatorService>>(c => {
				var componentContext = c.Resolve<IComponentContext>();
				return (memberType) =>
				{
					return componentContext.ResolveKeyed<ICalculatorService>(memberType);
				};
			});

			builder.RegisterType<MemberService>().WithParameter(
				new ResolvedParameter(
					(pi, ctx) => pi.ParameterType == typeof(Func<MemberType, ICalculatorService>) && pi.Name == "calculatoryFactory",
					(pi, ctx) => ctx.Resolve<Func<MemberType, ICalculatorService>>()
				)
			);

			base.Load(builder);
		}
	}
}
