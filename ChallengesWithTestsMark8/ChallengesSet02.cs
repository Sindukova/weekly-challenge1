using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var result = Char.IsLetter(c);
            return result;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (!numbers?.Any() ?? false)
            {
                return 0;
            }
            var min = numbers.Min(i => i);
            var max = numbers.Max(k => k);
            
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 < length2)
            {
                return length1;
            }
                return length2;
            
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var total = numbers.Sum(x => x);
            return total;
           
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var total = numbers.Where(n => (n % 2 == 0)).Sum(n => n);
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            var sum = numbers.Sum(b => b);
            if (sum%2 == 0)
            {
                return false;

            }
            return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            if (number > 0) 
            { 
                var numbers = new int[number - 1];
            
                for (int i = 0; i < (number - 1); i++)
                {
                    numbers[i] = (i + 1);
                    if (numbers[i] % 2 == 0)
                    {
                        count++;
                    }
                    count += 0;
                }
                return count;
            }
            return 0;
            
        }
    }
}
