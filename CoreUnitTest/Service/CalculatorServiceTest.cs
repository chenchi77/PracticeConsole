using Core.Service.Calculator;
using log4net;
using Moq;
using NUnit.Framework;

namespace CoreUnitTest
{
	[TestFixture]
	public class CalculatorServiceTest
	{
		[Test]
		public void Test()
		{
			var logMock = new Mock<ILog>();
			var service = new GerenalCalculatorService(logMock.Object);
			Assert.AreEqual(service.Cal(100), 100);
		}
	}
}
