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

            //Pass in a reference value
            Console.WriteLine("/nPass in a reference type test:");
            int[] testArray = { 1, 1, 1 };
            Console.WriteLine("Original value : {0}", testArray[0]);
            TestArray(testArray);
            Console.WriteLine("Returned value: {0}", testArray[0]);

            //Out parameter test
            int testVal2;
            //Console.WriteLine("Original value : {0}", testVal2);
            TestOut(out testVal2);
            Console.WriteLine("Return value: {0}", testVal2);

            //Ref parameter test
            int testVal3 = 3;
            //Console.WriteLine("Original value: {0}", testVal3);
            TestRef(ref testVal3);
            Console.WriteLine("Return value: {0}", testVal3);

            //Optional parameter test
            Console.WriteLine("\nCalling TestOptional with a parameter");
            TestOptional();

            //Multiple parameters
            Console.WriteLine("\nTestMultiple set just first 2");
            TestMultiple(1, 2);

            //Named parameters
            Console.WriteLine("\nTestMultiple set just first and third");
            TestMultiple(1, cValue: 3);


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

        public static void TestRef(ref int aValue)
        {
            aValue = 333;
            Console.WriteLine("In TestRef Value is {0}", aValue);
        }

        public static void TestOptional(int aValue = 444)
        {
            Console.WriteLine("In TestOptional Value is {0}", aValue);
        }

        public static void TestMultiple(int aValue, int bValue = 222, int cValue = 333)
        {
            Console.WriteLine("Inside TestMultipe -" + "Values: " + "{0}, {1}, {2}, {3}", aValue, bValue, cValue);
        }
    }
}
