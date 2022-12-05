using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Man
    {
        public string Destination { get; set; }
        public string Transport { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string destination;
            string transportType;
            int money;
            Man man = new Man();
            Console.WriteLine("Enter a destination point");
            destination = Console.ReadLine();
            Console.WriteLine("Enter a type of transport");
            transportType = Console.ReadLine();
            Console.WriteLine("Enter money count");
            money = int.Parse(Console.ReadLine());

            Moving transport = new Moving();
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
            
            transport.Move(transportType, money);
            
        }
    }

    public class Moving
    {
        
        private DestinationStrategy _strategy;

        public void SetTransportStrategy(DestinationStrategy strategy) => _strategy = strategy;

        public void Move(string transport, int money) => _strategy.Moving(transport, money);
       
    }

    public abstract class DestinationStrategy
    {
        public abstract void Moving(string transport, int money);
    }

    public class Shop : DestinationStrategy
    {
        public override void Moving(string transport, int money)
        {
            Console.WriteLine("Shop");
            new Money(transport, money);
        }
    }

    public class Work : DestinationStrategy
    {
        public override void Moving(string transport, int money)
        {
            Console.WriteLine("Work");
            new Money(transport, money);
        }
    }
    public class Clinic : DestinationStrategy
    {
        public override void Moving(string transport, int money)
        {
            Console.WriteLine("Clinic");
            new Money(transport, money);
        }
    }
}
