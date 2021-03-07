using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用埃氏筛法求~100以内的素数
            int[] numbers = new int[99];
            Console.WriteLine("2至100以内的素数为:");
            for (int i=0;i<99;i++)
            {
                numbers[i]= i+2;
            }
           for(int i=2;i<=100;i++)
                for (int k =i-1 ; k <99; k++)
                {
                    if (numbers[k] % i == 0)
                        numbers[k] = 0;
                }
           for(int t=0;t<99;t++)
            {
                if (numbers[t] != 0)
                    Console.WriteLine(numbers[t]);
            }
        }
    }
}
