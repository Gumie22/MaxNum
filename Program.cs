//This is a C# program to determines the Max number and displays it
using System;

namespace MaxNum.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetMax(30, 12, 28));
            
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}