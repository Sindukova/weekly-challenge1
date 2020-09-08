using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double result = minuend - subtrahend;
             
            return result;
        }

        public int Add(int number1, int number2)
        {

            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int smallestNumber = 0;
            int[] a = new int[2];
            a[0] = number1;
            a[1] = number2;
            Array.Sort(a);
            smallestNumber = a[0];
            return smallestNumber;

        }

        public long Multiply(long factor1, long factor2)
        {
            var mult = factor1 * factor2;
            return mult;
        }

        public string GetGreeting(String nameOfPerson)
        {
            

          if (string.IsNullOrEmpty(nameOfPerson))
            {
                return "Hello!";
            }
          else 
            {
                var greetings = "Hello, " + nameOfPerson + "!";
                return greetings;
            }
            

           
        }

        public string GetHey()
        {

            var hey = "HEY!";
            return hey;
        }
    }
}
