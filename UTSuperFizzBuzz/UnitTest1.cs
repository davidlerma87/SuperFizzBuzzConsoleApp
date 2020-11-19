using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;
using System.Linq;
using Xunit.Sdk;

namespace UTSuperFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckClassicResultIsNotNull()
        {
            var sFB = new SuperFizzBuzz.SuperFizzBuzz("1", "100", 1);
            var result = sFB.RunClassic();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckAdvanceResultContainsValues()
        {
            string[] divisors = new string[3];
            divisors[0] = "4";
            divisors[1] = "13";
            divisors[2] = "9";

            var sFB = new SuperFizzBuzz.SuperFizzBuzz("1", "100", 1, divisors, null);
            var result = sFB.RunAdvance();
            Assert.IsNotNull(result);
        }
    }
}
