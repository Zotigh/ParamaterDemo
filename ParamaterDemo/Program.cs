using System;

namespace ParamaterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pass bu value test:");
            int testVal1 = 1;
            Console.WriteLine("Original value: {0}", testVal1);
            Test(testVal1);
            Console.WriteLine("Return value: {0}", testVal1);

            // 
        }

        public static void Test(int aValue)
        {
            aValue = 11;
            Console.WriteLine("In test value is {0}", aValue);
        }

        public static void TestArray(int[] anArray)
        {
            anArray[0] = 111;
            Console.WriteLine("In test value is {0}", anArray[0]);
        }

    }
}
