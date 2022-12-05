using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Money
    {
        private IMoney _money;
        public Money(string transport, int money)
        {
            MoneyFactory factory = new MoneyFactory();
            IMoneySituations situations = factory.CreateSituation(transport, money);
            _money = situations.CreateMoney();
            _money.BuildMoney();
        }
    }
    public class MoneyFactory
    {
        public IMoneySituations CreateSituation(string transport, int money)
        {
            if (money <= 0)
                throw new ArgumentOutOfRangeException();

            if (transport.ToUpper().Equals("TAXI"))
                return new Taxi(money);
            else if (transport.ToUpper().Equals("BUS"))
                return new Bus(money);
            else if (transport.ToUpper().Equals("BICYCLE"))
                return new Bicycle(money);

            throw new ArgumentException(transport);
        }
    }
    public class Taxi : IMoneySituations
    {
        private int _money;
        public Taxi(int money)
        {
            _money = money;
        }

        public IMoney CreateMoney()
        {
            if (_money > 0 && _money < 10)
                return new TaxiFewMoney();
            else if (_money >= 10 && _money <= 30)
                return new TaxiMediumMoney();
            else if (_money > 30)
                return new TaxiMuchMoney();
            else throw new ArgumentException();
        }
    }

    public class Bus : IMoneySituations
    {
        private int _money;
        public Bus(int money)
        {
            _money = money;
        }

        public IMoney CreateMoney()
        {
            if (_money > 0 && _money < 10)
                return new BusFewMoney();
            else if (_money >= 10)
                return new BusMuchMoney();
            else throw new ArgumentException();
        }
    }

    public class Bicycle : IMoneySituations
    {
        private int _money;
        public Bicycle(int money)
        {
            _money = money;
        }

        public IMoney CreateMoney()
        {
            if (_money > 0 && _money < 10)
                return new BicycleFewMoney();
            else if (_money >= 10)
                return new BicycleMuchMoney();
            else throw new ArgumentException();
        }
    }
}
