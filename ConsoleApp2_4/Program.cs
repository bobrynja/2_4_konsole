using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (a > 0)
                {
                    for (int i = a; i >= 0; i--)
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            Console.Write(j); Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Число должно быть положительным");
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод данных");
            }
            Console.ReadKey();
        }
    }
}
