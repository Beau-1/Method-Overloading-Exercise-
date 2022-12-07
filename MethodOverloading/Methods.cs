using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Method
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2));
            Console.WriteLine(Add(1.6m,2.5m));
            Console.WriteLine(Add(0, 1, true));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isMoney)
        {

            int sum = num1 + num2;
            if (isMoney == true && sum > 1 || sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {

                return $"{sum} dollar";
            }

        }
    }
}


//+ Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean 
//+ If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
//+ You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
