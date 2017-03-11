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
		public void WhenGerenalInputAmountWillNoDiscount()
		{
			var logMock = new Mock<ILog>();
			var service = new GerenalCalculatorService(logMock.Object);
			Assert.AreEqual(service.Cal(100), 100);
		}

		[Test]
		public void WhenSlaveInputAmountWillDiscount80percent()
		{
			var logMock = new Mock<ILog>();
			var service = new SlaveCalculatorService(logMock.Object);
			Assert.AreEqual(service.Cal(100), 80);
		}

		[Test]
		public void WhenGoldInputAmountWillDiscount50percent()
		{
			var logMock = new Mock<ILog>();
			var service = new GoldCalculatorService(logMock.Object);
			Assert.AreEqual(service.Cal(100), 50);
		}
	}
}
