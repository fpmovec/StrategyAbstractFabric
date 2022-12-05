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
        public void BuildMoney()
        {
            Console.WriteLine("Ordinary bus");
        }
    }
    public class BusMuchMoney : IMoney
    {
        public void BuildMoney()
        { 
            Console.WriteLine("Express bus");
        }
    }
    //////////////// Taxi /////////////////
    public class TaxiFewMoney : IMoney
    {
        public void BuildMoney()
        {
            Console.WriteLine("Ordinary taxi");
        }
    }
    public class TaxiMediumMoney : IMoney
    {
        public void BuildMoney()
        {
            Console.WriteLine("Express taxi");
        }
    }
    public class TaxiMuchMoney : IMoney
    {
        public void BuildMoney()
        {
            Console.WriteLine("Business taxi");
        }
    }
    ///////////// Bicycle ////////////////////
     public class BicycleFewMoney : IMoney
     {
        public void BuildMoney()
        {
           Console.WriteLine("Ordinary bicycle");
        }
     }
    public class BicycleMuchMoney : IMoney
    {
       public void BuildMoney()
       {
          Console.WriteLine("Electro bicycle");
       }
    }


}
