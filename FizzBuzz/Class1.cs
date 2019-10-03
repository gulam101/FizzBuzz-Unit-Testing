using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzy
    {
        public List<string> fizzBuzzList;
        public FizzBuzzy()
        {

        }
        public FizzBuzzy(int start, int end)
        {

        }
        public double DivisibilityBy(double value1, double value2)
        {
            return 0;
        }
        public double SubtractBy(double subtractValue1, double subtractValue2)
        {
            return 0;
        }
        public string AnotherOne(string anotherOne)
        {
            return anotherOne;
        }

        //Fizz buzz
        public string FizzyOutput(int input)
        {
            if (input % 15 == 0)
                return "FizzBuzz";

            if (input % 3 == 0)
                return "Fizz";

            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }
    }
}
