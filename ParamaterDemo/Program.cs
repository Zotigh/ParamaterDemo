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

            // Pass in a reference value
            Console.WriteLine("/nPass in a reference type test:");
            int[] testArray = { 1, 1, 1 };
            Console.WriteLine("Original value : {0}", testArray[0]);
            TestArray(testArray);
            Console.WriteLine("Returned value: {0}", testArray[0]);

            // Out parameter test
            int testVal2 = 2;
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

        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine("In TestOut Value is {0}", aValue);
        }
    }
}
