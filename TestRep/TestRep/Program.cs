using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 10);
            Console.WriteLine(value);
            bool flag = true;
            int v1 = -1, v2 = -1;
            while (v2 != value)
            {
                Console.WriteLine("Введите число: ");
                v2 = Convert.ToInt32(Console.ReadLine());
                if (flag)
                {
                    flag = false;
                    v1 = v2;
                    continue;
                }

                if (Math.Abs(value - v1) < Math.Abs(value - v2))
                {
                    Console.WriteLine("Холоднее");
                }
                else
                {
                    Console.WriteLine("Горячее");
                }
                v1 = v2;
            }

            Console.WriteLine("Успех");
            Console.ReadLine();
        }
    }
}