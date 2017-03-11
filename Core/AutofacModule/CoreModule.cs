using System;
using Autofac;
using Core.Service.Calculator;
using Core.Enum;
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
			base.Load(builder);
		}
	}
}
