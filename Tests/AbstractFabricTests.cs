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
            Man man = new Man();
            NUnit.Framework.Assert.Throws<ArgumentException>(() => moneyfactory.CreateSituation("Fly", 10, man));
        }
        [Fact]
        public void TestMoneyException()
        {
            var moneyFactory = new MoneyFactory();
            Man man = new Man();
            NUnit.Framework.Assert.Throws<ArgumentOutOfRangeException>(() => moneyFactory.CreateSituation("Taxi", -1, man));
        }
        [Fact]
        public void TestTaxi()
        {
            var moneyFactory = new MoneyFactory();
            Man man = new Man();
            var expected = new Taxi(10, man);
            var actual = moneyFactory.CreateSituation("Taxi", 10, man);
            var expectedObject = new Likeness<Taxi, Taxi>(expected);
           
            NUnit.Framework.Assert.AreEqual(expectedObject, actual);

        }

        [Fact]
        public void TestTaxiException()
        {
            Man man = new Man();
            var taxi = new Taxi(-1, man);
            NUnit.Framework.Assert.Throws<ArgumentException>(() => taxi.CreateMoney());
        }

        [Fact]
        public void TestBus()
        {
            var moneyFactory = new MoneyFactory();
            Man man = new Man();
            var expected = new Bus(10, man);
            var actual = moneyFactory.CreateSituation("Bus", 10, man);
            var expectedObject = new Likeness<Bus, Bus>(expected);

            NUnit.Framework.Assert.AreEqual(expectedObject, actual);
        }

        [Fact]
        public void TestBusException()
        {
            Man man = new Man();
            var bus = new Bus(-1, man);
            
            NUnit.Framework.Assert.Throws<ArgumentException>(() => bus.CreateMoney());
        }
        [Fact]
        public void TestBicycle()
        {
            var moneyFactory = new MoneyFactory();
            Man man = new Man();
            var expected = new Bicycle(10, man);
            var actual = moneyFactory.CreateSituation("Bicycle", 10, man);
            var expectedObject = new Likeness<Bicycle, Bicycle>(expected);

            NUnit.Framework.Assert.AreEqual(expectedObject, actual);
        }

        [Fact]
        public void TestBicycleException()
        {
            Man man = new Man();

            var bicycle = new Bicycle(-1, man);

            NUnit.Framework.Assert.Throws<ArgumentException>(() => bicycle.CreateMoney());
        }
       
    }
}