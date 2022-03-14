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
            Console.WriteLine();

            int[] studentNo = { 1, 2, 3, 4, 5 }; //陣列儲存值
            string[] Name = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computer = { 80, 65, 100, 98, 83 };
            int[] programming = { 75, 67, 93, 25, 82 };
            int[] animation_design = { 60, 62, 91, 50, 87 };
            Console.Write("請輸入座號(1-5)：");
            string input = Console.ReadLine();
            int input_num = Int32.Parse(input);
            int arrayIndex = Array.IndexOf(studentNo, input_num);
            if (arrayIndex > -1)
            {
                Console.WriteLine("座號：" + studentNo[arrayIndex]);
                Console.WriteLine("姓名：" + Name[arrayIndex]);
                Console.WriteLine("電腦概論：" + computer[arrayIndex]);
                Console.WriteLine("程式設計：" + programming[arrayIndex]);
                Console.WriteLine("動畫設計：" + animation_design[arrayIndex]);
            }
            else
            {
                Console.WriteLine("超出座號範圍");
            }
        }
    }
}
