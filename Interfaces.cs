using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IMoneySituations
    {
        IMoney CreateMoney();
    }
    public interface IMoney
    {
        void BuildMoney();
    }

}
