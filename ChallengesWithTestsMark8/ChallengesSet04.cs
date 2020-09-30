using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int odd = 0;
            int even = 0;
           for (int i=0; i<numbers.Length; i++)
            {
                if(numbers[i]%2 == 0)
                {
                    even += numbers[i];
                }
                else
                {
                    odd -= numbers[i];
                }
            }
            int result = even + odd;
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] names = { str1, str2, str3, str4 };
            int minLength = names.Min(y => y.Length);
            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
           int[] numbers= {number1, number2, number3, number4 };
            int min = numbers.Min(x => x);
            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            var bizName = "TrueCoders";
            biz.Name = bizName;
            //biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
                if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
                {
                    return false;
                }
                
                    return true;
          
        }

        public bool IsStringANumber(string input)
        {
           var n = 123;
            var x = 20.2;
            if(input == null)
            {
                return false;
            }
            /* if (input.All(char.IsDigit))
             {
                 return true;
             }
             return false;*/
            bool isNumeric = int.TryParse(input, out n);
           
            bool isDouble = double.TryParse(input, out x);
            return isNumeric || isDouble;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var numNull=objs.Count(x=>x == null);
            if (numNull > objs.Length - numNull)
            {
                return true;
            }
            return false;
        }

       public double AverageEvens(int[] numbers)
        {
            
            if (numbers == null)
            {
                return 0;
            }
            var r = numbers.Where(x=>x%2 ==0).Average(x=>x);
            return r;
            
            
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int f = 1;
            for (int i=1; i<=number; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
