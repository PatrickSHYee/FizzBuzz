using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        public static string FizzBuzz(int number)
        {
            string BuzzOrNot = "";

            if (number % 3 == 0)
            {
                BuzzOrNot = "Buzz";
                if (number % 5 == 0)
                {
                    BuzzOrNot = "FizzBuzz";
                }
            }
            else if (number % 5 == 0)
            {
                BuzzOrNot = "Fizz";
            }
            else
            {
                BuzzOrNot = number.ToString();
            }
            return BuzzOrNot;
        }
    }
}
