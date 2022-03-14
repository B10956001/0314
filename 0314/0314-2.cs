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
                Console.WriteLine(str_num + "is weird");
            }
            else if (str_num % 2 == 0)
            {
                if (2 <= str_num && str_num <= 5)
                {
                    Console.WriteLine(str_num + "is not weird");
                }
                else if (6 <= str_num && str_num <= 20)
                {
                    Console.WriteLine(str_num + "is weird");
                }
                else
                {
                    Console.WriteLine(str_num + "is not weird");
                }
            }
        }
    }
}
