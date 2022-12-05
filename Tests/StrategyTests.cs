using Microsoft.VisualStudio.TestPlatform.TestHost;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class StrategyTests
    {
        [Fact]
        public void Test1()
        {
            NUnit.Framework.Assert.Throws<ArgumentException>(() => MainClass.ManInformation("School", "Taxi", 10));
        }
    }
}
