using System;

class Program
{
    public static void Main()
    {
        /*
         * some test cases
         */
        AmicableNumbers fn = new AmicableNumbers();
        fn.Start = 1;
        fn.End = 1;
        fn.Calculate();
        Console.WriteLine(fn.ToString());

        fn.Start = 200;
        fn.End = 1200;
        fn.Calculate();
        Console.WriteLine(fn.ToString());

        fn.Start = 100;
        fn.End = 1000;
        fn.Calculate();
        Console.WriteLine(fn.ToString());

        fn.Start = 1;
        fn.End = 10000;
        fn.Calculate();
        Console.WriteLine(fn.ToString());

        long[] numbers = fn.Numbers;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("{0} -> {1}", i, numbers[i]);
        }
    }
}
