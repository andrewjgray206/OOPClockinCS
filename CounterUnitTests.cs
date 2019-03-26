using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CounterTest
{
    [TestFixture()]
    class CounterUnitTests
    {


        [TestCase("intialise")]
        public void TestInitialisation(string s)
        {
            Counter c = new Counter(s);
            int expected = 0;
            int answer = c.Value;
            Assert.AreEqual(answer, expected);
        }
        
        [TestCase("increment")]
        public void TestIncrement(string s)
        {
            Counter c = new Counter(s);
            int expected = 1;
            c.Increment();
            Assert.AreEqual(expected, c.Value);
        }

        [TestCase("manytick")]
        public void TestManyIncrement(string s)
        {
            Counter c = new Counter(s);
            int expected = 5;
            for (int i=0; i<5; i++)
            {
                c.Increment();
            }
            Assert.AreEqual(expected, c.Value);           
        }
        
        [TestCase("reset")]
        public void TestReset(string s)
        {
            Counter c = new Counter(s);
            int expected = 0;

            c.Increment();
            c.Increment();
            c.Increment();
            c.Reset();

            Assert.AreEqual(expected, c.Value);
        }
    }
}
