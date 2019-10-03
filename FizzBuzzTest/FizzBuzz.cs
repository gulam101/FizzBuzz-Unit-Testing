using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{
    //meta data
    /*  
     * It just means it data about data.
     */
    [TestFixture]
    class FizzBuzzTest
    {
        FizzBuzzy fb = new FizzBuzzy(1, 35);
        [Test()]

        public void fizz()
        {

        }

        public void buzz()
        {

        }

        public void fizzbuzz()
        {

        }
        public void TestDivisibility()
        {
            Assert.AreEqual(0.0, fb.DivisibilityBy(6, 3));
            
        }
        [Test()]
        public void TestSubtract()
        {
            Assert.AreEqual(0.0, fb.SubtractBy(5, 2));
        }

        [Test()] 
        public void TestString()
        {
            Assert.AreNotSame("Baby", fb.AnotherOne("Goolag"));
        }
    }
}
