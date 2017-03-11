using Autofac;
using Core.AutofacModule;

namespace PracticeConsole
{
	public class AutofacStart
	{
		public static IContainer Start()
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule(new LoggingModule());
			builder.RegisterModule(new CoreModule());
			return builder.Build();
		}
	}
}
