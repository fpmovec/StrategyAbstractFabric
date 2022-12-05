using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Man
    {
        public string Destination { get; set; }
        public string Transport { get; set; }
        public int Money { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append("Destination: " + Destination + "\n")
            .Append("Transport: " + Transport + "\n")
            .Append("Money: " + Money)
            .ToString();
    }
    public class MainClass
    {
         static void Main(string[] args)
        {

            string destination;
            string transportType;
            int money;
            //Man man = new Man();
            Console.WriteLine("Enter a destination point");
            destination = Console.ReadLine();
            Console.WriteLine("Enter a type of transport");
            transportType = Console.ReadLine();
            Console.WriteLine("Enter money count");
            money = int.Parse(Console.ReadLine());
            //man.Money = money;
            Console.WriteLine(ManInformation(destination, transportType, money));

        }
        public static Man ManInformation(string destination, string transp, int money)
        {
            Man man = new Man();
            man.Money = money;

            Moving transport = new Moving(man);
            switch (destination.ToUpper())
            {
                case "SHOP":
                    {
                        transport.SetTransportStrategy(new Shop());
                        break;
                    }
                case "WORK":
                    {
                        transport.SetTransportStrategy(new Work());
                        break;
                    }
                case "CLINIC":
                    {
                        transport.SetTransportStrategy(new Clinic());
                        break;
                    }
                default: throw new ArgumentException(destination);
            }

            transport.Move(transp, money);

            return man;

        }
    }
    public class Moving
    {
        
        private DestinationStrategy _strategy;
        private Man _man;

        public Moving(Man man) => _man = man;
        public void SetTransportStrategy(DestinationStrategy strategy) => _strategy = strategy;

        public void Move(string transport, int money) => _strategy.Moving(transport, money, _man);
       
    }

    public abstract class DestinationStrategy
    {
        public abstract void Moving(string transport, int money, Man man);
    }

    public class Shop : DestinationStrategy
    {
        public override void Moving(string transport, int money, Man man)
        {
            //Console.WriteLine("Shop");
            man.Destination = "I will go to a Shop!";
            new Money(transport, money, man);
        }
    }

    public class Work : DestinationStrategy
    {
        public override void Moving(string transport, int money, Man man)
        {
            // Console.WriteLine("Work");
            man.Destination = "I will go to a Work!";
            new Money(transport, money, man);
        }
    }
    public class Clinic : DestinationStrategy
    {
        public override void Moving(string transport, int money, Man man)
        {
            //Console.WriteLine("Clinic");
            man.Destination = "I will go to a Clinic!";
            new Money(transport, money, man);
        }
    }
}
