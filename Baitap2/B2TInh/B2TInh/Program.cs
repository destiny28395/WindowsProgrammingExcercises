using System;

namespace B2TInh
{
    class Program
    {
        public static int Cong(int a, int b)
        {
            return a + b;
        }
        public static int Tru(int a, int b)
        {
            if (a > b)
                return a - b;
            else
                return b - a;
        }
        public static int Nhan(int a, int b)
        {
            return a * b;
        }
        public static float Chia(float a, float b)
        {
            if (a > b)
                return a / b;
            else
                return b / a;
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter number a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sau khi cong la:"+Cong(a, b));
            Console.WriteLine("Sau khi tru la:" + Tru(a, b));
            Console.WriteLine("Sau khi nhan la:" + Nhan(a, b));
            Console.WriteLine("Sau khi chia la:" + (float)Chia(a, b));
        }
    }
}
