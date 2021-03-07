using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数据的个数：");
           string s = Console.ReadLine();
            //i表示用户输入数据的个数
            int i = Convert.ToInt32(s);
            Console.WriteLine("输入数据（每输入一个数据按一次回车键）：");
            string[] numbers = new string[i];//保存用户输入的所有数据
            int[] numbers1 = new int[i];//将用户输入的数据转化为整型
            for (int j = 0; j < i; j++)
            {
                numbers[j] = Console.ReadLine();
                numbers1[j] = Convert.ToInt32(numbers[j]);
            }
            Console.WriteLine("素数为：");
            foreach(int k in numbers1)
            {
                if(Prime(k))
                {
                    Console.WriteLine(k);
                }
            }
        }
        //判断一个数是否为素数的方法
        public static bool Prime(int l)
        {
            bool temp=false;
            for (int n=2;n<=Math.Sqrt(l);n++)
            {
                if (l % n == 0)
                    temp = true;
            }
            return temp;
        }
    }
}
