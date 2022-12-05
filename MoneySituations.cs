using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //////////////// Bus /////////////////
    public class BusFewMoney : IMoney
    {
        private Man _man;
        public BusFewMoney(Man man)
        {
            _man = man;
        }
        public void BuildMoney()
        {
            //Console.WriteLine("Ordinary bus");
            _man.Transport = "Ordinary bus";
        }
    }
    public class BusMuchMoney : IMoney
    {
        private Man _man;
        public BusMuchMoney(Man man)
        {
            _man = man;
        }

        public void BuildMoney()
        {
            //Console.WriteLine("Express bus");
            _man.Transport = "Express bus";
        }
    }
    //////////////// Taxi /////////////////
    public class TaxiFewMoney : IMoney
    {
        private Man _man;
        public TaxiFewMoney(Man man)
        {
            _man = man;
        }

        public void BuildMoney()
        {
            //Console.WriteLine("Ordinary taxi");
            _man.Transport = "Ordinary taxi";
        }
    }
    public class TaxiMediumMoney : IMoney
    {
        private Man _man;
        public TaxiMediumMoney(Man man)
        {
            _man = man;
        }

        public void BuildMoney()
        {
            //Console.WriteLine("Express taxi");
            _man.Transport = "Express taxi";
        }
    }
    public class TaxiMuchMoney : IMoney
    {
        private Man _man;
        public TaxiMuchMoney(Man man)
        {
            _man = man;
        }

        public void BuildMoney()
        {
            //Console.WriteLine("Business taxi");
            _man.Transport = "Business taxi";
        }
    }
    ///////////// Bicycle ////////////////////
     public class BicycleFewMoney : IMoney
     {
        private Man _man;
        public BicycleFewMoney(Man man)
        {
            _man = man;
        }

        public void BuildMoney()
        {
            //Console.WriteLine("Ordinary bicycle");
            _man.Transport = "Ordinary bicycle";
        }
     }
    public class BicycleMuchMoney : IMoney
    {
        private Man _man;
        public BicycleMuchMoney(Man man)
        {
            _man = man;
        }
       public void BuildMoney()
       {
            //Console.WriteLine("Electro bicycle");
            _man.Transport = "Electro bicycle";

       }
    }


}
