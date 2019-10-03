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

        //Test for fizzbuz
        [Test()]
        public void testFizz()
        {
            Assert.AreEqual("Fizz", fb.FizzyOutput(3));
        }

        [Test()]
        public void testBuzz()
        {
            Assert.AreEqual("Buzz", fb.FizzyOutput(5));
        }

        [Test()]
        public void testFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", fb.FizzyOutput(15));
        }

    }
}
