using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var exist = Array.Exists(vals, element => element == false);
            return exist;


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) 
            { 
                return false;
            }
            var oddNumbers = numbers.Where(x => x % 2 != 0);
            var sum = oddNumbers.Sum(z => z);
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            if (!password.Any(ch => char.IsUpper(ch) &&
   password.Any(c => char.IsLower(c) &&
    password.Any(h => char.IsDigit(h)))))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            char[] chars = val.ToCharArray();
            return chars[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] chars = val.ToCharArray();
            return chars[chars.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            return 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums != null)
            {
                return (nums[nums.Length - 1] - nums[0]);
            }
            return 0;
        }

        public int[] GetOddsBelow100()
        {
            List<int> numbers = new List<int>();
            for (int runs = 0; runs < 100; runs++)
            {
                numbers.Add(runs);
            }
            int[] odd = (from y in numbers where ((y % 2) != 0) select y).ToArray();
            return odd;
        }





        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)

            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}


