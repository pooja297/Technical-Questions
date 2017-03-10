using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        public int AddFunction(int n)
        {
            if (n > 0)
            {
                return n % 10 + AddFunction(n / 10);
            }
            else
                return 0;
            
        }
    }
    public class Permutations
    {
        private bool[] used;
        private StringBuilder outStr = new StringBuilder();
        private readonly string inStr;
    
        public Permutations(string inStr)
        {
            this.inStr = inStr;
            used = new bool[inStr.Length];
        }

        public void Permute()
        {
            if(outStr.Length == inStr.Length)
            {
                Console.WriteLine(outStr);
                return;
            }
            for(int i =0; i<inStr.Length; ++i)
            {
                if (used[i]) continue;
                outStr.Append(inStr[i]);
                used[i] = true;
                Permute();
                used[i] = false;
                outStr.Length = outStr.Length - 1;
            }
        }
    }

    public class Palindrome
    {
       //public bool checkPalindrome(string str)
       // {
       //     for (int i = 0, j = str.Length - 1; i < j; i++,j--){
       //         if(str[i] != str[j])
       //         {
       //             return false;
       //         }
       //     }
       //     return true;
       // }

        public bool checkPalindrome(string str)
        {
            HashSet<char> newStr = new HashSet<char>();

            foreach(char c in str)
            {
                if (newStr.Contains(c))
                {
                    newStr.Remove(c);
                }
                else
                    newStr.Add(c);
            }
            return newStr.Count <= 1;
        }
    }

    class PermutaionOfShorterStringInBiggerString
    {
        public int CountPermutations(string big, string small)
        {
            if(big.Length < small.Length)
            {
                return -1;
            }
            int[] smallArr = new int[26];
            int[] windowArr = new int[26];
            int count = 0;
            for(int i=0; i< small.Length; i++)
            {
                smallArr[small[i] - 'a']++;
                windowArr[big[i] - 'a']++;
            }
            for(int i=small.Length; i<big.Length; i++)
            {
                if(windowArr.SequenceEqual(smallArr))
                {
                    count++;
                }
                windowArr[big[i-(small.Length)] - 'a']--;
                windowArr[big[i] - 'a']++;
            }
            //check for last window
            if (windowArr.SequenceEqual(smallArr))
            {
                count++;
            }
            return count;
        }
    }
}
