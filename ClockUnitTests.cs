using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CounterTest
{
    [TestFixture()]
    class ClockUnitTests
    {
        [Test()]
        public void ClockPrint()
        {
            Clock c = new Clock();
            string expected = "00:00:00";
            string answer = c.PrintTime();

            Assert.AreEqual(expected, answer);
        }

        [Test()]
        public void ClockTick() // a test designed to make sure the clock ticks. compares printed string versus an expected string.
        {
            Clock c = new Clock();
            c.Tick();
            string expected = "00:00:01";
            string answer = c.PrintTime();

            Assert.AreEqual(expected, answer);
        }

        [Test()]
        public void ClockAddHour() //a test designed to make sure the add hour method works properly.
        {
            Clock c = new Clock();
            c.AddHour();

            string expected = "00:00:00";
            string answer = c.PrintTime();

            Assert.AreNotEqual(expected, answer);
        }

        [Test()]
        public void ClockReset() //tests thr reset function of the clock works.
        {
            Clock c = new Clock();
            c.AddHour();
            c.Tick();
            //we now know these 2 functions work from the above tests, now we shall focus on the reset function.
            c.ResetClock();

            string expected = "00:00:00";
            string answer = c.PrintTime();

            Assert.AreEqual(expected, answer);
        }
    }
}
