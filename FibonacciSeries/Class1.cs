using System;
using System.Collections.Generic;

namespace FibonacciSeries
{
    public class Class1
    {
        public static int numsToSeries = 10;

        public static void Main()
        {
            var cc = new Class1();
            Console.WriteLine(cc.printFibonacciNumber(numsToSeries));
        }


        public List<long> printFibonacciNumber(int num)
        {
            List<long> my_memo = new List<long>();

            long firstNum = 1, secNum = 0;
            int i;
            if (num < 1)
            {
                return my_memo;
            }
            Console.WriteLine("the numbers are...");
            for (i = 1; i <= num; i++)
            {
                my_memo.Add(secNum);
                long next = firstNum + secNum;
                firstNum = secNum;
                secNum = next;
            }
            return my_memo;
        }
    }
}
