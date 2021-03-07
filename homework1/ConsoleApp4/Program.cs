using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断一个矩阵是不是托普利茨矩阵
            Console.WriteLine("输入矩阵的行数：");
            string line = Console.ReadLine();
            Console.WriteLine("输入矩阵的列数：");
            string row = Console.ReadLine();
            int line1 = Convert.ToInt32(line);
            int row1 = Convert.ToInt32(row);
            Console.WriteLine("输入矩阵：");
            string[] matrix = new string[line1];
            int[,] matrix1 = new int[line1,row1];
            int colum=0;
            for(int i =0;i<line1;i++)
            {
               matrix[i]= Console.ReadLine();
                string[] tempArray = matrix[i].Split(' ');
                colum = tempArray.Length;
                for(int j=0;j<colum;j++)
                {
                    matrix1[i,j] = Convert.ToInt32(tempArray[j]);
                }
            }
            bool b=true;
            for(int k=0;k<colum;k++)
            { int i = 1, j = k + 1;

                int temp = matrix1[0, k];
                while(i<line1&&j<colum)
                {
                    if(matrix1[i,j]!=temp)
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        i++;j++;
                    }
                        
                }
            }
            for (int k = 0; k < line1; k++)
            {
                int i = k+1, j = 1;

                int temp = matrix1[k, 0];
                while (i < line1 && j < colum)
                {
                    if (matrix1[i, j] != temp)
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        i++; j++;
                    }

                }
            }
            Console.WriteLine(b);

        }
    }
}
