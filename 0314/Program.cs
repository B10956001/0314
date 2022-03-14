using System;

namespace _0314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個數字：");
            string str = Console.ReadLine();
            int str_num = Int32.Parse(str);
            if (str_num % 2 != 0)
            {
                Console.WriteLine(str_num + " is weird");
            }
            else if (str_num % 2 == 0)
            {
                if (2 <= str_num && str_num <= 5)
                {
                    Console.WriteLine(str_num + " is not weird");
                }
                else if (6 <= str_num && str_num <= 20)
                {
                    Console.WriteLine(str_num + " is weird");
                }
                else
                {
                    Console.WriteLine(str_num + " is not weird");
                }
            }

            for (int i = 1; i <= str_num; i++) //打印星星
            {
                for (int j = 1; j <= str_num; j++)
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= str_num; i++)  
            {
                Console.WriteLine(str_num + "*" + i + "=" + str_num * i);
            }
            Console.WriteLine();

            for (int i = 1; i <= 9; i++) //99乘法
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i + "*" + j + "=" + i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
