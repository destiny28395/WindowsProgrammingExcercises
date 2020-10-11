using System;
using System.Collections.Generic;

namespace _06_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            int select;
            do
            {
                Console.WriteLine("1. Add Student\t2. Exit\nYour select: ");
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Student a = new Student();
                    a.Input();
                    stu.Add(a);
                }
            } while (select != 2);

            Console.WriteLine("\n================Student List =====================");
            //stu.Sort();
            stu.Sort(new NameComparer());
            foreach (Student x in stu)
            {
                x.Output();
            }
        }
    }
}
