using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class CustomTools
    {
        public int num1;
        public int num2;
        public static int Add(int aNum1, int aNum2)
        {
            int num1 = aNum1;
            int num2 = aNum2;
            int result = num1 + num2;
            return result;
        }
        public static int Subtract(int aNum1, int aNum2)
        {
            int num1 = aNum1;
            int num2 = aNum2;
            int result = num1 - num2;
            return result;
        }
        public static int Divide(int aNum1, int aNum2)
        {
            int num1 = aNum1;
            int num2 = aNum2;
            int result = num1 / num2;
            return result;
        }
        public static int Multiply(int aNum1, int aNum2)
        {
            int num1 = aNum1;
            int num2 = aNum2;
            int result = num1 * num2;
            return result;
        }
        public static string ConcatenateStrings(string aString1, string aString2)
        {
            string string1 = aString1;
            string string2 = aString2;
            string result = string1 + " " + string2;
            Console.WriteLine("Printing concatenation:");
            return result;
        }


    }
}
