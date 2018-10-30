using System;

namespace fizzbuzz
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string Said(int input)
        {
            if (isFizzBuzz(input))
            {
                return "FizzBuzz";
            }
            
            if (isFizz(input))
            {
                return "Fizz";
            }
            
            if (isBuzz(input))
            {
                return "Buzz";
            }

            return input.ToString();
        }

        private static bool isBuzz(int input)
        {
            return input % 5 == 0;
        }

        private static bool isFizz(int input)
        {
            return input % 3 == 0;
        }

        private static bool isFizzBuzz(int input)
        {
            return input % 15 == 0;
        }
    }
}