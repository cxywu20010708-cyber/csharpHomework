using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数组的大小：");
            string s = Console.ReadLine();
            //i表示用户输入数据的个数
            int i = Convert.ToInt32(s);
            Console.WriteLine("输入数组的每个元素（每输入一个数据按一次回车键）：");
            string[] numbers = new string[i];//保存用户输入的所有数据
            int[] numbers1 = new int[i];//将用户输入的数据转化为整型
            for (int j = 0; j < i; j++)
            {
                numbers[j] = Console.ReadLine();
                numbers1[j] = Convert.ToInt32(numbers[j]);
            }
            int max = numbers1[0];
            int min = numbers1[0];
            double average = 0.0;
            int sum = 0;
            foreach (int g in numbers1)
            {
                if (g > max) max = g;
                if (g < min) min = g;
                sum += g;
            }

            average = Convert.ToDouble(sum) / i;
            Console.WriteLine("最大值为：{0},最小值为{1}，平均值为{2}，所有值的总和为{3}", max, min, average, sum);
        }
     }
}
