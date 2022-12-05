using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using SemanticComparison;
using StrategyPattern;

namespace Tests
{
    public class AbstractFabricTests
    {

        [Fact]
        public void TestTransportException()
        {
            var moneyfactory = new MoneyFactory();

            NUnit.Framework.Assert.Throws<ArgumentException>(() => moneyfactory.CreateSituation("Fly", 10));
        }
        [Fact]
        public void TestMoneyException()
        {
            var moneyFactory = new MoneyFactory();

            NUnit.Framework.Assert.Throws<ArgumentOutOfRangeException>(() => moneyFactory.CreateSituation("Taxi", -1));
        }
        [Fact]
        public void TestTaxi()
        {
            var moneyFactory = new MoneyFactory();

            var expected = new Taxi(10);
            var actual = moneyFactory.CreateSituation("Taxi", 10);
            var expectedObject = new Likeness<Taxi, Taxi>(expected);
           
            NUnit.Framework.Assert.AreEqual(expectedObject, actual);

        }

        [Fact]
        public void TestTaxiException()
        {
            var taxi = new Taxi(-1);
            NUnit.Framework.Assert.Throws<ArgumentException>(() => taxi.CreateMoney());
        }

        [Fact]
        public void TestBus()
        {
            var moneyFactory = new MoneyFactory();

            var expected = new Bus(10);
            var actual = moneyFactory.CreateSituation("Bus", 10);
            var expectedObject = new Likeness<Bus, Bus>(expected);

            NUnit.Framework.Assert.AreEqual(expectedObject, actual);
        }

        [Fact]
        public void TestBusException()
        {
            var bus = new Bus(-1);

            NUnit.Framework.Assert.Throws<ArgumentException>(() => bus.CreateMoney());
        }
        [Fact]
        public void TestBicycle()
        {
            var moneyFactory = new MoneyFactory();

            var expected = new Bicycle(10);
            var actual = moneyFactory.CreateSituation("Bicycle", 10);
            var expectedObject = new Likeness<Bicycle, Bicycle>(expected);

            NUnit.Framework.Assert.AreEqual(expectedObject, actual);
        }

        [Fact]
        public void TestBicycleException()
        {
            var bicycle = new Bicycle(-1);

            NUnit.Framework.Assert.Throws<ArgumentException>(() => bicycle.CreateMoney());
        }
       
    }
}