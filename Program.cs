using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 obj = new Class1();
            //int value =  obj.AddFunction(1234);
            //Console.WriteLine("the value is :" + value);

            //value = obj.AddFunction(457);
            //Console.WriteLine("the value is :" + value);
            //Console.ReadLine();

            //Permutations permObj = new Permutations("hat");
            //permObj.Permute();
            //Console.ReadLine();

            //Palindrome palinObj = new Palindrome();
            //bool value = palinObj.checkPalindrome("ismeemsi");
            //Console.WriteLine(value);
            //Console.ReadLine();

            PermutaionOfShorterStringInBiggerString permObj2 = new PermutaionOfShorterStringInBiggerString();
            int value = permObj2.CountPermutations("abcbacdgdbacbdaabdc", "abcd");
            Console.WriteLine("the no. of the permutations of shorter string in bigger string are: " + value);
            Console.ReadLine();
        }
    }
}
