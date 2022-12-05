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
        public Money(string transport, int money, Man man)
        {
            MoneyFactory factory = new MoneyFactory();
            IMoneySituations situations = factory.CreateSituation(transport, money, man);
            _money = situations.CreateMoney();
            _money.BuildMoney();
        }
    }
    public class MoneyFactory
    {
        public IMoneySituations CreateSituation(string transport, int money, Man man)
        {
            if (money <= 0)
                throw new ArgumentOutOfRangeException();

            if (transport.ToUpper().Equals("TAXI"))
                return new Taxi(money, man);
            else if (transport.ToUpper().Equals("BUS"))
                return new Bus(money, man);
            else if (transport.ToUpper().Equals("BICYCLE"))
                return new Bicycle(money, man);

            throw new ArgumentException(transport);
        }
    }
    public class Taxi : IMoneySituations
    {
        private int _money;
        private Man _man;
        public Taxi(int money, Man man)
        {
            _money = money;
            _man = man;
        }

        public IMoney CreateMoney()
        {
            if (_money > 0 && _money < 10)
                return new TaxiFewMoney(_man);
            else if (_money >= 10 && _money <= 30)
                return new TaxiMediumMoney(_man);
            else if (_money > 30)
                return new TaxiMuchMoney(_man);
            else throw new ArgumentException();
        }
    }

    public class Bus : IMoneySituations
    {
        private int _money;
        private Man _man;
        public Bus(int money, Man man)
        {
            _money = money;
            _man = man;
        }

        public IMoney CreateMoney()
        {
            if (_money > 0 && _money < 10)
                return new BusFewMoney(_man);
            else if (_money >= 10)
                return new BusMuchMoney(_man);
            else throw new ArgumentException();
        }
    }

    public class Bicycle : IMoneySituations
    {
        private int _money;
        private Man _man;
        public Bicycle(int money, Man man)
        {
            _money = money;
            _man = man;
        }

        public IMoney CreateMoney()
        {
            if (_money > 0 && _money < 10)
                return new BicycleFewMoney(_man);
            else if (_money >= 10)
                return new BicycleMuchMoney(_man);
            else throw new ArgumentException();
        }
    }
}
